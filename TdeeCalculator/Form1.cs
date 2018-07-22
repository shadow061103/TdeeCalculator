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
            tbMail.LostFocus+= new EventHandler(this.TbLostFocus);
            //test
            tbAge.Text = "25";
            tbHeight.Text = "170";
            tbWeight.Text = "66.5";
            cbActivity.SelectedIndex = 4;
            cbGoal.SelectedIndex = 1;
            cbGender.SelectedIndex = 0;
            

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Age = 0;
            double Weight=0, Height = 0;
            if(!CheckInput(ref Age, ref Weight, ref Height))return;
            Human human = new Human() {
                Age =Age,
                Weight =Weight,
                Height =Height,
                Gender =(GenderType)cbGender.SelectedIndex,
                Activity=(ActivityType)cbActivity.SelectedIndex,
                Goal=(Goal)cbGoal.SelectedIndex,
                isHighintensity=ckIntensity.Checked,
                isLabor=ckLabor.Checked
                
            };
            TdeeStrategy strategy = StrategyFactory.GetStrategy(human);
            MessageBox.Show("計算結果為" + string.Format($"{strategy.TDEE:F0}"+Environment.NewLine+ strategy.Result));




        }
        #region 檢查輸入
        /// <summary>
        /// 檢查輸入
        /// </summary>
        /// <param name="Age"></param>
        /// <param name="Weight"></param>
        /// <param name="Height"></param>
        public bool CheckInput(ref int Age,ref double Weight,ref double Height)
        {
            if (cbGender.SelectedIndex == -1 )
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
            if(tb.Text == "Email")
            {
                tb.Text = "";
                tb.ForeColor = Color.Gray;
            }

        }
        private void TbLostFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "")
            {
                tb.Text = "Email";
                tb.ForeColor = Color.White;
            }
        }
        #endregion
    }
}
