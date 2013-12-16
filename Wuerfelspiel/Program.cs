using System;

namespace Wuerfelspiel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int wuerfel = int.Parse (Console.ReadLine ());
			Console.WriteLine (wuerfel);
			int wuerfe = int.Parse (Console.ReadLine ());
			Console.WriteLine (wuerfe);
		
			int[,] liste = Berechnung (wuerfel, wuerfe);
			for (int i = 0; i < liste.Length / 2; i++) {
				Console.WriteLine (liste [i, 0]+ "+"  +liste [i, 1]);
			}

		}
	
		static int [,] Berechnung(int wuerfel, int wuerfe)
		{
			int y = 0;
			int[,] ergbnis = new int[(wuerfel*6-wuerfel)+1,2];

			for (int i = wuerfel, j = 0; i < wuerfel * 6 + 1; i++,j++) {
				ergbnis [j, 0] = i;
				ergbnis [j, 1] = 0;
			
			}
			Random objektname = new Random (); 
			for (int u = 1; u <= wuerfe; u++) {
			
				for (int i = 1; i <= wuerfel; i++) {

					int x = objektname.Next (1, 7);
					y = y + x;


				}
				for (int k = 0; k < ergbnis.Length / 2; k++) {
					if (y == ergbnis [k, 0])
						ergbnis [k, 1] += 1;
				} 

					y = 0;
				}
				

			return ergbnis;
		}
		}
	}


