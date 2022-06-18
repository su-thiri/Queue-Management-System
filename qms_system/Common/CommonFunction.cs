using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qms_system.Common
{
    public static class CommonFunction
    {
        public static string ConvertTokenToStr(int number)
        {

            string str = number.ToString();
            if( str.Length == 1)
            {
                str = " Token : 000" + str;
            }
            if (str.Length == 2)
            {
                str = " Token : 00" + str;
            }
            if (str.Length == 3)
            {
                str = " Token : 0" + str;
            }
            if (str.Length == 4)
            {
                str = " Token : " + str;
            }
            return str;
            
        } 
    }
}