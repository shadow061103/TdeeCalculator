using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class StrategyFactory
    {
        public static TdeeStrategy GetStrategy(Human human)
        {
            Type type = human.Gender.GetStrategyType();
            TdeeStrategy strategy = (TdeeStrategy)Activator.CreateInstance(type);//建立策略實體
            strategy.Human = human;
            return strategy;

        }
    }
    
}
