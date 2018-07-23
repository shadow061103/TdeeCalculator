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
        ICalculate calculate;
        public TdeeStrategy(double deduct) {
            //用泛型工廠建立實體
            calculate= GenericFactory.CreateInastance<ICalculate>(typeof(CalculateService), new object[] { deduct });
        }


        public double BMR {
            get {
               
                return calculate.CalculateBMR(Human);
            }
        }
        public double TDEE {
            get {
                
                return calculate.CalculateTdee(Human);
            }
        }
        public Nutrition Nutrituon
        {
            get
            {
                return calculate.CalculateNutrition(Human);
            }
        }
        
    }
    public class ManTdeeStrategy : TdeeStrategy
    {
        public ManTdeeStrategy():base(5)
        {
           
        }
    }
    public class WomanTdeeStrategy : TdeeStrategy
    {
        public WomanTdeeStrategy():base(-161)
        {
           
        }
    }

}
