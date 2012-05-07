using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Personaggio pg;
        Abilita my_abilita;
        Random generatore;

        public Form1()
        {
            InitializeComponent();
            
            pg = new Personaggio(); 
            my_abilita = new Abilita(pg);
            generatore = new Random(); 

            foreach (String s in my_abilita.abilita)
                dataGridView1.Rows.Add(s);
            
            aggiorna();                       
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pg.GeneraCaratteristiche(generatore);
            aggiorna();
            return;
        }
                   

        private void boxRazza_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (boxRazza.Text)
            {
                case "Umano":
                    pg.SetRazza(new Umano());
                    break;
                case "Elfo":
                    pg.SetRazza(new Elfo());
                    break;
                case "Nano":
                    pg.SetRazza(new Nano());
                    break;
                case "Mezzorco":
                    pg.SetRazza(new Mezzorco());
                    break;
                default:
                    pg.SetRazza(new Umano());
                    break;
            }
            aggiorna();
            return;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            int colonna = e.ColumnIndex;

            string abilita = (String)dataGridView1.Rows[riga].Cells[0].Value;
            int valore;

            if (Int32.TryParse((String)dataGridView1.Rows[riga].Cells[colonna].Value, out valore))
            {
                if (colonna == 2)
                { my_abilita.setPunteggioBase(abilita, valore); }
                else if (colonna == 4)
                { my_abilita.setPunteggioBonus(abilita, valore); }
            }
            aggiornaAbilita();
            return;
        }

        private void spinFor_ValueChanged(object sender, EventArgs e)
        { pg.For = (int)spinFor.Value; aggiorna(); }

        private void spinDes_ValueChanged(object sender, EventArgs e)
        { pg.Des = (int)spinDes.Value; aggiorna(); }

        private void spinCos_ValueChanged(object sender, EventArgs e)
        { pg.Cos = (int)spinCos.Value; aggiorna(); }

        private void spinInt_ValueChanged(object sender, EventArgs e)
        { pg.Int = (int)spinInt.Value; aggiorna(); }

        private void spinSag_ValueChanged(object sender, EventArgs e)
        { pg.Sag = (int)spinSag.Value; aggiorna(); }

        private void spinCar_ValueChanged(object sender, EventArgs e)
        { pg.Car = (int)spinCar.Value; aggiorna(); }


        private void aggiornaSpinBox()
        {
            spinFor.Value = pg.For;
            spinCos.Value = pg.Cos;
            spinDes.Value = pg.Des;
            spinInt.Value = pg.Int;
            spinSag.Value = pg.Sag;
            spinCar.Value = pg.Car;
            return;
        }

        private void calcolaBonus()
        {            
            modFor.Text = pg.getBonusByCaratteristica(Libreria.Caratterisiche.FOR).ToString();
            modDes.Text = pg.getBonusByCaratteristica(Libreria.Caratterisiche.DES).ToString();
            modCos.Text = pg.getBonusByCaratteristica(Libreria.Caratterisiche.COS).ToString();
            modInt.Text = pg.getBonusByCaratteristica(Libreria.Caratterisiche.INT).ToString();
            modSag.Text = pg.getBonusByCaratteristica(Libreria.Caratterisiche.SAG).ToString();
            modCar.Text = pg.getBonusByCaratteristica(Libreria.Caratterisiche.CAR).ToString();
            labelPunti.Text = pg.getPunti().ToString();
            return;
        }

        public void aggiornaAbilita()
        {
            int i = 0;
            
            foreach (String s in my_abilita.abilita)
            {
                dataGridView1.Rows[i].Cells[1].Value = my_abilita.getPunteggio(s).ToString();
                dataGridView1.Rows[i].Cells[2].Value = my_abilita.getPunteggioBase(s).ToString();
                dataGridView1.Rows[i].Cells[3].Value = my_abilita.getPunteggioMod(s).ToString();
                dataGridView1.Rows[i].Cells[4].Value = my_abilita.getPunteggioBonus(s).ToString();
                i++;
            }
            return;            
        }

        public void aggiorna()
        {
            aggiornaSpinBox();
            calcolaBonus();
            aggiornaAbilita();
            return;
        }

      
    }


    
}
