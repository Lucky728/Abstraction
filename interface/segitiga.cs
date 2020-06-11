using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class segitiga : InterfaceBangunDatar
    {
        public int s = 0;
        public float a, t;

        public void luas()
        {
            Console.Write("Masuk kan Nilai Alas      = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masuk kan Nilai Tinggi  = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masuk kan Nilai Sisi      = ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas segitiga            = " + ((a * t) / 2));
        }

        public void keliling()
        {
            Console.WriteLine("keliling segitiga      = " + (s + s + s));
        }
    }
}
