using System;

public class Player
{
	public string name;
	public Player next = null;
	public Player previous = null;

	public Player( string name )
	{
		this.name = name;
	}

	public void Remove()
	{
		if( next != null )
		{
			next.previous = previous;
		}
		if(previous != null)
		{
			previous.next = next;
		}
	}
}

namespace ListaEncadeada
{
	internal class Program
	{
		private static void Main( string[] args )
		{
			Player player1 = new Player( "John" );
			Player player2 = new Player( "Paul" );
			Player player3 = new Player( "George" );
			Player player4 = new Player( "Ringo" );

			player1.next = player2;
			player2.next = player3;
			player3.next = player4;

			player4.previous = player3;
			player3.previous = player2;
			player2.previous = player1;

			player3.Remove();
			// Iterando na lista
			Player currentElement = player4;
			while( currentElement != null )
			{
				Console.WriteLine( "Passei por um Player de nome {0}",
					currentElement.name );
				currentElement = currentElement.previous;
			}

			Console.WriteLine( "Acabou a lista" );
		}
	}
}
