namespace Kuis1protop
{
    internal class Produk
    {
        public string Nama { get; set; }
        public double Harga { get; set; }
        public int Stok { get; set; }

        public Produk(string nama, double harga, int stok)
        {
            Nama = nama;
            Harga = harga;
            Stok = stok;
        }

        public void TampilkanProduk()
        {
            Console.WriteLine("Nama: " + Nama);
            Console.WriteLine("Harga: " + Harga);
            Console.WriteLine("Stok: " + Stok);
            Console.WriteLine("===============");
        }
    }
}
