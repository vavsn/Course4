using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearchEmail
{
    class WorkWithString
    {
        private static char _delimiteremail = '@';
        private static char _delimitersubstring = '&';
        private static char _dotsymbol = '.';

        public void SearchMail(ref string s)
        {
            if(s == string.Empty)
            {
                throw new Exception("Пустая строка");
            }
            if (s.Count(f => f == _delimitersubstring) != 1)
            {
                throw new Exception("Отсутствует разделитель строки");
            }
            if (s.Count(f => f == _delimiteremail) != 1)
            {
                throw new Exception("Отсутствует корректный email-адрес");
            }
            string[] strarr = s.Split(new char[] { _delimitersubstring });

            if (strarr[1].IndexOf(_delimiteremail) >= strarr[1].IndexOf(_dotsymbol))
            {
                throw new Exception("Отсутствует корректный email-адрес");
            }

            s = strarr[1];
        }
    }
}
