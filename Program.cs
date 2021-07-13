using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {

        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4:
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
        Console.Clear();
        Console.Title = "Pilih Menu Aplikasi ";
        Console.Write = "1. Tambah Mahasiswa";
        Console.WriteLine();
        Console.Write = "2. Hapus Mahasiswa";        
        Console.WriteLine();
        Console.Write = "3. Tampilkan Mahasiswa";
        Console.WriteLine();
        Console.Write = "4. Keluar";
        Console.WriteLine();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.Write("NIM : ");
            int nim = Console.ReadLine();
            Console.Write("Nama : ");
            string nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] ");
            string jenis = Console.ReadLine();
            Console.Write("IPK : ");
            double ipk = Console.ReadLine();
            if (jenis == "L")
            {
                jenis = "Laki-Laki";
            }
            else
            {
                jenis = "Perempuan";
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Mahasiswa");
            string hapus;
            Console.WriteLine("NIM : ");
            hapus = Console.ReadLine();
            int x = 0;
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                if (hapus == Mahasiswa.Nim)
                {
                    daftarMahasiswa.RemoveAt(x);
                    Console.WriteLine("Data mahasiswa berhasil di hapus");
                    break;
                }
                x++;
                Console.WriteLine("NIM tidak ditemukan");
            }


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa");
            int no = 1;
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", no, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.Jenis,
                mahasiswa.IPK);
                no++;
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
