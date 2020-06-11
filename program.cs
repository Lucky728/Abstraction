using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractionClass;      //Digunakan apabila menggunakan Abstraction Class
using Abstraction.Interface;            //Digunakan apabila menggunakan interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANGUN RUANG");
            Console.WriteLine();

            //BangunDatar bangundatar;  //Digunakan apabila menggunakan Abstraction Class
            interfaceBangunDatar bangundatar;   //Digunakan apabila menggunakan interface

            Console.WriteLine("1. persegi");
            bangundatar = new persegi();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("2. persegi Panjang");
            bangundatar = new persegipanjang();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("3. segitiga");
            bangundatar = new segitiga();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.ReadKey(true);
        }
    }
}
