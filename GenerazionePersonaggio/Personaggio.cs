using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{

    public class Personaggio
    {

        public String nome;
        
        private int forza;
        public int For
        {
            get
            {
                int val = forza + razza.modCaratteristica(Libreria.Caratterisiche.FOR);
                return (val<0) ? 0 : val; 
            }
            set
            { forza = value - razza.modCaratteristica(Libreria.Caratterisiche.FOR); }
        }

        private int costituzione;
        public int Cos
        {
            get
            {
                int val = costituzione + razza.modCaratteristica(Libreria.Caratterisiche.COS);
                return (val < 0) ? 0 : val; 
            }
            set
            { costituzione = value - razza.modCaratteristica(Libreria.Caratterisiche.COS); }
        }

        private int destrezza;
        public int Des
        {
            get
            {
                int val = destrezza + razza.modCaratteristica(Libreria.Caratterisiche.DES);
                return (val < 0) ? 0 : val; 
            }
            set
            { destrezza = value - razza.modCaratteristica(Libreria.Caratterisiche.DES); }
        }

        private int intelligenza;
        public int Int
        {
            get
            { 
                int val =intelligenza + razza.modCaratteristica(Libreria.Caratterisiche.INT);
                return (val < 0) ? 0 : val; 
            }
            set
            { intelligenza = value - razza.modCaratteristica(Libreria.Caratterisiche.INT); }
        }

        private int saggezza;
        public int Sag
        {
            get
            { 
                int val=saggezza + razza.modCaratteristica(Libreria.Caratterisiche.SAG);
                return (val < 0) ? 0 : val; 
            }
            set
            { saggezza = value - razza.modCaratteristica(Libreria.Caratterisiche.SAG); }
        }

        private int carisma;
        public int Car
        {
            get
            { 
                int val=carisma + razza.modCaratteristica(Libreria.Caratterisiche.CAR);
                return (val < 0) ? 0 : val; 
            }
            set
            { carisma = value - razza.modCaratteristica(Libreria.Caratterisiche.CAR); }
        }
        
        private Razza razza;

        public Personaggio()
        {
            razza = new Umano();
        }
        public void GeneraCaratteristiche(Random gen)
        {
            do
            {
                forza = Dado.caratteristica4Dadi(gen);
                costituzione = Dado.caratteristica4Dadi(gen);
                destrezza = Dado.caratteristica4Dadi(gen);
                intelligenza = Dado.caratteristica4Dadi(gen);
                saggezza = Dado.caratteristica4Dadi(gen);
                carisma = Dado.caratteristica4Dadi(gen);
            } while (getPunti() < 22);
        }
        public void SetRazza(Razza _razza)
        { razza = _razza; }

        public int getPunti()
        {
            int punti = 0;
            punti = calcolaPunti(forza);
            punti += calcolaPunti(destrezza);
            punti += calcolaPunti(costituzione);
            punti += calcolaPunti(intelligenza);
            punti += calcolaPunti(saggezza);
            punti += calcolaPunti(carisma);

            return punti;
        
        }

        private int calcolaPunti(int caratteristica)
        {
            int p;
            if (caratteristica < 15)
                return caratteristica - 8;
            else
                p = calcolaPunti(caratteristica - 1) + ((caratteristica - 1) / 2 - 5);
            return p;        
        }

    }

}
