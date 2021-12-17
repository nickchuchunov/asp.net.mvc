using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StringConverter
    {

        public string LargeCharacters(string s) 
        {
            string _s = System.String.Empty;
          

            for (int i =0; i<s.Length; i++) 
            {
            
                char c = s[i];
                if (char.IsPunctuation(c) == false && char.IsControl(c) == false && char.IsDigit(c) == false && char.IsLower(c) == true && char.IsNumber(c) == false && char.IsSymbol(c) == false && char.IsWhiteSpace(c) == false)
                {
                    _s += char.ToUpper(c);

                }
                else
                {
                    _s += c;

                }


            }


            return _s;
        
        }



    }
}
