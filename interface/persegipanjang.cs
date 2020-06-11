using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class persegipanjang : InterfaceBangunDatar
    {
        public int p,l;

        public void luas()
        {
            Console.Write("Masuk kan Nilai Panjang    = ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai Lebar      = ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas persegi panjang      = " + (p * l));
        }

        public void keliling()
        {
            Console.WriteLine("keliling persegi panjang  = " + (2 * (p + l)));
        }
    }
}
