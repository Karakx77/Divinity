using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Abilita
    {
        public String[] abilita;
        private Dictionary<String, int> dizBase;
        private Dictionary<String, int> dizBonus;
        private Dictionary<String, Libreria.Caratterisiche> dizMod;
        
        Personaggio personaggio;

        public Abilita(Personaggio p)
        {
            
            String[] riga = System.IO.File.ReadAllLines(@"C:\TestFolder\abilita.txt");
            personaggio = p;
            dizBase = new Dictionary<string, int>();
            dizBonus = new Dictionary<string, int>();
            dizMod = new Dictionary<string, Libreria.Caratterisiche>();

            foreach (String s in riga)
            {
                String[] aux = s.Split(';');
                dizBase[aux[0]] = 0;
                dizBonus[aux[0]] = 0;

                switch (aux[1])
                {
                    case "FOR":
                        dizMod[aux[0]] = Libreria.Caratterisiche.FOR;
                        break;
                    case "DES":
                        dizMod[aux[0]] = Libreria.Caratterisiche.DES;
                        break;
                    case "COS":
                        dizMod[aux[0]] = Libreria.Caratterisiche.COS;
                        break;
                    case "INT":
                        dizMod[aux[0]] = Libreria.Caratterisiche.INT;
                        break;
                    case "SAG":
                        dizMod[aux[0]] = Libreria.Caratterisiche.SAG;
                        break;
                    case "CAR":
                        dizMod[aux[0]] = Libreria.Caratterisiche.CAR;
                        break;        
                }         
            }
            abilita = dizBase.Keys.ToArray<String>();

        }
       

        public int getPunteggio(string abilita)
        {
            int punteggio;
            punteggio = dizBase[abilita];
            punteggio += dizBonus[abilita];
            punteggio += personaggio.getBonusByCaratteristica(dizMod[abilita]);        
            return punteggio;
        }

        public int getPunteggioBase(string abilita)
        {
            int punteggio;
            punteggio = dizBase[abilita];
            return punteggio;        
        }

        public int getPunteggioMod(string abilita)
        {
            int punteggio;
            punteggio = personaggio.getBonusByCaratteristica(dizMod[abilita]);
            return punteggio;
        }

        public int getPunteggioBonus(string abilita)
        {
            int punteggio;
            punteggio = dizBonus[abilita];
            return punteggio;       
        }

        public void setPunteggioBase(string abilita, int value)
        {
            int i;
            if (dizBase.TryGetValue(abilita, out i))
                dizBase[abilita] = value;        
        }

        public void setPunteggioBonus(string abilita, int value)
        {
            int i;
            if (dizBonus.TryGetValue(abilita, out i))
                dizBonus[abilita] = value;
        }


    }
}
