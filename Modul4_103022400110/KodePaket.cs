using System;
using System.Collections.Generic;
using System.Text;

public class KodePaket
{
    // Dictionary untuk menyimpan nama paket dan kode paket
    private Dictionary<string, string> kodePaket = new Dictionary<string, string>()
    {
        { "Basic", "P201" },
        { "Standard", "P202" },
        { "Premium", "P203" },
        { "Unlimited", "P204" },
        { "Gaming", "P205" },
        { "Streaming", "P206" },
        { "Family", "P207" },
        { "Business", "P208" },
        { "Student", "P209" },
        { "Traveler", "P210" },
    };

    // Method return kode paket berdasarkan nama paket
    public string getKodePaket(string namaPaket)
    {
        return kodePaket[namaPaket];
    }
}
