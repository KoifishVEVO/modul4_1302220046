// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();

        Console.WriteLine("Kode Alpukat adalah " + kodeBuah.getKodeBuah(KodeBuah.NamaBuah.Alpukat));
        Console.WriteLine("Kode Durian adalah " + kodeBuah.getKodeBuah(KodeBuah.NamaBuah.Durian));
        Console.WriteLine("Kode Apel adalah " + kodeBuah.getKodeBuah(KodeBuah.NamaBuah.Apel));

    }
}