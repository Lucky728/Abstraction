using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{
    public class persegipanjang : BangunDatar
    {
        public int p,l;

        public override void Luas()
        {
            Console.Write("Masuk kan Nilai Panjang = ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai Lebar      = ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas persegi panjang  = " + (p * l));
        }

        public override void Keliling()
        {
            Console.WriteLine("keliling persegi panjang    = " + (2 * (p + l)));
        }
    }
}
