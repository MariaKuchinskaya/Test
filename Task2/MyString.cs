using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyString
    {
        public string text;

        public MyString(string text)
        {
            this.text = text;
        }

        public string Reverse()
        {
            var result = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            return result;
        }
    }
}
