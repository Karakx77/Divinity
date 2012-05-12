using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public interface Classe
    {
        int getBonusPuntiAbilita();
        int getBonusAttacco(int lv);
        //int getBaseTempra(int lv);
        //int getBaseRiflessi(int lv);
        //int getBaseVolonta(int lv);
    }

    public class Guerriero : Classe
    {
        public int getBonusPuntiAbilita()
        { return 2; }
        public int getBonusAttacco(int lv)
        { return Libreria.attaccoBuono(lv);  }
    
    }
}
