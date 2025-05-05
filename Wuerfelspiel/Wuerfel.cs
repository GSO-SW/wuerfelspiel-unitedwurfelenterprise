using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {  
            private Random random;
            private int seiten;

            public Wuerfel() : this(6)
            {
            }

            public Wuerfel(int seiten)
            {
                this.seiten = seiten;
                this.random = new Random();
            }
            public int Seiten => seiten;

            public int Werfen()
            {
                return random.Next(1, seiten + 1);
            }


            public int[] Werfen(int anzahl)
            {
                int[] ergebnisse = new int[anzahl];
                for (int i = 0; i < anzahl; i++)
                {
                    ergebnisse[i] = Werfen();
                }
                return ergebnisse;
            }

            public override string ToString()
            {
                return $"Würfel mit {seiten} Seiten";
            }
        
    }
}

