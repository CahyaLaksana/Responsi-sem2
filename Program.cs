using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

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
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

                     
            Console.Clear();

            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");

            Console.ReadKey();
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            Penjualan penjualan = new Penjualan();
            Console.WriteLine("Tambah Data Penjualan");
            Console.Write("Nota         : ");
            penjualan.nt = Console.ReadLine();
            Console.Write("Tanggal      : ");
            penjualan.tgl = Console.ReadLine();
            Console.Write("Customer     : ");
            penjualan.customer = Console.ReadLine();
            Console.Write("Jenis [T/K]  : ");
            penjualan.bayar = Console.ReadLine();
            Console.Write("Total Nota   : ");
            penjualan.total = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(penjualan);

             Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();

        }

        static void HapusPenjualan()
        {
            Console.Clear();

           int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Penjualan");
            Console.Write("Nota  : ");
            string nota = Console.ReadLine();
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                if (penjualan.nt == nota)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.WriteLine("\nData penjualan berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\n Nota tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

           
            int no = 0;
            Console.WriteLine("Data Penjualan");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                string bayar;
                if(penjualan.bayar == "T")
                {
                    bayar = "tunai";
                }
                else if(penjualan.bayar == "K")
                {
                    bayar = "kredit";
                }
                else
                {
                    bayar = "Jenis tidak diketahui";
                }
                Console.WriteLine(no + ". " + penjualan.nt + ", " + penjualan.tgl + ", " + penjualan.customer + ", " + bayar + ", " + penjualan.total);
            }
            if (no < 1)
            {
                Console.WriteLine("Data Penjualan Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
