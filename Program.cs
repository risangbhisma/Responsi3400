using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            bool statusMenu = true;


            while (statusMenu)
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
                        statusMenu = false;
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.Write("NIM : ");
            string nim = Console.ReadLine();
            Console.Write("NAMA :");
            string nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] :");
            char kelamin = Convert.ToChar(Console.ReadLine());
            string jenisKelamin;
            if (kelamin == 'L')
            {
                jenisKelamin = "Laki-Laki";
            }
            else
            {
                jenisKelamin = "Perempuan";
            }

            Console.Write("IPK :");
            string ipk = Console.ReadLine();
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Nim = nim;
            mahasiswa.NamaMahasiswa = nama;
            mahasiswa.JenisKelamin = jenisKelamin;
            mahasiswa.IPK = ipk;
            daftarMahasiswa.Add(mahasiswa);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Hapus Data Mahasiswa");
            Console.WriteLine();
            Console.Write("NIM : ");
            string nim = Console.ReadLine();
            bool status = false;

            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                if (mhs.Nim == nim)
                {
                    daftarMahasiswa.Remove(mhs);
                    Console.WriteLine();
                    Console.WriteLine("Data Mahasiswa berhasil di hapus");
                    status = true;
                    break;
                }
            }
            if (!status)
            {
                Console.WriteLine();
                Console.WriteLine("NIM tidak ditemukan");

            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa\n");
            int i = 1;
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", i, mhs.Nim, mhs.NamaMahasiswa, mhs.JenisKelamin, mhs.IPK);
                i++;
            }
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}