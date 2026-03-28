using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek KodePaket
        KodePaket kode = new KodePaket();
        Console.Write("Masukkan nama paket (Basic, Standard, Premium, Unlimited, Gaming, Streaming, Family, Business, Student, Traveler):");
        string namaPaket = Console.ReadLine();

        // Get KodePaket berdasarkan nama paket
        string kodepaket = kode.getKodePaket(namaPaket);

        Console.WriteLine("Kode paket untuk " + namaPaket + " adalah: " + kodepaket);

        Console.WriteLine("------------");

        // Membuat objek MesinKopi
        MesinKopi mesin = new MesinKopi();

        Console.WriteLine("Simulasi State Kopi");
        Console.WriteLine("");

        mesin.PowerOn(); // OFF -> STANDBY
        mesin.TampilkanState(); // Tampilkan state saat ini
        Console.WriteLine("");

        mesin.StartBrew(); // STANDY -> BREWING
        mesin.TampilkanState(); // Tampilkan state saat ini
        Console.WriteLine("");

        mesin.FinishBrew(); // BREWING -> STANDBY
        mesin.TampilkanState(); // Tampilkan state saat ini
        Console.WriteLine("");

        mesin.StartMaintenance(); // STANDBY -> MAINTENANCE
        mesin.TampilkanState(); // Tampilkan state saat ini
        Console.WriteLine("");

        mesin.FinishMaintenance(); // MAINTENANCE -> STANDBY
        mesin.TampilkanState(); // Tampilkan state saat ini
        Console.WriteLine("");

        mesin.PowerOff(); // STANDBY -> OFF
        mesin.TampilkanState(); // Tampilkan state saat ini
        Console.WriteLine("");

        // Simulasi perubahan state yang tidak valid
        mesin.FinishMaintenance(); // MAINTENANCE -> STANDBY (tidak valid karena mesin sedang OFF)
    }
}