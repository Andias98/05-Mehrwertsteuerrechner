/*--------------------------------------------------------------
 *      HTBLA-Leonding / Class 3ACIFT
 *--------------------------------------------------------------
 *      Mathias Anderl
 *--------------------------------------------------------------
 * Description: Programm errechnet die Höhe der 
 *				Mehrwertsteuer (10 % und 5 %
 *--------------------------------------------------------------
 */
 
using System;

namespace Mehrwertsteuerrechner
{
    class Program
    {
        public static void Main()
        {
            double price, nettoPrice, taxNow, tax5, futurePrice, savings;

            // Ausgabe (Header/Überschrift)
            Console.WriteLine("Steuerrechner auf Grundnahrungsmittel");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            // Eingabe (E)
            Console.WriteLine("Aktueller Verkaufspreis: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            // Verarbeitung (V) --> 10 % Steuer
            nettoPrice = (price / 110) * 100;   // Errechnet Nettopreis mit 10 % Mwst.
            taxNow = price - nettoPrice;        // Errechnet Betrag der Mwst. auf gegebenen Preis

            // Ausgabe (A) --> 10 % Steuer	
            Console.Write("Nettopreis: ");
            Console.WriteLine($"{nettoPrice,32:N}");

            Console.Write("Derzeitige Mehrwertsteuer: ");
            Console.WriteLine($"{taxNow,17:N}");
            Console.WriteLine();

            // Ausgabe (A) --> 5 % Steuer
            Console.Write("Werte bei 5 % Steuer");
            Console.WriteLine("--------------------");

            // Verarbeitung (V) --> 5 % Steuer
            futurePrice = (price / 105) * 100;  // Errechnet den Nettopreis  mit 5 % Mwst

            tax5 = price - futurePrice;         // Errechnet die Mwst.

            savings = taxNow - tax5;            // Errechnet die Ersparnisse

            // Ausgabe (A) --> 5 % Steuer
            Console.Write("Mehrwertsteuer: "); 
            Console.WriteLine($"{tax5,28:N}");
            Console.Write("Zukünftiger Verkaufspreis: ");
            Console.WriteLine($"{futurePrice,17:N}");

            Console.Write("Ersparnis: ");
            Console.WriteLine($"{savings,33:N}");
            Console.WriteLine();

            // Ausgabe (A) --> Ende

            Console.WriteLine("Zum Beenden Eingabetaste drücken  ...");
            Console.ReadKey();

        }
    }
}