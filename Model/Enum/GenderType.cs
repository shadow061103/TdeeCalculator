using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public enum GenderType
    {
        [Strategy(typeof(ManTdeeStrategy))]
        Man = 0,
        [Strategy(typeof(WomanTdeeStrategy))]
        Woman = 1
    }
}
