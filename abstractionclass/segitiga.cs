using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{
    public class segitiga : BangunDatar
    {
        public int s = 0;
        public float a,t;

        public override void Luas()
        {
            Console.Write("Masuk kan Nilai Alas        = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masuk kan Nilai Tinggi     = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai Sisi            = ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas segitiga                = " + ((a * t) / 2));
        }

        public override void Keliling()
        {
            Console.WriteLine("keliling segitiga         = " + (s + s + s));
        }
    }
}
