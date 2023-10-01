using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordLiberary2
{
    public class PasswordClass
    {
        /// <summary>
        /// Метод, который проводит проверку над паролем и проверяет его на сложность
        /// </summary>
        /// <param name="password">В качестве параметра передается строка - пароль</param>
        /// <returns>Метод возвращает целое число, соответствующее сложности пароля</returns>
        public static int PasswordStrengthCheker(string password)
        {
            int a = 0;
            if (Regex.Match(password, @"(?=.{7,}$)").Success) 
            {
                a += 1;
            }
            if (Regex.Match(password, @"(?=.*\d)").Success)
            {
                a += 1;
            }
            if (Regex.Match(password, @"(?=.*[a-z])").Success)
            {
                a += 1;
            }
            if (Regex.Match(password, @"(?=.*[A-Z])").Success)
            {
                a += 1;
            }
            if (Regex.Match(password, @"[(\!\@\#\$\%\^\&\*\(\)\{\}\;\.\,\[\]\+\=\-\>\<]").Success)
            {
                a += 1;
            }
            if (Regex.Match(password, @"(?=.*[а-я])|(?=.*[А-Я])").Success) 
            { 
                throw new Exception("Использование элементов кириллицы") ;
            }



            return a;

        }
    }
}
