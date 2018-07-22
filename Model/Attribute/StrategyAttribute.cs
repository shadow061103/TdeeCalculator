using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class StrategyAttribute:Attribute
    {
        public Type StrategyType { get; private set; }
        public StrategyAttribute(Type strategyType)
        {
            StrategyType = strategyType;
        }
    }
}
