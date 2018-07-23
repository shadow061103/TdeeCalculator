using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.IO;

namespace TdeeCalculator
{
    public partial class Form1 : Form
    {
        //基代公式
        //Men: 10 x weight(kg) + 6.25 x height(cm) - 5 x age(y) + 5 
        //Women: 10 x weight(kg) + 6.25 x height(cm) - 5 x age(y) - 161
        //活動程度1.2 1.375 1.55 1.725 1.9
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            tbMail.GotFocus += new EventHandler(this.TbGetFocus);
            tbMail.LostFocus += new EventHandler(this.TbLostFocus);
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Age = 0;
            double Weight = 0, Height = 0;
            if (!CheckInput(ref Age, ref Weight, ref Height)) return;
            Human human = new Human()
            {
                Age = Age,
                Weight = Weight,
                Height = Height,
                Gender = (GenderType)cbGender.SelectedIndex,
                Activity = (ActivityType)cbActivity.SelectedIndex,
                Goal = (Goal)cbGoal.SelectedIndex,
                isHighintensity = ckIntensity.Checked,
                isLabor = ckLabor.Checked

            };
            try
            {
                TdeeStrategy strategy = StrategyFactory.GetStrategy(human);
                StringBuilder sb = new StringBuilder();
                sb.Append($"計算結果為Tdee:{strategy.TDEE}\r\n");
                sb.Append($"碳水化合物:{strategy.Nutrituon.Carbon}\r\n");
                sb.Append($"蛋白質:{strategy.Nutrituon.Protein}\r\n");
                sb.Append($"脂肪:{strategy.Nutrituon.Fat}\r\n");
                MessageBox.Show(sb.ToString());
                //
                SendMail(human, strategy.Nutrituon, strategy.TDEE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }







        }
        public void SendMail(Human human, Nutrition nutrition, double Tdee)
        {
            if (ckMail.Checked)
            {
                try
                {
                    //建立excel
                    MemoryStream fs = MailService.GenerateExcel(human, nutrition, Tdee);
                    //寄信
                    MailService.SendMail(tbMail.Text.Trim(), fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }

        }

        #region 檢查輸入
        /// <summary>
        /// 檢查輸入
        /// </summary>
        /// <param name="Age"></param>
        /// <param name="Weight"></param>
        /// <param name="Height"></param>
        public bool CheckInput(ref int Age, ref double Weight, ref double Height)
        {
            if (cbGender.SelectedIndex == -1)
            {
                lblMsg.Text = "請選擇性別跟活動量";
                return false;
            }
            if (cbActivity.SelectedIndex == -1)
            {
                lblMsg.Text = "請選擇活動量";
                return false;
            }
            if (cbGoal.SelectedIndex == -1)
            {
                lblMsg.Text = "請選擇運動目標";
                return false;
            }
            if (!Int32.TryParse(tbAge.Text, out Age))
            {
                lblMsg.Text = "年齡輸入有誤，請再確認";
                return false;
            }
            if (!double.TryParse(tbWeight.Text, out Weight))
            {
                lblMsg.Text = "身高輸入有誤，請再確認";
                return false;
            }
            if (!double.TryParse(tbHeight.Text, out Height))
            {
                lblMsg.Text = "體重輸入有誤，請再確認";
                return false;
            }
            string Msg = "";
            if (ckMail.Checked)
            {
                if (!RegularService.CheckFormat(tbMail.Text, @"\w[-.\w]*\@[-a-z0-9]+(\.[a-z0-9]+)*\.(com|edu|info)", ref Msg))
                {
                    lblMsg.Text = "Email" + Msg;
                    return false;
                }
            }
            return true;
        }
        #endregion
        #region Email欄位事件

        private void ckMail_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
                tbMail.Visible = true;
            else
                tbMail.Visible = false;
        }
        private void TbGetFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Email")
            {
                tb.Text = "";

            }

        }
        private void TbLostFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "")
            {
                tb.Text = "Email";

            }
        }
        #endregion

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("TDEE(Total Daily Energy Expenditure) =  基礎代謝(BMR) + 活動消耗 + 運動消耗 + 食物產熱效應 + 運動後燃"+Environment.NewLine);
            sb.Append(" 基礎代謝：用來維持你的心跳，呼吸，血液循環等等需要的熱量" + Environment.NewLine);
            sb.Append("活動消耗：走路，刷牙，打掃，寫字，讀書所消耗的熱量" + Environment.NewLine);
            sb.Append("運動消耗：跑步，上健身房等所消耗的熱量" + Environment.NewLine);
            sb.Append("食物產熱效應：身體消化食物所消耗的熱量 (一般估計是食物熱量的10%左右，例如你吃100卡的食物，身體需要消耗10卡去消化它)" + Environment.NewLine);
            sb.Append("運動後燃：如果你的運動給予肌肉足夠的刺激，身體會在運動後消耗更多熱量修復肌肉" + Environment.NewLine);


            MessageBox.Show(sb.ToString(),"小知識",MessageBoxButtons.OK);
        }
    }
}
