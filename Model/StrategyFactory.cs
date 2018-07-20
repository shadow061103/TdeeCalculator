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
            Type type = StrategyHelper.GetStrategyType(human.Gender);
            TdeeStrategy strategy = (TdeeStrategy)Activator.CreateInstance(type);//建立策略實體
            strategy.Human = human;
            strategy._activity = StrategyHelper.GetActivityType(human.Activity);
            return strategy;

        }
    }
    public class StrategyHelper
    {
        public static Type GetStrategyType(GenderType gender)
        {
            FieldInfo data = typeof(GenderType).GetField(gender.ToString());
            Attribute attr = Attribute.GetCustomAttribute(data, typeof(StrategyAttribute));
            StrategyAttribute strategy = (StrategyAttribute)attr;
            return strategy.StrategyType;
        }
        public static double GetActivityType(ActivityType activity)
        {
            FieldInfo data= typeof(ActivityType).GetField(activity.ToString());
            Attribute attr = Attribute.GetCustomAttribute(data, typeof(ActivityAttribute));
            ActivityAttribute Actmult = attr as ActivityAttribute;
            return Actmult.Activitymulti;
        }
    }
}
