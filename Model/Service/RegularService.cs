using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
   public class RegularService
    {
        public static bool CheckFormat(string InputValue, string strRegex,ref string Msg)
        {
            
            Regex pattern = new Regex(strRegex);//RegexOptions.IgnoreCase
            Match match = pattern.Match(InputValue);
            if (match.Success)
            {
                return true;
            }
            else
            {
                Msg = "格式有誤";
                return false;
            }
        }
    }
}
