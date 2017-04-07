using System;

namespace TesteBuscas
{
	public class Sort
	{
		public static void Teste()
		{
			int[] array = new int[] { 1, 2, 5, 4, -1, -2, 3 };
			PrintArray( array );
			BubbleSort( array );
			PrintArray( array );
		}

		public static void PrintArray( int[] array )
		{
			foreach( int e in array )
			{
				Console.Write( e );
				Console.Write( ", " );
			}

			Console.WriteLine();
		}

		public static void BubbleSort( int[] array )
		{
			for(int i = 0; i< array.Length; i++ )
			{
				for( int j = 0; j < array.Length - 1; j++ )
				{
					int elementoEsquerda = array[j];
					int elementoDireita = array[j + 1];

					if( elementoDireita < elementoEsquerda )
					{
						array[j] = elementoDireita;
						array[j + 1] = elementoEsquerda;
					}
				}
			}
		}
	}
}
