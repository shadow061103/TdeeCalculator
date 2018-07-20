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

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //GenderType dd = (GenderType)Enum.Parse(typeof(GenderType), Enum.GetName(typeof(GenderType), 1));
           
            int Age = 0;
            double Weight=0, Height = 0;
            CheckInput(ref Age, ref Weight, ref Height);
            Human human = new Human() {
                Age =Age,
                Weight =Weight,
                Height =Height,
                Gender =(GenderType)cbGender.SelectedIndex,
                Activity=(ActivityType)cbActivity.SelectedIndex
            };
            TdeeStrategy strategy = StrategyFactory.GetStrategy(human);
            lblMsg.Text = "計算結果為" + strategy.TDEE;






        }
        /// <summary>
        /// 檢查輸入
        /// </summary>
        /// <param name="Age"></param>
        /// <param name="Weight"></param>
        /// <param name="Height"></param>
        public void CheckInput(ref int Age,ref double Weight,ref double Height)
        {
            if (cbGender.SelectedIndex == -1 || cbActivity.SelectedIndex == -1)
            {
                lblMsg.Text = "請選擇性別跟活動量";
                return;
            }
            if (!Int32.TryParse(tbAge.Text, out Age))
            {
                lblMsg.Text = "年齡輸入有誤，請再確認";
                return;
            }
            if (!double.TryParse(tbHeight.Text, out Weight))
            {
                lblMsg.Text = "身高輸入有誤，請再確認";
                return;
            }
            if (!double.TryParse(tbWeight.Text, out Height))
            {
                lblMsg.Text = "體重輸入有誤，請再確認";
                return;
            }

        }
    }
}
