
using System;

class Rikiavimas
{
	int [] masyvas;
	
	public Rikiavimas(int[] masyvas)
	{
		this.masyvas = masyvas;
	}
	
	public int[] RikiuokD()
	{
		int[] result = masyvas;
		
		Array.Sort(result);
		
		return result;
	}
	
	public int[] RikiuokM()
	{
		int[] result = masyvas;
		
		Array.Sort(result);
		Array.Reverse(result);
		
		return result;
	}
}
