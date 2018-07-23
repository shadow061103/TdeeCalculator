using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class CalculateService: ICalculate
    {
        private double _deduct; //BMR 減去值
        private double _activity;//活動量
        private double _goalPlus;//目標乘數
        private double _bmr;
        private double _tdee;

        public CalculateService(double deduct)
        {
            this._deduct = deduct;
        }
        //基礎代謝率
        public double CalculateBMR(Human human)
        {
            if (human.Weight > 0 && human.Height > 0 && human.Age > 0)
            {
                _bmr = (10 * human.Weight) + (6.25 * human.Height) - (5 * human.Age) + _deduct; //BMR公式
            }
            else
            {
                _bmr = -1;
            }
            return _bmr;
        }
        //加上活動量的TDEE
        public double CalculateTdee(Human human)
        {
            CalculateBMR(human); //先取得BMR
             _activity = human.Activity.GetActivityType();//活動量
            _goalPlus = human.Goal.GetTdeePlus();//目標值
            double multi = _activity + (human.isHighintensity ? 0.08 : 0) + (human.isLabor ? 0.25 : 0);
            _tdee = _bmr * multi * (1 + _goalPlus);

            return _tdee;
        }
        //計算每天所需營養素
        public Nutrition CalculateNutrition(Human human)
        {
            CalculateTdee(human);
            double _weightbylbl = human.Weight * 2.2; //體重換算成磅計算
            double protein=0, fat=0, carbon = 0;
            protein= _weightbylbl; //每磅體重1g蛋白
            fat= _weightbylbl * 0.4;//每磅體重0.4g脂肪
            carbon = (_tdee - (protein * 4) - (fat * 9)) / 4;
            var temp = new Nutrition() { Carbon= carbon,Protein= protein,Fat= fat };

            return temp;
        }
    }
}
