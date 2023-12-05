using System;
					
public class Program
{
	public static void Main()
	{
		int karte=0;
		int cardCounter=0;
		while(cardCounter < 31){
		Console.Write("Upiši vrijednost karte:");
			try{
		karte=Convert.ToInt32(Console.ReadLine());
		if(karte>13 || karte <1){
				Console.WriteLine("Pogrešan unos!");
			continue;
	} 
		else{
			cardCounter+= karte;
		}
			}
			catch(Exception ex){
				Console.WriteLine(ex.Message);
			}
		}
	if(cardCounter==31){
		Console.WriteLine("Bodovi:"+cardCounter);
        Console.WriteLine("Pobjedili ste!");
	   }
		else{
			Console.WriteLine("Bodovi:"+cardCounter);
			Console.WriteLine("Izgubli ste!");
		}
	}
}