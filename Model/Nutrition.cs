using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Nutrition
    {
        public double Carbon;
        public double Fat;
        public double Protein;
        private double _weightbylbl;
        private double _tdee;

        public Nutrition(double Weight,double Tdee)
        {
            _weightbylbl = Weight * 2.2;//體重轉換成磅
            _tdee = Tdee;

        }
        private void Calculate() //計算每天所需營養素
        {
            Protein = _weightbylbl;
            Fat = _weightbylbl * 0.4;
            Carbon = (_tdee - (Protein * 4) - (Fat * 9))/4;
        }
        public string GetNutritionResult()
            {
            Calculate();
            return $"您的營養素建議為\r\n碳水化合物{Carbon}克\r\n蛋白質{Protein}克\r\n脂肪{Fat}克";
            
            
            }

    }
}
