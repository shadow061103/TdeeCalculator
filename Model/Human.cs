using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Human
    {
        public int Age { get; set; }
        public double Weight { get; set; }

        public double Height { get; set; }

        public GenderType Gender { get; set; }

        public ActivityType Activity { get; set; }

    }
    public enum GenderType
    {
        [Strategy(typeof(ManTdeeStrategy))]
        Man=0,
        [Strategy(typeof(WomanTdeeStrategy))]
        Woman =1
    }
    public enum ActivityType //活動量 值:selectindex 屬性值:活動量乘數
    {
        [Activity(1.2)]
        Sedentary=0,
        [Activity(1.375)]
        Light=1,
        [Activity(1.55)]
        Moderate=2,
        [Activity(1.725)]
        Heavy=3,
        [Activity(1.9)]
        Athlete=4
            
    }
}
