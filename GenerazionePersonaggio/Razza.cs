using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public interface Razza
    {
        int modCaratteristica(Libreria.Caratterisiche caratteristica);
    }

    public class Umano : Razza
    {
        public int modCaratteristica(Libreria.Caratterisiche caratteristica)
        { return 0; }
    }

    public class Nano : Razza
    {
        public int modCaratteristica(Libreria.Caratterisiche caratteristica)
        {
            int mod = 0;
            if (caratteristica == Libreria.Caratterisiche.CAR)
                mod = -2;
            else if (caratteristica == Libreria.Caratterisiche.COS)
                mod = 2;
            return mod;
        }
    }

    public class Elfo : Razza
    {
        public int modCaratteristica(Libreria.Caratterisiche caratteristica)
        {
            int mod = 0;
            if (caratteristica == Libreria.Caratterisiche.DES)
                mod = +2;
            else if (caratteristica == Libreria.Caratterisiche.COS)
                mod = -2;
            return mod;
        }
    }

    public class Mezzorco : Razza
    {
        public int modCaratteristica(Libreria.Caratterisiche caratteristica)
        {
            int mod = 0;
            if (caratteristica == Libreria.Caratterisiche.FOR)
                mod = +2;
            else if (caratteristica == Libreria.Caratterisiche.CAR)
                mod = -2;
            else if (caratteristica == Libreria.Caratterisiche.INT)
                mod = -2;
            return mod;
        }
    }
}
