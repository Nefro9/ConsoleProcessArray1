using System;

class Apdorok
{
	int [] masyvas;
	public int [] teigiamiNelyginiai;
	public int [] masyvasApdorotas;

	
	public Apdorok(int[] orgMasyvas)
	{
		this.masyvas = orgMasyvas;
		this.ApdorokMasyva();
	}
	
	private void ApdorokMasyva()
	{
		teigiamiNelyginiai	= new int[masyvas.Length];
		masyvasApdorotas	= new int[masyvas.Length];
		
		int counterA = 0;
		int counterB = 0;
		
		for (int i = 0; i < masyvas.Length; i++)
		{
			if(masyvas[i] >= 0 && masyvas[i] % 2 != 0) {
				teigiamiNelyginiai[counterA] = masyvas[i];
				counterA++;
			} else {
				masyvasApdorotas[counterB] = masyvas[i];
				counterB++;
			}
		}
		
		// Resize array
		Array .Resize<int >(ref teigiamiNelyginiai, counterA);
		Array .Resize<int >(ref masyvasApdorotas, counterB);
	}
	
	public int getSum()
	{
		int sum = 0;
		
		for (int i = 0; i < teigiamiNelyginiai.Length; i++)
		{
			sum += teigiamiNelyginiai[i];
		}
		
		return sum;
	}
	
	public float getAvg()
	{
		float  avg = 0;
		
		if(teigiamiNelyginiai.Length > 0) {
			avg = (float) this.getSum() / teigiamiNelyginiai.Length;
		}
		
		return avg;
	}
}