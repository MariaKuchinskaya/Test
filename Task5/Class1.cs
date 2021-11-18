using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Class1: BaseClass
    {
        int chislo1;

        public Class1(int chislo, string text, int chislo1) : base (chislo, text)
        {

            this.chislo1 = chislo1;
        }

        public override void PrintInformation()
        {

            Console.WriteLine(chislo1);
            Console.WriteLine(text);
            Console.WriteLine(chislo);
        }
    }
}
