using System;



	public class KodeBuah()
	{
		
	public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka};
	public string getKodeBuah(NamaBuah namabuah)
	{
		string[] KodeBuah = {"A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

		int index = (int)namabuah;
		return KodeBuah[index];
	}

	}

