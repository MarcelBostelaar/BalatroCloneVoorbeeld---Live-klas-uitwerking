// See https://aka.ms/new-console-template for more information
using KlasUitwerking;

namespace KlasUitwerking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Zonder enter");
            Console.Write("Zonder enter");

            Console.Clear();

            string antwoord = Console.ReadLine();

            Console.WriteLine("Antwoord: " + antwoord);

            Card test = new Card(CardValue.Three, Suit.Hearts);

            ////Dit is een harte 2
            //Card hint = new Card((CardValue)2, Suit.Hearts);

            Deck testdeck = new Deck();
        }
    }
}

