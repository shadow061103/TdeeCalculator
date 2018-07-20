using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class TdeeStrategy
    {
        public Human Human { get; set; }

        protected double _deduct; //BMR 減去值
        public double _activity;//活動量

        private double _bmr;
        private double _tdee;
        public double BMR {
            get {
                GetBMR();
                return _bmr;
            }
        }
        public string TDEE {
            get {
                GetTDEE();
                return  string.Format($"{_tdee:F0}");
            }
        }
        private void GetBMR() //計算基礎代謝
        {
            if (Human.Weight > 0 && Human.Height > 0 && Human.Age > 0)
            {
                _bmr = (10 * Human.Weight) + (6.25 * Human.Height) - (5 * Human.Age) + _deduct; //BMR公式
            }
            else
            {
                _bmr = -1;
            }
        }
        private void GetTDEE()
        {
            _tdee=BMR * _activity;


        }



    }
    public class ManTdeeStrategy : TdeeStrategy
    {
        public ManTdeeStrategy()
        {
            _deduct = 5;
        }
    }
    public class WomanTdeeStrategy : TdeeStrategy
    {
        public WomanTdeeStrategy()
        {
            _deduct = -161;
        }
    }

}
