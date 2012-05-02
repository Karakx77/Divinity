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

            my_abilita = new Abilita();
            foreach (String s in my_abilita.abilita)
                dataGridView1.Rows.Add(s, "0", "0");

            generatore = new Random();
            pg=new Personaggio();
            pg.For = 8;
            pg.Des = 8;
            pg.Cos = 8;
            pg.Int = 8;
            pg.Sag = 8;
            pg.Car = 8;

            
            aggiornaSpinBox();
            
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            pg.GeneraCaratteristiche(generatore);
            aggiornaSpinBox();
           
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
            aggiornaSpinBox();
        }        

        private void spinFor_ValueChanged(object sender, EventArgs e)
        { pg.For = (int)spinFor.Value; calcolaBonus(); }

        private void spinDes_ValueChanged(object sender, EventArgs e)
        { pg.Des = (int)spinDes.Value; calcolaBonus(); }

        private void spinCos_ValueChanged(object sender, EventArgs e)
        { pg.Cos = (int)spinCos.Value; calcolaBonus(); }

        private void spinInt_ValueChanged(object sender, EventArgs e)
        { pg.Int = (int)spinInt.Value; calcolaBonus(); }

        private void spinSag_ValueChanged(object sender, EventArgs e)
        { pg.Sag = (int)spinSag.Value; calcolaBonus(); }

        private void spinCar_ValueChanged(object sender, EventArgs e)
        { pg.Car = (int)spinCar.Value; calcolaBonus(); }


        private void aggiornaSpinBox()
        {
            spinFor.Value = pg.For;
            spinCos.Value = pg.Cos;
            spinDes.Value = pg.Des;
            spinInt.Value = pg.Int;
            spinSag.Value = pg.Sag;
            spinCar.Value = pg.Car;
            calcolaBonus();
        }

        private void calcolaBonus()
        {
            
            modFor.Text = "" + ((pg.For / 2) - 5);
            modDes.Text = "" + ((pg.Des / 2) - 5);
            modCos.Text = "" + ((pg.Cos / 2) - 5);
            modInt.Text = "" + ((pg.Int / 2) - 5);
            modSag.Text = "" + ((pg.Sag / 2) - 5);
            modCar.Text = "" + ((pg.Car / 2) - 5);

            labelPunti.Text = "" + pg.getPunti();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }  

       
    }


    
}
