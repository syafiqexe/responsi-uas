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

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("pilihan menu");
            Console.WriteLine("1. tambah penjualan");
            Console.WriteLine("2. hapus penjualan");
            Console.WriteLine("3. tampil penjualan");
            Console.WriteLine("4. keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();
            Console.WriteLine("tambah data penjualan");
            Console.Write("nota : ");
            penjualan.nota = Console.ReadLine();
            Console.Write("tanggal : ");
            penjualan.tanggal = Console.ReadLine();
            Console.Write("kostumer : ");
            penjualan.customer = Console.ReadLine();
            Console.Write("jenis |t/k|");
            penjualan.jenis = Console.ReadLine();
            Console.Write("total nota :");
            penjualan.total = double.Parse(Console.ReadLine());
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            int no = -1, hapus = -1;
            Console.WriteLine("hapus data penjualan");
            Console.Write("Nota : ");
            string nota = Console.ReadLine();
            foreach (Penjualan penjualan in daftarPenjualan)

            {
                no++;
                if (penjualan.nota == nota)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarPenjualan.RemoveAt(hapus);
                Console.WriteLine("\n data berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\n nota tidak ada");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int no = 0;
            Console.WriteLine("data penjualan");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                no++;
                string jenis;
                if(penjualan.jenis == "t")
                {
                    jenis = "tunai";
                }
                else if(penjualan.jenis == "k")
                {
                    jenis = "kredit";
                }
                else
                {
                    jenis = "jenis tidak ada";
                }
                Console.WriteLine(no + ". " + penjualan.nota + ", " + penjualan.tanggal + ", " + penjualan.customer + ", " + jenis + ", " + penjualan.total);
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
