using System;

class MasyvasIO
{
	public int PildykIlgi()
	{
		int result = 0;
		
		Console.Write("Iveskite masyvo ilgi: ");
		
		while (true)
		{
			string input = Console.ReadLine();
			
			try {
				result = Convert.ToInt32(input);
				
				if (result < 1) {
					throw new System.ArgumentException();
				}
				
				break;
			}
			catch {
				Console.Write("Prasome ivesti teigiama skaiciu: ");
			}
		}
		
		return result;
	}
	
	public int[] PildykMasyva(int ilgis)
	{
		int[] result = new int[ilgis];
		
		Console.WriteLine("Iveskite masyvo ["+ilgis+"] elementus");
		
		for (int i = 0; i < ilgis; i++)
		{
			while (true)
			{
				Console.Write(i+1 +". ");
				string input = Console.ReadLine();
				
				try {
					result[i] = Convert.ToInt32(input);
					break;
				}
				catch {
					Console.WriteLine("Prasome ivesti teigiama skaiciu");
				}
			}
		}
		
		return result;
	}
	
	public void SpausdinkMasyva(int[] masyvas)
	{
		
		Console.Write("Masyvas["+masyvas.Length+"]: ");
		
		for (int i = 0; i < masyvas.Length; i++)
		{
			Console.Write(masyvas[i]);
			
			if(masyvas.Length > i+1) {
				Console.Write(", ");
			}
		}
		
		Console.WriteLine("");
	}
}