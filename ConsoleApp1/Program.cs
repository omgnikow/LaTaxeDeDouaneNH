using System;
using System.Globalization;

namespace LaTaxeDeSouane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saisie du prix de base
            Console.Write("Entrez le prix de base de l'arme (en pièces d'or) : ");
            decimal prix = decimal.Parse(Console.ReadLine());
    
            // Choix de la zone
            Console.WriteLine("Choisissez la zone de provenance de la forge pour déterminer la taxe :");
            Console.WriteLine("1 - Forges de la Capitale (Taxe royale standard : 20%)");
            Console.WriteLine("2 - Ateliers des Nains des Montagnes (Taxe minière intermédiaire : 10%)");
            Console.WriteLine("3 - Port des Contrebandiers (Taxe réduite d'importation : 5,5%)");
            Console.WriteLine("4 - Terres Sacrées du Temple (Taxe d'artisanat béni : 2,1%)");
            Console.Write("Entrez votre choix (1-4) : ");

            char choixInput = char.Parse(Console.ReadLine());
 
            switch (choixInput)
            {
                case '1':
                    prix = prix * 1.20m; // Taxe royale standard : 20%
                    break;
                case '2':
                    prix = prix * 1.10m; // Taxe minière intermédiaire : 10%
                    break;
                case '3':
                    prix = prix * 1.055m; // Taxe réduite d'importation : 5,5%
                    break;
                case '4':
                    prix = prix * 1.021m; // Taxe d'artisanat béni : 2,1%
                    break;
                default:
                    Console.WriteLine("Choix invalide. Aucune taxe appliquée.");
                    break;
            }

            Console.WriteLine($"Le prix final de l'arme après application de la taxe est : {prix}");

        }
    }
}

