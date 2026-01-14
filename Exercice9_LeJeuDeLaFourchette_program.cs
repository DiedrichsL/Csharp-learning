Random rng = new Random();
int nombreAleatoire = rng.Next(1, 101);
int nombrechoisis = 0;
bool continuer = true;
string choix = "";



do
{
    Console.WriteLine("Devinez le nombre entre 1 et 100");
    nombrechoisis = int.Parse(Console.ReadLine());


    if (nombrechoisis < nombreAleatoire)
    {
        Console.WriteLine("Le nombre est plus grand");
    }

    else if (nombrechoisis > nombreAleatoire)
    {
        Console.WriteLine("Le nombre est plus petit");
    }

    else
    {
        Console.WriteLine("Victoire !!!");
    }



} while (nombreAleatoire != nombrechoisis);
