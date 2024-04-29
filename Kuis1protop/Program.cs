using System;
using System.Collections.Generic;
using System.Linq;
using Kuis1protop;

class Program
{
    static void Main(string[] args)
    {
        // Daftar produk
        List<Produk> daftarProduk = new List<Produk>
        {
            new Produk("Laptop", 8000000, 10),
            new Produk("Mouse", 150000, 50),
            new Produk("Keyboard", 300000, 30)
        };

        // Login
        Console.WriteLine("Masukkan username:");
        string username = Console.ReadLine();
        Console.WriteLine("Masukkan password:");
        string password = Console.ReadLine();

        if (username == "admin" && password == "admin")
        {
            Console.WriteLine("Login berhasil!\n");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("0. Tampilkan Produk");
                Console.WriteLine("1. Cari Produk");
                Console.WriteLine("2. Sortir Produk berdasarkan Stok");
                Console.WriteLine("3. Tambah Produk Baru");
                Console.WriteLine("4. Hapus Produk");
                Console.WriteLine("5. Keluar");

                Console.WriteLine("Pilih menu (1-5):");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Daftar Produk:");
                        foreach (var produk in daftarProduk)
                        {
                            produk.TampilkanProduk();
                        }
                        break;
                    case "1":
                        Console.WriteLine("Masukkan kata kunci pencarian:");
                        string keyword = Console.ReadLine();
                        Console.WriteLine("Masukkan harga minimum:");
                        double minPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukkan harga maksimum:");
                        double maxPrice = Convert.ToDouble(Console.ReadLine());

                        var searchResult = daftarProduk.Where(p => p.Nama.ToLower().Contains(keyword) && p.Harga >= minPrice && p.Harga <= maxPrice);
                        foreach (var produk in searchResult)
                        {
                            produk.TampilkanProduk();
                        }
                        break;

                    case "2":
                        var sortedByStok = daftarProduk.OrderByDescending(p => p.Stok);
                        foreach (var produk in sortedByStok)
                        {
                            produk.TampilkanProduk();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Masukkan nama produk baru:");
                        string namaProdukBaru = Console.ReadLine();
                        Console.WriteLine("Masukkan harga produk baru:");
                        double hargaProdukBaru = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Masukkan stok produk baru:");
                        int stokProdukBaru = Convert.ToInt32(Console.ReadLine());

                        daftarProduk.Add(new Produk(namaProdukBaru, hargaProdukBaru, stokProdukBaru));
                        Console.WriteLine("Produk baru berhasil ditambahkan.");
                        break;

                    case "4":
                        Console.WriteLine("Masukkan nama produk yang ingin dihapus:");
                        string namaProdukHapus = Console.ReadLine();

                        var produkToRemove = daftarProduk.FirstOrDefault(p => p.Nama.Equals(namaProdukHapus, StringComparison.OrdinalIgnoreCase));
                        if (produkToRemove != null)
                        {
                            daftarProduk.Remove(produkToRemove);
                            Console.WriteLine("Produk berhasil dihapus.");
                        }
                        else
                        {
                            Console.WriteLine("Produk tidak ditemukan.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Terima kasih!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Login gagal. Username atau password salah.");
        }
    }
}
