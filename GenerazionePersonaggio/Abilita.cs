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
        private Dictionary<String, Libreria.Caratterisiche> dizMod;
        private Dictionary<String, GestioneBonus> dizBonus;
        private Personaggio personaggio;

        public Abilita(Personaggio p)
        {
            String[] riga = System.IO.File.ReadAllLines(Libreria.pathFileAbilita);
            personaggio = p;
            dizBase = new Dictionary<string, int>();
            dizBonus = new Dictionary<string, GestioneBonus>();
            dizMod = new Dictionary<string, Libreria.Caratterisiche>();

            foreach (String s in riga)
            {
                String[] aux = s.Split(';');
                dizBase[aux[0]] = 0;
                dizBonus[aux[0]] = new GestioneBonus();

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
            punteggio = getPunteggioBase(abilita);
            punteggio += getPunteggioBonus(abilita);
            punteggio += personaggio.getModificatore(dizMod[abilita]);        
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
            punteggio = personaggio.getModificatore(dizMod[abilita]);
            return punteggio;
        }

        public int getPunteggioBonus(string abilita)
        {   
            return dizBonus[abilita].sum(); 
        }

        public void setPunteggioBase(string abilita, int value)
        {
            int i;
            if (dizBase.TryGetValue(abilita, out i))
                dizBase[abilita] = value;        
        }       
        
        public GestioneBonus getBonus(string abilita)
        {
            if (dizBonus.ContainsKey(abilita))
            { return dizBonus[abilita]; }
            return null;
        }

    }
}
