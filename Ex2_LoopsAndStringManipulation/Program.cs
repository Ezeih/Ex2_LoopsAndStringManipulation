// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Välkommen till huvudmenyn!");
Console.WriteLine("1. Kolla om en person är ungdom eller pensionär");
Console.WriteLine("2. Upprepa en text tio gånger");
Console.WriteLine("3. Plocka ut det tredje ordet från en mening");
Console.WriteLine("0. Avsluta programmet");

while (true)
{
    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.WriteLine("Ange antal personer:");
        int numPersons = int.Parse(Console.ReadLine());
        int totalKostnad = 0;

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("Ange ålder för person " + (i + 1) + ":");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 20)
            {
                Console.WriteLine("Personen är en ungdom. Pris: 80 kr");
                totalKostnad += 80;
            }
            else if (ålder >= 65)
            {
                Console.WriteLine("Personen är en pensionär. Pris: 90 kr");
                totalKostnad += 90;
            }
            else
            {
                Console.WriteLine("Personen är inte en ungdom eller pensionär. Pris: 120 kr");
                totalKostnad += 120;
            }
        }

        Console.WriteLine("Totalt pris för " + numPersons + " personer är: " + totalKostnad + " kr");
    }

    else if (val == "2")
    {
        Console.Write("Ange en text att upprepa: ");
        string text = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i + 1}. {text}, ");
        }
        Console.WriteLine();
    }
    else if (val == "3")
    {
        Console.Write("Ange en mening med minst 3 ord: ");
        string mening = Console.ReadLine();

        string[] ord = mening.Split(' ');

        if (ord.Length >= 3)
        {
            string tredjeOrd = ord[2];
            Console.WriteLine($"Det tredje ordet är: {tredjeOrd}");
        }
        else
        {
            Console.WriteLine("Meningen måste innehålla minst 3 ord. Försök igen.");
        }
    }

    else if (val == "0")
    {
        Console.WriteLine("Programmet avslutas.");
        break;
    }
    else
    {
        Console.WriteLine("Felaktigt val. Försök igen.");
    }
}
