// See https://aka.ms/new-console-template for more information

using PickRandomCards;

    Console.WriteLine("Welcome to the Card Picker Application");
    Console.WriteLine("Please Enter the number of cards you'd like to pick");
    string line = Console.ReadLine();
    int numberOfCards = int.Parse(line);

    CardPicker cardPicker = new CardPicker();

    string[] cards = cardPicker.pickSomeCards(numberOfCards);

    foreach(string card in cards)
    {
        Console.WriteLine(card);
    }




