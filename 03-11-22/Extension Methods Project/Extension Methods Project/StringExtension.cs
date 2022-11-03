using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Project
{
    public static class StringExtension
    {
        public static string ToProper(this string oldText)
        {
         

            if (oldText.Trim().Length == 0 || oldText==null)
            {
                return oldText;
            }
            else
            {
                string properCaseText=null;
                oldText=oldText.Trim().ToLower();
                string[] splittedString = oldText.Trim().Split(' ');
                foreach (string eachWord in splittedString)
                {
                    char [] allChar=eachWord.ToCharArray();
                    allChar[0] = char.ToUpper(allChar[0]);
                    if (properCaseText == null )
                    {
                        properCaseText = new string(allChar);

                    }
                    else
                    {
                        properCaseText = properCaseText+" "+new string(allChar);
                    }

                }
                return properCaseText;
            }
            

        }
    }
}
