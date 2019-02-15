using System;

namespace NamuDarbai1
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			// Masyvo sukurimas
			MasyvasIO ArrayIO 		= new MasyvasIO();
			
			int ilgis     = ArrayIO.PildykIlgi();
			int[] masyvas = ArrayIO.PildykMasyva(ilgis);
			
			ArrayIO.SpausdinkMasyva(masyvas);
			
			
			// Masyvo apdorojimas
			Apdorok ArrayHelper 	= new Apdorok(masyvas);
			
			if(ArrayHelper.teigiamiNelyginiai.Length > 0) {
				Console.WriteLine("");
				Console.WriteLine("Teigiami nelyginiai elementai");
				ArrayIO.SpausdinkMasyva(ArrayHelper.teigiamiNelyginiai);
				
				Console.WriteLine("Suma: " +ArrayHelper.getSum());
				Console.WriteLine("Vidurkis: " +ArrayHelper.getAvg().ToString("n2"));
			} else {
				Console.WriteLine("");
				Console.WriteLine("Teigiamu nelyginiu elementu nerasta");
			}
			
			
			// Masyvo rusiavimas
			Rikiavimas SortHelper 	= new Rikiavimas(ArrayHelper.masyvasApdorotas);
			
			Console.WriteLine("");
			Console.WriteLine("Originalus masyvas: ");
			ArrayIO.SpausdinkMasyva(ArrayHelper.masyvasApdorotas);
			
			Console.WriteLine("Mazejimo tvarka");
			ArrayIO.SpausdinkMasyva(SortHelper.RikiuokM());
			
			Console.WriteLine("Didejimo tvarka");
			ArrayIO.SpausdinkMasyva(SortHelper.RikiuokD());
			
			Console.ReadKey(true);
		}
	}
}