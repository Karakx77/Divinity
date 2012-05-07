using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public static class Dado
    {
        public static int D6(Random gen)
        { return gen.Next(1, 6); }
        public static int D4(Random gen)
        { return gen.Next(1, 4); }
        public static int D8(Random gen)
        { return gen.Next(1, 8); }
        public static int D10(Random gen)
        { return gen.Next(1, 10); }
        public static int D12(Random gen)
        { return gen.Next(1, 12); }
        public static int D20(Random gen)
        { return gen.Next(1, 20); }
        public static int D100(Random gen)
        { return gen.Next(0, 100); }

        public static int caratteristica4Dadi(Random gen)
        {
            int[] dadi = new int[4];
            int somma = 0, minimo = 20, indiceMinimo = 0;

            dadi[0] = D6(gen);
            dadi[1] = D6(gen);
            dadi[2] = D6(gen);
            dadi[3] = D6(gen);

            for (int i = 0; i < 4; i++)
            {
                if (dadi[i] < minimo)
                {
                    minimo = dadi[i];
                    indiceMinimo = i;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (i != indiceMinimo)
                    somma += dadi[i];
            }

            return somma;


        }
    }

    public static class Libreria
    {
        public enum Caratterisiche
        {
            FOR,
            DES,
            COS,
            INT,
            SAG,
            CAR
        };

        

   }
}
