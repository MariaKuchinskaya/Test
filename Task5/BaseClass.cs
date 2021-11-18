using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class BaseClass
    {
        public int chislo;
        public string text;

        public BaseClass(int chislo, string text)
        {
            this.chislo = chislo;
            this.text = text;

        }

        public virtual void PrintInformation()
        {
            Console.WriteLine(text, chislo);
        }
    }
}
