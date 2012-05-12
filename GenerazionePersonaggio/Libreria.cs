using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public static class Libreria
    {
        public static string pathFileAbilita = @"C:\TestFolder\abilita.txt";
        public enum Caratterisiche
        {
            FOR,
            DES,
            COS,
            INT,
            SAG,
            CAR
        };
        public static int calcolaEsp(int liv)
        {
            int val=0;
            if (liv <= 1)
                return 0;
            else
                val = calcolaEsp(liv - 1) + (liv-1);
            return val;
        }
        public static int attaccoBuono(int lv)
        { return lv; }
        public static int attaccoMedio(int lv)
        { 
            double diff;
            
            diff = lv / 4.0;
            diff = Math.Ceiling(diff);
            return (int)(lv - diff);        
        }
        public static int attaccoScarso(int lv)
        {
            return lv / 2;
        }

        public static string listaAttacchi(int attacco)
        {
            string attaccoStr = attacco.ToString();
            if ((attacco - 5) > 0)
                attaccoStr += "/"+listaAttacchi(attacco - 5);
            else
                return attacco.ToString();
            return attaccoStr;
        
        }

    }    
    
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
    
    public class GestioneBonus
    {
        public Dictionary<string, int> diz;
        public GestioneBonus()
        {
            diz = new Dictionary<string, int>();
        }

        public void add(string label, int value)
        { diz[label] = value; }
        public int get(string label)
        {
            if (diz.ContainsKey(label))
                return diz[label];
            else
                return 0;
        }
        public int sum()
        {
            int val = 0;
            foreach(int i in diz.Values)
                val += i;
            return val;        
        }
        public void erase(string label)
        {
            if (diz.ContainsKey(label))
                diz.Remove(label);
            return;        
        }
    
    }
}
