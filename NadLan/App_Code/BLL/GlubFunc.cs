using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class GlubFunc
    {
        public static string GetRandeomStr(int size)
        {
            string retval = "";
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                int index = rnd.Next(0, chars.Length);
                retval += chars[index];

            }
            return retval;
        }
    }
}