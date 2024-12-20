namespace Calculatrice
{
    static class Program
    {


        static void Main(string[] args)

        {


            Console.WriteLine("--- Calculatrice ---\n");


            {
                // Variables
                double entree_01; // Valeur de l'entrée utilisateur 
                double entree_02;
                double resultat;
                string operation; // Addition, soustractions, multiplications et divisions


                // Change la couleur du texte d'intro en gris foncé et laisse le texte de l'utilisateur en blanc
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Entrez votre première valeur : ");
                Console.ResetColor();
                entree_01 = Convert.ToDouble(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Entrez votre deuxième valeur : ");
                Console.ResetColor();
                entree_02 = Convert.ToDouble(Console.ReadLine());

                // Panel de proposition des différentes opérations
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nComment voulez-vous les calculer ? ");
                Console.ResetColor();
                Console.WriteLine("1 : Addition +");
                Console.WriteLine("2 : Sustraction -");
                Console.WriteLine("3 : Multiplication ×");
                Console.WriteLine("4 : Division ÷");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nVotre choix : ");
                Console.ResetColor();


                // Boucle while pour vérifier si l'entrée de l'utilisateur est valide
                while (true)
                {
                    operation = Console.ReadLine();
                    if (operation == "1" || operation == "2" || operation == "3" || operation == "4") // La console vérifie si l'entrée est bien égal à 1, 2, 3 ou 4

                        // Switch-case qui permet à l'utilisateur de choisir un symbole mathématique afin d'effectuer l'opération
                        switch (operation)
                        {

                            case ("1"):
                                resultat = entree_01 + entree_02; // Le résultat sera calculé en fonction des valeurs entrées par l'utilisateur
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"\nLe résultat de : ");
                                Console.ResetColor();
                                Console.Write($" {entree_01} + {entree_02} = {resultat}\n"); // Le calcul est effectué par la console. Dans ce cas là, il s'agit d'une addition donc on met +

                                // ASCII Calculatrice
                                Console.WriteLine("\t\t |--------------|");
                                Console.WriteLine("\t\t | 7 " + " 8 " + " 9 " + " | ÷ |");
                                Console.WriteLine("\t\t | 4 " + " 5 " + " 6 " + " | × |");
                                Console.WriteLine("\t\t | 1 " + " 2 " + " 3 " + " | - |");
                                Console.WriteLine("\t\t | 0 " + " . " + " = " + " | + |");

                                break;

                            case ("2"):
                                resultat = entree_01 - entree_02;

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"\nLe résultat de : ");
                                Console.ResetColor();
                                Console.Write($" {entree_01} - {entree_02} = {resultat}  \n");

                                // ASCII Calculatrice
                                Console.WriteLine("\t\t |--------------|");
                                Console.WriteLine("\t\t | 7 " + " 8 " + " 9 " + " | ÷ |");
                                Console.WriteLine("\t\t | 4 " + " 5 " + " 6 " + " | × |");
                                Console.WriteLine("\t\t | 1 " + " 2 " + " 3 " + " | - |");
                                Console.WriteLine("\t\t | 0 " + " . " + " = " + " | + |");

                                break;

                            case ("3"):
                                resultat = entree_01 * entree_02;

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"\nLe résultat de : ");
                                Console.ResetColor();
                                Console.Write($" {entree_01} * {entree_02} = {resultat}  \n");

                                // ASCII Calculatrice
                                Console.WriteLine("\t\t |--------------|");
                                Console.WriteLine("\t\t | 7 " + " 8 " + " 9 " + " | ÷ |");
                                Console.WriteLine("\t\t | 4 " + " 5 " + " 6 " + " | × |");
                                Console.WriteLine("\t\t | 1 " + " 2 " + " 3 " + " | - |");
                                Console.WriteLine("\t\t | 0 " + " . " + " = " + " | + |");

                                break;

                            case ("4"):
                                resultat = entree_01 / entree_02;

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("\nLe résultat de : ");
                                Console.ResetColor();
                                Console.Write($" {entree_01} / {entree_02} = {resultat}  \n");

                                // ASCII Calculatrice
                                Console.WriteLine("\t\t |--------------|");
                                Console.WriteLine("\t\t | 7 " + " 8 " + " 9 " + " | ÷ |");
                                Console.WriteLine("\t\t | 4 " + " 5 " + " 6 " + " | × |");
                                Console.WriteLine("\t\t | 1 " + " 2 " + " 3 " + " | - |");
                                Console.WriteLine("\t\t | 0 " + " . " + " = " + " | + |");

                                break;
                        }

                    else // Si les conditions d'entrer 1, 2, 3 ou 4 ne sont pas respectés, la console affichera une erreur
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("/!\\ Commande non valide. Veuillez entrer : 1, 2, 3 ou 4 selon votre choix mathématique.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\nVotre choix : ");
                        Console.ResetColor();
                    }


                }





            }

        }

    }
}

