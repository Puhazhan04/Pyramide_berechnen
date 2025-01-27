
using System;

class Program
{
    public static void Main()
    {
        var password = "123";
        Console.WriteLine("Bitte geben Sie das password ein:");
        var eingabe = Console.ReadLine();

        for (int versuch = 1; versuch <= 3; versuch++)
        {
            if (eingabe == password)
            {
                Console.WriteLine("Richtige Password.");
                run();
                break;
            }
            else
            {
                if (versuch < 3)
                {
                    Console.WriteLine($"Falsche Password. Sie haben noch {3 - versuch} Versuch(e),");
                    eingabe = Console.ReadLine();
                }
            }
        }

    }

    static void run()
    {
        bool end = false;
        while (!end)
        {
            Console.WriteLine("Herzlich willkommen zum Programm.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Bitte wählen Sie die Option");
            Console.WriteLine("Optionen 1: Mantalflächeberechnen, 2: Grundflächeberechnen, 3: Oberflächeberechnen, 4: Volumen, 5: Programm beenden");
            var Option = Console.ReadLine();

            switch (Option)
            {
                case "1":
                    Methode1();
                    Console.WriteLine("-----------------------------------");
                    break;

                case "2":
                    Methode2();
                    Console.WriteLine("-----------------------------------");
                    break;

                case "3":
                    Methode3();
                    Console.WriteLine("-----------------------------------");
                    break;

                case "4":
                    Methode3();
                    Console.WriteLine("-----------------------------------");
                    break;

                case "5":
                    end = true;
                    Console.WriteLine("Das Programm ist jetzt beendet.");
                    Console.ReadLine();
                    break;

            }
        }
    }


    static double Methode1()
    {
        Console.Write("Bitte geben Sie die Seite a:");
        var a = double.Parse(Console.ReadLine());

        Console.Write("Bitte geben Sie die Seite ha:");
        var ha = double.Parse(Console.ReadLine());

        double mantalfläche = (2 * a * ha);
        Console.WriteLine("Der Mantalfläche ist: " + mantalfläche);
        return mantalfläche;
    }

    static double Methode2()
    {
        Console.Write("Bitte geben Sie die Seite a: ");
        var a = double.Parse(Console.ReadLine());

        double grundflächeberechnen = a * a;
        Console.WriteLine($"Der Grundfläche ist: " + grundflächeberechnen);
        return grundflächeberechnen;
    }

    static double Methode3()
    {
        var mantalfläche = Methode1();
        var grundflächeberechnen = Methode2();

        double Oberflächeberechnen = mantalfläche + grundflächeberechnen;
        Console.WriteLine($"Der Oberfläche ist: " + Oberflächeberechnen);
        return Oberflächeberechnen;
    }

    static double Methode4()
    {
        var grundflächeberechnen = Methode2();
        Console.Write("Bitte geben Sie Seite h ein: ");
        var h = double.Parse(Console.ReadLine());

        double volumen = 1 / 3 * (grundflächeberechnen * h);
        Console.WriteLine($"Der Volumen ist: " + volumen);
        return volumen;

    }

    static void exit()
    {
    }


}



