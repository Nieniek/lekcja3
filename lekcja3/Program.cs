// Proste aplikacja wykonowujące psedolosowanie rzuty wybraną kością 

Char Choice;

Random rng = new Random();

do
{
    Console.WriteLine("Jaką kością chcesz rzucić: ");
    Console.WriteLine("1. k3");
    Console.WriteLine("2. k4");
    Console.WriteLine("3. k6");
    Console.WriteLine("4. k100");
    Console.WriteLine("0. Wyjście");

    Choice = Console.ReadKey(true).KeyChar;

    switch (Choice)
    {
        case '1':
            //jeśli podano 1
            Console.WriteLine("wynik rzutu k3: " + rng.Next(1, 3));
            break;
        case '2':
            //jeśli podano 2
            Console.WriteLine("wynik rzutu k3: " + rng.Next(1, 4));
            break;
        case '3':
            //jeśli podano 3
            Console.WriteLine("wynik rzutu k3: " + rng.Next(1, 6));
            break;
        case '4':
            //jeśli podano 4
            Console.WriteLine("wynik rzutu k3: " + rng.Next(1, 100));
            break;
        case '0':
            //jeśli wyjść
            Console.WriteLine("Do zobaczenia");
            break;
        default:
            //wykona się jesli żaden wczesniejszy nie pasuje 
            Console.WriteLine("podano nieprawidłową opcje!");
            break;

    }


}
while (Choice != '0');

