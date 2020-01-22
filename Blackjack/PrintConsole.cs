using System;
using System.Linq;

namespace Blackjack
{
    public static class PrintConsole
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the hame BlackJack");
        }

        public static void WantToPlay()
        {
            Console.WriteLine("Do you want to play? (yes/no)");
        }

        public static void WantToPlayOneMoreTime()
        {
            Console.WriteLine("Do you want to play one more time? (yes/no)");
        }

        public static void YouWon()
        {
            Console.WriteLine("You won!\n");
        }

        public static void YouLose()
        {
            Console.WriteLine("You lose!\n");
        }

        public static void IncorrectAnswer()
        {
            Console.WriteLine("Incorrect Answer! Try Again");
        }

        public static void PrintScore(Player player, Player pc)
        {
            Console.WriteLine("\nplayer: ");
            Console.WriteLine(String.Format("Cards: {0}", GameLogic.GetCards(player)));
            Console.WriteLine(String.Format("Points: {0}", player.cards.Sum(x => x.Points)));
            Console.WriteLine("\nDealer: ");
            Console.WriteLine("Cards: {0}", GameLogic.GetCards(pc));
            Console.WriteLine(String.Format("Points: {0}\n", pc.cards.Sum(x => x.Points)));
        }        
    }
}
