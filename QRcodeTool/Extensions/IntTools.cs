using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace norplan.adm.qrtoolui
{
    public static class IntTools
    {
        public static int AsInt(this double pDouble)
        {
            return Convert.ToInt32(pDouble);
        }
    }
}
