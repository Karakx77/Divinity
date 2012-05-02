namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modFor = new System.Windows.Forms.Label();
            this.modDes = new System.Windows.Forms.Label();
            this.modCos = new System.Windows.Forms.Label();
            this.modInt = new System.Windows.Forms.Label();
            this.modSag = new System.Windows.Forms.Label();
            this.modCar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.spinFor = new System.Windows.Forms.NumericUpDown();
            this.spinDes = new System.Windows.Forms.NumericUpDown();
            this.spinCos = new System.Windows.Forms.NumericUpDown();
            this.spinInt = new System.Windows.Forms.NumericUpDown();
            this.spinSag = new System.Windows.Forms.NumericUpDown();
            this.spinCar = new System.Windows.Forms.NumericUpDown();
            this.boxRazza = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelPunti = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caratterisicheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Abilita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valore_base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spinFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratterisicheBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Forza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destrezza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Costituzione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Intelligenza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saggezza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Carisma";
            // 
            // modFor
            // 
            this.modFor.AutoSize = true;
            this.modFor.Location = new System.Drawing.Point(171, 65);
            this.modFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modFor.Name = "modFor";
            this.modFor.Size = new System.Drawing.Size(12, 17);
            this.modFor.TabIndex = 12;
            this.modFor.Text = "\\";
            // 
            // modDes
            // 
            this.modDes.AutoSize = true;
            this.modDes.Location = new System.Drawing.Point(171, 93);
            this.modDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modDes.Name = "modDes";
            this.modDes.Size = new System.Drawing.Size(12, 17);
            this.modDes.TabIndex = 13;
            this.modDes.Text = "\\";
            // 
            // modCos
            // 
            this.modCos.AutoSize = true;
            this.modCos.Location = new System.Drawing.Point(171, 123);
            this.modCos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modCos.Name = "modCos";
            this.modCos.Size = new System.Drawing.Size(12, 17);
            this.modCos.TabIndex = 14;
            this.modCos.Text = "\\";
            // 
            // modInt
            // 
            this.modInt.AutoSize = true;
            this.modInt.Location = new System.Drawing.Point(171, 153);
            this.modInt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modInt.Name = "modInt";
            this.modInt.Size = new System.Drawing.Size(12, 17);
            this.modInt.TabIndex = 15;
            this.modInt.Text = "\\";
            // 
            // modSag
            // 
            this.modSag.AutoSize = true;
            this.modSag.Location = new System.Drawing.Point(171, 183);
            this.modSag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modSag.Name = "modSag";
            this.modSag.Size = new System.Drawing.Size(12, 17);
            this.modSag.TabIndex = 16;
            this.modSag.Text = "\\";
            // 
            // modCar
            // 
            this.modCar.AutoSize = true;
            this.modCar.Location = new System.Drawing.Point(171, 213);
            this.modCar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modCar.Name = "modCar";
            this.modCar.Size = new System.Drawing.Size(12, 17);
            this.modCar.TabIndex = 17;
            this.modCar.Text = "\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Genera Caratteristiche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spinFor
            // 
            this.spinFor.Location = new System.Drawing.Point(99, 63);
            this.spinFor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinFor.Name = "spinFor";
            this.spinFor.Size = new System.Drawing.Size(64, 22);
            this.spinFor.TabIndex = 19;
            this.spinFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinFor.ValueChanged += new System.EventHandler(this.spinFor_ValueChanged);
            // 
            // spinDes
            // 
            this.spinDes.Location = new System.Drawing.Point(99, 91);
            this.spinDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinDes.Name = "spinDes";
            this.spinDes.Size = new System.Drawing.Size(64, 22);
            this.spinDes.TabIndex = 20;
            this.spinDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinDes.ValueChanged += new System.EventHandler(this.spinDes_ValueChanged);
            // 
            // spinCos
            // 
            this.spinCos.Location = new System.Drawing.Point(99, 121);
            this.spinCos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinCos.Name = "spinCos";
            this.spinCos.Size = new System.Drawing.Size(64, 22);
            this.spinCos.TabIndex = 21;
            this.spinCos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinCos.ValueChanged += new System.EventHandler(this.spinCos_ValueChanged);
            // 
            // spinInt
            // 
            this.spinInt.Location = new System.Drawing.Point(99, 151);
            this.spinInt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinInt.Name = "spinInt";
            this.spinInt.Size = new System.Drawing.Size(64, 22);
            this.spinInt.TabIndex = 22;
            this.spinInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinInt.ValueChanged += new System.EventHandler(this.spinInt_ValueChanged);
            // 
            // spinSag
            // 
            this.spinSag.Location = new System.Drawing.Point(99, 181);
            this.spinSag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinSag.Name = "spinSag";
            this.spinSag.Size = new System.Drawing.Size(64, 22);
            this.spinSag.TabIndex = 23;
            this.spinSag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinSag.ValueChanged += new System.EventHandler(this.spinSag_ValueChanged);
            // 
            // spinCar
            // 
            this.spinCar.Location = new System.Drawing.Point(99, 211);
            this.spinCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinCar.Name = "spinCar";
            this.spinCar.Size = new System.Drawing.Size(64, 22);
            this.spinCar.TabIndex = 24;
            this.spinCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinCar.ValueChanged += new System.EventHandler(this.spinCar_ValueChanged);
            // 
            // boxRazza
            // 
            this.boxRazza.DisplayMember = "fdfdf";
            this.boxRazza.FormattingEnabled = true;
            this.boxRazza.Items.AddRange(new object[] {
            "Umano",
            "Nano",
            "Elfo",
            "Mezzorco"});
            this.boxRazza.Location = new System.Drawing.Point(371, 46);
            this.boxRazza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxRazza.Name = "boxRazza";
            this.boxRazza.Size = new System.Drawing.Size(160, 24);
            this.boxRazza.TabIndex = 25;
            this.boxRazza.Tag = "";
            this.boxRazza.SelectedIndexChanged += new System.EventHandler(this.boxRazza_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Punti:";
            // 
            // labelPunti
            // 
            this.labelPunti.AutoSize = true;
            this.labelPunti.Location = new System.Drawing.Point(154, 28);
            this.labelPunti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPunti.Name = "labelPunti";
            this.labelPunti.Size = new System.Drawing.Size(46, 17);
            this.labelPunti.TabIndex = 27;
            this.labelPunti.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Razza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spinFor);
            this.groupBox1.Controls.Add(this.modFor);
            this.groupBox1.Controls.Add(this.labelPunti);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.spinDes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.spinCos);
            this.groupBox1.Controls.Add(this.spinInt);
            this.groupBox1.Controls.Add(this.spinCar);
            this.groupBox1.Controls.Add(this.modCar);
            this.groupBox1.Controls.Add(this.spinSag);
            this.groupBox1.Controls.Add(this.modSag);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.modInt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.modCos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.modDes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 317);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caratteristiche";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abilita,
            this.Valore_base,
            this.Mod});
            this.dataGridView1.Location = new System.Drawing.Point(235, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 471);
            this.dataGridView1.TabIndex = 31;
            // 
            // caratterisicheBindingSource
            // 
            this.caratterisicheBindingSource.DataSource = typeof(WindowsFormsApplication1.Libreria.Caratterisiche);
            // 
            // Abilita
            // 
            this.Abilita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Abilita.HeaderText = "Abilità";
            this.Abilita.Name = "Abilita";
            this.Abilita.ReadOnly = true;
            this.Abilita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Abilita.Width = 52;
            // 
            // Valore_base
            // 
            this.Valore_base.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Valore_base.HeaderText = "Base";
            this.Valore_base.Name = "Valore_base";
            this.Valore_base.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valore_base.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Valore_base.Width = 46;
            // 
            // Mod
            // 
            this.Mod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Mod.HeaderText = "Mod";
            this.Mod.Name = "Mod";
            this.Mod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mod.Width = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxRazza);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caratterisicheBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label modFor;
        private System.Windows.Forms.Label modDes;
        private System.Windows.Forms.Label modCos;
        private System.Windows.Forms.Label modInt;
        private System.Windows.Forms.Label modSag;
        private System.Windows.Forms.Label modCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown spinFor;
        private System.Windows.Forms.NumericUpDown spinDes;
        private System.Windows.Forms.NumericUpDown spinCos;
        private System.Windows.Forms.NumericUpDown spinInt;
        private System.Windows.Forms.NumericUpDown spinSag;
        private System.Windows.Forms.NumericUpDown spinCar;
        private System.Windows.Forms.ComboBox boxRazza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelPunti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource caratterisicheBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abilita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valore_base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mod;
    }
}

