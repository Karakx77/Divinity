using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Abilita
    {
        public String[] abilita;
        public Abilita()
        {
            abilita = System.IO.File.ReadAllLines(@"C:\TestFolder\abilita.txt");        
        }
    }
}
