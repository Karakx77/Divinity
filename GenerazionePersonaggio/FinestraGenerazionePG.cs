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
    public partial class FinestraGenerazionePG : Form
    {        
        Personaggio pg;
        Abilita my_abilita;
        Random generatore;
        GestioneBonus bonusAttivo;
        
        public FinestraGenerazionePG()
        {
            InitializeComponent();
            
            pg = new Personaggio(); 
            my_abilita = new Abilita(pg);
            generatore = new Random(); 

            foreach (String s in my_abilita.abilita)
                Abilita_dataGridView.Rows.Add(s);
            
            bonusAttivo = null;
            Bonus_dataGridView.Enabled = false;
            aggiorna();                       
        }
        
        private void tiraCaratteristiche_Click(object sender, EventArgs e)
        {
            pg.GeneraCaratteristiche(generatore);
            aggiorna();
            return;
        }

        private void livello_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int lv=(int)livello_numericUpDown.Value;
            pg.livello = lv;
            //labelEsperienza.Text = (Libreria.calcolaEsp(lv)*1000).ToString();
            //labelEsperienza.Text = Libreria.attaccoScarso(lv).ToString();
            labelEsperienza.Text = Libreria.listaAttacchi(lv);
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
         

        public void aggiorna()
        {
            aggiornaCaratteristiche();
            aggiornaAbilita();
            return;
        }
               
        
        /*--------------------- Gestione Tabella Abilita -------------------*/

        private void Abilita_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            int colonna = e.ColumnIndex;

            string abilita = (String)Abilita_dataGridView.Rows[riga].Cells[0].Value;
            int valore;

            if (Int32.TryParse((String)Abilita_dataGridView.Rows[riga].Cells[colonna].Value, out valore))
            {
                if (colonna == 2)
                { my_abilita.setPunteggioBase(abilita, valore); }
            }
            aggiorna();
            return;
        }
        
        
        private void Abilita_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                string label = Abilita_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                bonusAttivo = my_abilita.getBonus(label);
                ridisegnaBonus("Abilità "+label);
                aggiorna();
            }
        }

        public void aggiornaAbilita()
        {
            int i = 0;

            foreach (String s in my_abilita.abilita)
            {
                Abilita_dataGridView.Rows[i].Cells[1].Value = my_abilita.getPunteggio(s).ToString();
                Abilita_dataGridView.Rows[i].Cells[2].Value = my_abilita.getPunteggioBase(s).ToString();
                Abilita_dataGridView.Rows[i].Cells[3].Value = my_abilita.getPunteggioMod(s).ToString();
                Abilita_dataGridView.Rows[i].Cells[4].Value = my_abilita.getPunteggioBonus(s).ToString();
                i++;
            }
            return;
        }

        /* --------------------- Gestione Tabella Bonus ---------------------*/

        private void Bonus_dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int riga = e.RowIndex, colonna = e.ColumnIndex;
            bool labelDefinita=true;
            String label=null;
            int value;

            try
            { label = Bonus_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(); }
            catch { labelDefinita = false; aggiorna(); }
            try
            { Int32.TryParse(Bonus_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(), out value); }
            catch {value=0;}

            if (bonusAttivo != null && labelDefinita)
            {
                bonusAttivo.add(label, value);
                Bonus_dataGridView.Rows[riga].Cells[0].ReadOnly=true;
                aggiorna();
                Bonus_dataGridView.Rows[riga].Cells[1].Value = bonusAttivo.get(label);
            }
            
            return;
        }

        private void Bonus_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && !Bonus_dataGridView.Rows[e.RowIndex].IsNewRow)
            {
                BonusRowsRemoved(e.RowIndex);
            }
            else
                return;
        }

        private void BonusRowsRemoved(int RowIndex)
        {          
            bonusAttivo.erase(Bonus_dataGridView.Rows[RowIndex].Cells[0].Value.ToString());
            ridisegnaBonus();
            aggiorna();
            return;
         }

        public void ridisegnaBonus(string label="")
        {
            if (bonusAttivo != null)
            {
                Bonus_dataGridView.Enabled = true;
                Bonus_dataGridView.Rows.Clear();
                foreach (String s in bonusAttivo.diz.Keys)
                { Bonus_dataGridView.Rows.Add(s, bonusAttivo.get(s).ToString()); }
                if(label!="")
                    labelBonusView.Text = "Bonus " + label;
            }
            return;
        }        

        /* ------------------Gestione caratteristiche--------------------- */

        private void aggiornaCaratteristiche()
        {
            spinFor.Value = pg.For;
            spinCos.Value = pg.Cos;
            spinDes.Value = pg.Des;
            spinInt.Value = pg.Int;
            spinSag.Value = pg.Sag;
            spinCar.Value = pg.Car;

            forBonus_button.Text = pg.calcolaBonus(Libreria.Caratterisiche.FOR).ToString();
            desBonus_button.Text = pg.calcolaBonus(Libreria.Caratterisiche.DES).ToString();
            cosBonus_button.Text = pg.calcolaBonus(Libreria.Caratterisiche.COS).ToString();
            intBonus_button.Text = pg.calcolaBonus(Libreria.Caratterisiche.INT).ToString();
            sagBonus_button.Text = pg.calcolaBonus(Libreria.Caratterisiche.SAG).ToString();
            carBonus_button.Text = pg.calcolaBonus(Libreria.Caratterisiche.CAR).ToString();
            
            modFor.Text = pg.getModificatore(Libreria.Caratterisiche.FOR).ToString();
            modDes.Text = pg.getModificatore(Libreria.Caratterisiche.DES).ToString();
            modCos.Text = pg.getModificatore(Libreria.Caratterisiche.COS).ToString();
            modInt.Text = pg.getModificatore(Libreria.Caratterisiche.INT).ToString();
            modSag.Text = pg.getModificatore(Libreria.Caratterisiche.SAG).ToString();
            modCar.Text = pg.getModificatore(Libreria.Caratterisiche.CAR).ToString();
            labelPunti.Text = pg.getPunti().ToString();
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


        private void forBonus_button_Click(object sender, EventArgs e)
        {
            bonusAttivo = pg.getBonus(Libreria.Caratterisiche.FOR);
            ridisegnaBonus("Forza");
            aggiorna();
        }

        private void desBonus_button_Click(object sender, EventArgs e)
        {
            bonusAttivo = pg.getBonus(Libreria.Caratterisiche.DES);
            ridisegnaBonus("Destrezza");
            aggiorna();
        }

        private void cosBonus_button_Click(object sender, EventArgs e)
        {
            bonusAttivo = pg.getBonus(Libreria.Caratterisiche.COS);
            ridisegnaBonus("Costituzione");
            aggiorna();
        }

        private void intBonus_button_Click(object sender, EventArgs e)
        {
            bonusAttivo = pg.getBonus(Libreria.Caratterisiche.INT);
            ridisegnaBonus("Intelligenza");
            aggiorna();
        }

        private void sagBonus_button_Click(object sender, EventArgs e)
        {
            bonusAttivo = pg.getBonus(Libreria.Caratterisiche.SAG);
            ridisegnaBonus("Saggezza");
            aggiorna();
        }

        private void carBonus_button_Click(object sender, EventArgs e)
        {
            bonusAttivo = pg.getBonus(Libreria.Caratterisiche.CAR);
            ridisegnaBonus("Carisma");
            aggiorna();
        }

        

      

        

             
    }


    
}
