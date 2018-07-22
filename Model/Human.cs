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

        public Goal Goal { get; set; }

        public bool isHighintensity { get; set; }

        public bool isLabor { get; set; }

    }
   
}
