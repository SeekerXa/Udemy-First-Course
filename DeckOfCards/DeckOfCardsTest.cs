using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class DeckOfCardsTest
    {
        static void Main(string[] args)
        {
            var myDeckOfCards = new DeckOfCards();

            for (int i = 0; i < 52; i++)
            {
                Console.Write($"{myDeckOfCards.DealCard(),-19}");
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }

            myDeckOfCards.Shuffle();
            Console.Write("Suffling\n");

            for (int i = 0; i < 52; i++)
            {
                Console.Write($"{myDeckOfCards.DealCard(),-19}");
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
                                                                    

            Console.WriteLine(0 % 13);


        }
    }
}
