using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{
    public class persegi : BangunDatar
    {
        public int x;

        public override void Luas()
        {
            Console.Write("Masuk kan Nilai Sisi   = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas persegi          = " + (x * x));
        }

        public override void Keliling()
        {
            Console.WriteLine("keliling persegi     = " + (4 * x));
        }
    }
}
