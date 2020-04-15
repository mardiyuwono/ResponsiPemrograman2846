using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2846
{
    class Karyawan
    {
    public string Nik { get; set; }
    public string Nama { get; set; }
    public int GajiBulanan { get; set; }

    public Karyawan(String nik, String nama, int gajibulanan)
    {
        this.Nik = nik;
        this.Nama = nama;
        if (gajibulanan < 0)
        {
            this.GajiBulanan = 0;
        }
        else
            {
            this.GajiBulanan = gajibulanan;
        }
    }


}
}