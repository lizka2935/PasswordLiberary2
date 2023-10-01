using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            if (password.Length > 7) 
            {
                a += 1;
            }
            if ( password.Any(Char.IsDigit))
            {
                a += 1;
            }
            if (password.Any(Char.IsLower))
            {
                a += 1;
            }
            if (password.Any(Char.IsUpper))
            {
                a += 1;
            }
            if (password.Intersect("#$%'&_.,/+=-*^!@").Count() > 0)
            {
                a += 1;
            }
            if (password.Intersect("йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ").Count() > 0) 
            { 
                throw new Exception("Использование элементов кириллицы") ;
            }



            return a;

        }
    }
}
