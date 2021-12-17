using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp.net.mvc_lesson3
{
    /// <summary>
    ///  в класcе реализован метод изменения строки с делегатами  к этим методам
    /// </summary>
    public class StringConverter
    {
       public StringConverter() { }
        public delegate string StringCreate(string s);

        /// <summary>
        /// Метод приобразования символов строки в заглавные.
        /// Возварщает пробразованную копию строки
        /// </summary>
        /// <param name="s"> Строка на основании которой нужно создать новую строку </param>
        /// <returns>Возварщает пробразованную копию строки</returns>
        public string LargeCharacters(string s)
        {
            string _s = System.String.Empty;


            for (int i = 0; i < s.Length; i++)
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
