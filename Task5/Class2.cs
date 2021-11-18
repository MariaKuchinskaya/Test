using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Class2: BaseClass
    {
        int chislo2;

        public Class2(int chislo, string text, int chislo2) : base(chislo, text)
        {

            this.chislo2 = chislo2;
        }

        public override void PrintInformation()
        {

            Console.WriteLine(chislo2);
            Console.WriteLine(text);
            Console.WriteLine(chislo);
        }
    }
}
