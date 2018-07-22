using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public static class AttributeHelper
    {
        

        public static Type GetStrategyType(this GenderType gender)
        {
            FieldInfo data = typeof(GenderType).GetField(gender.ToString());
            Attribute attr = Attribute.GetCustomAttribute(data, typeof(StrategyAttribute));
            StrategyAttribute strategy = (StrategyAttribute)attr;
            return strategy.StrategyType;
        }
        public static double GetActivityType(this ActivityType activity)
        {
            FieldInfo data = typeof(ActivityType).GetField(activity.ToString());
            Attribute attr = Attribute.GetCustomAttribute(data, typeof(ActivityAttribute));
            ActivityAttribute Actmult = attr as ActivityAttribute;
            return Actmult.Activitymulti;
        }
        public static double GetTdeePlus(this Goal goal)
        {
            FieldInfo data = typeof(Goal).GetField(goal.ToString());
            Attribute attr = Attribute.GetCustomAttribute(data, typeof(GoalAttribute));
            GoalAttribute tdeeplus = attr as GoalAttribute;
            return tdeeplus.TdeePlus;
        }
    }
}
