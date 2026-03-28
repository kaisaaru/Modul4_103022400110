using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek KodePaket
        KodePaket kode = new KodePaket();
        Console.WriteLine("Masukkan nama paket (Basic, Standard, Premium, Unlimited, Gaming, Streaming, Family, Business, Student, Traveler):");
        string namaPaket = Console.ReadLine();

        // Get KodePaket berdasarkan nama paket
        string kodepaket = kode.getKodePaket(namaPaket);

        Console.WriteLine("Kode paket untuk " + namaPaket + " adalah: " + kodepaket);
    }
}