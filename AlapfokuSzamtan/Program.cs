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
            /* sztringValtozoNeve.ElementAt(<hanyadik karaktert szeretnéd>);
             * Az adott indexen szereplő karaktert adja vissza.
             * FONTOS: A stringek indexe 0-ról indul!
             */

            #region
            Console.WriteLine("Hello, a nevem Alapfokú Számtan!");
            Console.ReadLine();
            Console.WriteLine("Add meg az első számot!");
            double elsoSzam = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második számot!");
            double masodikSzam = double.Parse(Console.ReadLine());
            Console.WriteLine("Válaszd meg az elvégzendő műveletet! (+, -, *, /)");
            string muveletiJel = Console.ReadLine();
            if (muveletiJel.ElementAt(0) == '+')
            {
                // ez akkor fut le, ha a megadott műveleti jel a '+'
                Console.WriteLine(elsoSzam + masodikSzam);
            }
            if (muveletiJel.ElementAt(0) == '-')
            {
                Console.WriteLine(elsoSzam - masodikSzam);
            }
            if (muveletiJel.ElementAt(0) == '*')
            {
                Console.WriteLine(elsoSzam * masodikSzam);
            }
            if (muveletiJel.ElementAt(0) == '/')
            {
                Console.WriteLine(elsoSzam / masodikSzam);
            }
            Console.ReadLine();
            #endregion

            /* = : értékadás:           int valtozo = 2; (a valtozo legyen egyenlő kettővel)
             * == : összehasonlítás:    valtozo1 == valtozo2 (valtozo1 egyenlő -e valtozo2-vel => vagy IGEN, vagy NEM (if))
             * 
             * "If" minta (feltételes elágazás)
             * 
             * Ha az feltétel értéke igaz, akkor a küvetkező blokkban levő utasításokat hajtja végre.
             * Ha hamis, akkor a különben (else) blokkra ugrik.
             * Ilyen az if blokk utasításai nem hajtódnak végre.
             * Mert a feltétel vagy IGAZ VAGY HAMIS (true or false)!
             * 
             * <code>
             * if (feltétel)
             * {
             *     utasítás1;
             *     utasítás2;
             * }
             * else
             * {
             *      utasítás3;
             *      utasítás4;
             * }
             * </code>
             */

        }
    }
}
