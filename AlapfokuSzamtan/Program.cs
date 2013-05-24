using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlapfokuSzamtan
{
    class Program
    {
        static void Main(string[] args)
        {
        #region
        Console.WriteLine("Hello, a nevem Alapfokú Számtan!");
        Console.ReadLine();
        Console.WriteLine("Add meg az első számot!");
        int elsoSzam = int.Parse(Console.ReadLine());
        Console.WriteLine("Add meg a második számot!");
        int masodikSzam = int.Parse(Console.ReadLine());
        Console.WriteLine("Válaszd meg az elvégzendő műveletet! (+, -, *, /)");
        string muveletiJel = Console.ReadLine();
        
        /* sztringValtozoNeve.ElementAt(<hanyadik karaktert szeretnéd>);
         * Az adott indexen szereplő karaktert adja vissza.
         * 
         * FONTOS: A stringek indexe 0-ról indul!
         */

        Console.WriteLine(muveletiJel.ElementAt(0));

        Console.ReadLine();
        #endregion
        }
    }
}
