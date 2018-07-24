using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public static class AttributeHelper//擴充方法
    {
        public static K GetAttribute<T, K>(T enumtype) where K :Attribute where T:struct
        {
            FieldInfo data = typeof(T).GetField(enumtype.ToString());
            Attribute attr = Attribute.GetCustomAttribute(data, typeof(K));
            K strategy = (K)attr;
            return strategy;
        }

        public static Type GetStrategyType(this GenderType gender)
        {
            return GetAttribute<GenderType, StrategyAttribute>(gender).StrategyType;
           
        }
        public static double GetActivityType(this ActivityType activity)
        {
            return GetAttribute<ActivityType, ActivityAttribute>(activity).Activitymulti;
            
        }
        public static double GetTdeePlus(this Goal goal)
        {
            return GetAttribute<Goal, GoalAttribute>(goal).TdeePlus;
           
        }
    }
}
