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
        public double _goalPlus;//目標乘數
        private double _bmr;
        private double _tdee;
        public double BMR {
            get {
                GetBMR();
                return _bmr;
            }
        }
        public double TDEE {
            get {
                GetTDEE();
                return _tdee;
            }
        }
        public string Result {
            get {
                Nutrition n = new Nutrition(Human.Weight, TDEE);
                return n.GetNutritionResult();
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
            double multi = _activity + (Human.isHighintensity ? 0.08:0) + (Human.isLabor ? 0.25:0);
            _tdee =BMR * multi * (1+_goalPlus);
            
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
