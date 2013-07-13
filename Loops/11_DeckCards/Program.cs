using System;
using System.Collections.Generic;

class DeckCards
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.");

        List<string> deck = new List<string>();
        string[] suits = new string[4] {"Spades", "Hearts", "Diamonds", "Clubs"};

        // Main logic
        foreach (string suit in suits)
        {
            for (int card = 2; card <= 13; card++)
            {   
                switch (card)
                {
                case 11: deck.Add("Jack of " + suit);;
                    break;
                case 12: deck.Add("Queen of " + suit);;
                    break;
                case 13: deck.Add("King of " + suit);;
                    break;
                case 14: deck.Add("Ace of " + suit);;
                    break;
                default: deck.Add(card + " of " + suit);
                    break;
                }
            }
        }

        // Consol output
        Console.WriteLine(string.Join(", ", deck));
    }
}