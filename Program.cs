using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2846
{
    class Program
    {
        static void Main(string[] args)
    {
        Karyawan k1 = new Karyawan (" 190302123 ", " Paijo ", 3000000);
        Tampil ( k1 );
        Karyawan k2 = new Karyawan (" 190302124 ", " Jono ", 2000000);
        Tampil ( k2 );

        Console.WriteLine(" \n Asyiiiiik kenaikan gaji 10%!! \n ");
        Tampil2(k1);
        Tampil2(k2);

        Console.ReadKey();
    }
    static void Tampil(Karyawan k)
    {
        if (k.Nama == " Paijo ")
        {
            Console.WriteLine(" No Nik/Nama                Gaji Bulanan ");
            Console.WriteLine(" --------------------------------------- ");
            Console.WriteLine(" 1.{0}{1}       {2} ", k.Nik, k.Nama, k.GajiBulanan);
        }
        else
            {
             Console.WriteLine(" 2.{0}{1}        {2} ", k.Nik, k.Nama, k.GajiBulanan);
        }
    }
    static void Tampil2(Karyawan i)
    {
        int naik, total;
        naik = (10 * i.GajiBulanan) / 100;
        total = i.GajiBulanan + naik;
        if (i.Nama == " Paijo ")
        {
            Console.WriteLine(" No Nik/Nama                Gaji Bulanan ");
            Console.WriteLine(" --------------------------------------- ");
            Console.WriteLine(" 1.{0}{1}       {2} ", i.Nik, i.Nama, total);
        }
        else
            {
            Console.WriteLine(" 2.{0}{1}        {2} ", i.Nik, i.Nama, total);
        }
    }
}
}