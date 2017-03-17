
using System;

namespace TesteBuscas
{
	class Buscas
	{
		public static void TesteBuscaLinear()
		{
			int[] valores = new int[] { 1, 2, 6, 8, 9, 13, 14, 15 };
			int alvo = 13;
			int indice = -1;

			int nIteracoes = 0;

			for( int i = 0; i < valores.Length; i++ )
			{
				nIteracoes++;

				if( valores[i] == alvo )
				{
					indice = i;
					break;
				}
			}

			if( indice >= 0 )
				Console.WriteLine( "Nao achei o valor" );
			else
				Console.WriteLine( "Achei o valor {0} na posicao {1} em {2} iteracoes", valores[indice], indice, nIteracoes );
		}

		public static void TesteBuscaBinaria()
		{
			int[] valores = new int[] { 1, 2, 6, 8, 9, 13, 14, 15 };
			int alvo = 13;
			int indice = -1;

			int maxIndice = valores.Length - 1;
			int minIndice = 0;
			int nIteracoes = 0;

			do {
				nIteracoes++;

				indice = ( minIndice + maxIndice ) / 2;

				if( valores[indice] == alvo )
					break;
				else if( valores[indice] < alvo )
					minIndice = indice;
				else if( valores[indice] > alvo )
					maxIndice = indice;

			} while( minIndice != maxIndice );

			if( minIndice == maxIndice )
				Console.WriteLine( "Nao achei o valor" );
			else
				Console.WriteLine( "Achei o valor {0} na posicao {1} em {2} iteracoes", valores[indice], indice, nIteracoes );
		}
	}
}
