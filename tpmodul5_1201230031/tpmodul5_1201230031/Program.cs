using System;

namespace tpmodul5_1201230031
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menggunakan kelas HaloGeneric
            HaloGeneric<string> halo = new HaloGeneric<string>();
            halo.SapaUser("John"); // Output: Halo user John

            // Menggunakan kelas DataGeneric
            DataGeneric<string> data = new DataGeneric<string>("1201230031"); // Ganti dengan NIM Anda
            data.PrintData(); // Output: Data yang tersimpan adalah: 1201230031
        }
    }
}
