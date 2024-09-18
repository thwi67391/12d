using System.Security.Cryptography.X509Certificates;

namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string value;
            do
            {

                int resultat;
                

                Console.WriteLine("Indtast det første nummer");
                int nr1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast det andet nummer");
                int nr2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast et symbol");
                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "+":

                        resultat = nr1 + nr2;
                        Console.WriteLine("resultat af addition er " + resultat);
                        break;

                    case "-":

                         resultat = nr1 - nr2;
                        Console.WriteLine("resultat af subtraktion er " + resultat);
                        break;

                    case "/":

                        resultat = (nr1 / nr2);
                        double division = (double)resultat;
                        Console.WriteLine("resultat af division er " + division + "med en rest på");

                        break;

                    case "*":

                        resultat = nr1 * nr2;
                        Console.WriteLine("resultat af multiplikation " + resultat);
                        break;

                    default:
                        Console.WriteLine("Om igen, forkert input");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Fortsæt herfra?");
                value = Console.ReadLine();

            }
            while (value == "y" || value == "Y");


                











                












            



            }






        }
    }

