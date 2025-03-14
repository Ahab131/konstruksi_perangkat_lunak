using System;

namespace tpmodul5_1201230031
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance dari class DataGeneric dengan tipe string
            DataGeneric<string> data = new DataGeneric<string>("1201230031"); // Ganti dengan NIM Anda

            // Memanggil method PrintData
            data.PrintData();
        }
    }
}