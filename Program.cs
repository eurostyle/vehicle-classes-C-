using System;
using System.Collections.Generic;

namespace NamuDarbasAutomobiliai
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Create 3 different vehicle classes and 5 objects per each class.
            field requarements: Brand, reg-number, displacement, price, max-speed, year.
            goal: find the cheapest of each category
            */

            
            ///list of heavy-duty vehicles.
            List<SunkiejiAutomobiliai> furos = new List<SunkiejiAutomobiliai>();
            furos.Add(new SunkiejiAutomobiliai("Kamaz", "BBD-688", 3000, 5000, 90, 1972));
            furos.Add(new SunkiejiAutomobiliai("Volvo", "CBL-465", 6000, 60000, 120, 2002));
            furos.Add(new SunkiejiAutomobiliai("Mercedes", "TTD-688", 6000, 80000, 120, 2010));
            furos.Add(new SunkiejiAutomobiliai("DAF", "TFU-798", 3500, 50000, 110, 2005));
            furos.Add(new SunkiejiAutomobiliai("DAF", "TFU-798", 3500, 50000, 110, 2005));
            furos.Add(new SunkiejiAutomobiliai("MAN", "HHU-688", 3000, 45000, 100, 1999));

            ///setting a variable to first index possition of a list for referance starting point of price comparing.
            SunkiejiAutomobiliai pigiausiaSunkvezimis = furos[0];

            ///foreach loop to unpack and compare cheapest vehicle on a given list.
            foreach (var pigiausias in furos)
            {
                if (pigiausias.Kaina < pigiausiaSunkvezimis.Kaina)
                {
                    pigiausiaSunkvezimis = pigiausias;
                }
            }
            Console.WriteLine(pigiausiaSunkvezimis.ToPrint());

            ///repeat process from here on.
            List<Motociklai> motociklai = new List<Motociklai>();
            motociklai.Add(new Motociklai("Honda", "POL-666", 1000, 8000, 300, 2011));
            motociklai.Add(new Motociklai("Ducatti", "LTU-666", 1300, 30000, 320, 2017));
            motociklai.Add(new Motociklai("Kawasaki", "TRS-333", 600, 4000, 260, 2005));
            motociklai.Add(new Motociklai("Suzuki", "FTS-466", 900, 8000, 300, 2011));
            motociklai.Add(new Motociklai("Jawa", "PKL-226", 250, 150, 160, 1982));

            Motociklai pigiausiasMotociklas = motociklai[0];

            foreach (var pigiausias in motociklai)
            {
                if (pigiausias.Kaina < pigiausiasMotociklas.Kaina)
                {
                    pigiausiasMotociklas = pigiausias;
                }
            }
            Console.WriteLine(pigiausiasMotociklas.ToPrint());

            List<LengviejiAutomobiliai> lengviAuto = new List<LengviejiAutomobiliai>();
            lengviAuto.Add(new LengviejiAutomobiliai("Zigulys", "DDS-587", 1100, 400, 160, 1979));
            lengviAuto.Add(new LengviejiAutomobiliai("Volga", "JKL-487", 1300, 800, 120, 1967));
            lengviAuto.Add(new LengviejiAutomobiliai("Ford", "RYT-584", 1300, 400, 220, 1988));
            lengviAuto.Add(new LengviejiAutomobiliai("Opel", "REU-024", 2000, 1500, 240, 1999));
            lengviAuto.Add(new LengviejiAutomobiliai("Audi", "FZL-015", 3000, 6000, 260, 2006));

            LengviejiAutomobiliai pigiausiasAutomobilis = lengviAuto[0];

            foreach (var pigiausias in lengviAuto)
            {
                if (pigiausias.Kaina < pigiausiasAutomobilis.Kaina)
                {
                    pigiausiasAutomobilis = pigiausias;
                }
            }
            Console.WriteLine(pigiausiasAutomobilis.ToPrint());

        }
    }
}
