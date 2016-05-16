namespace Gui
{
    partial class oknokonf3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.utworzprofil_label = new System.Windows.Forms.Label();
            this.zapiszprofil_button = new System.Windows.Forms.Button();
            this.nazwaprofilu_label = new System.Windows.Forms.Label();
            this.nazwaprofilu_textBox = new System.Windows.Forms.TextBox();
            this.parametrNazwa_label = new System.Windows.Forms.Label();
            this.parametr1_textBox = new System.Windows.Forms.TextBox();
            this.dataGridViewParametry = new System.Windows.Forms.DataGridView();
            this.NrParametruColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaParametruColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDodajParametr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametry)).BeginInit();
            this.SuspendLayout();
            // 
            // utworzprofil_label
            // 
            this.utworzprofil_label.AutoSize = true;
            this.utworzprofil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.utworzprofil_label.ForeColor = System.Drawing.Color.Gray;
            this.utworzprofil_label.Location = new System.Drawing.Point(162, 23);
            this.utworzprofil_label.Name = "utworzprofil_label";
            this.utworzprofil_label.Size = new System.Drawing.Size(125, 24);
            this.utworzprofil_label.TabIndex = 0;
            this.utworzprofil_label.Text = "Utwórz profil";
            // 
            // zapiszprofil_button
            // 
            this.zapiszprofil_button.Location = new System.Drawing.Point(12, 320);
            this.zapiszprofil_button.Name = "zapiszprofil_button";
            this.zapiszprofil_button.Size = new System.Drawing.Size(447, 23);
            this.zapiszprofil_button.TabIndex = 1;
            this.zapiszprofil_button.Text = "Zapisz profil";
            this.zapiszprofil_button.UseVisualStyleBackColor = true;
            this.zapiszprofil_button.Click += new System.EventHandler(this.zapiszprofil_button_Click);
            // 
            // nazwaprofilu_label
            // 
            this.nazwaprofilu_label.AutoSize = true;
            this.nazwaprofilu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaprofilu_label.Location = new System.Drawing.Point(12, 71);
            this.nazwaprofilu_label.Name = "nazwaprofilu_label";
            this.nazwaprofilu_label.Size = new System.Drawing.Size(106, 18);
            this.nazwaprofilu_label.TabIndex = 2;
            this.nazwaprofilu_label.Text = "Nazwa profilu: ";
            // 
            // nazwaprofilu_textBox
            // 
            this.nazwaprofilu_textBox.Location = new System.Drawing.Point(147, 71);
            this.nazwaprofilu_textBox.Name = "nazwaprofilu_textBox";
            this.nazwaprofilu_textBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaprofilu_textBox.TabIndex = 3;
            // 
            // parametrNazwa_label
            // 
            this.parametrNazwa_label.AutoSize = true;
            this.parametrNazwa_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parametrNazwa_label.Location = new System.Drawing.Point(12, 105);
            this.parametrNazwa_label.Name = "parametrNazwa_label";
            this.parametrNazwa_label.Size = new System.Drawing.Size(129, 18);
            this.parametrNazwa_label.TabIndex = 4;
            this.parametrNazwa_label.Text = "Nazwa parametru:";
            // 
            // parametr1_textBox
            // 
            this.parametr1_textBox.Location = new System.Drawing.Point(147, 103);
            this.parametr1_textBox.Name = "parametr1_textBox";
            this.parametr1_textBox.Size = new System.Drawing.Size(100, 20);
            this.parametr1_textBox.TabIndex = 5;
            // 
            // dataGridViewParametry
            // 
            this.dataGridViewParametry.AllowUserToAddRows = false;
            this.dataGridViewParametry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParametry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParametry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NrParametruColumn,
            this.NazwaParametruColumn});
            this.dataGridViewParametry.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewParametry.Name = "dataGridViewParametry";
            this.dataGridViewParametry.ReadOnly = true;
            this.dataGridViewParametry.Size = new System.Drawing.Size(447, 172);
            this.dataGridViewParametry.TabIndex = 8;
            // 
            // NrParametruColumn
            // 
            this.NrParametruColumn.FillWeight = 30.45685F;
            this.NrParametruColumn.HeaderText = "Nr";
            this.NrParametruColumn.Name = "NrParametruColumn";
            this.NrParametruColumn.ReadOnly = true;
            // 
            // NazwaParametruColumn
            // 
            this.NazwaParametruColumn.FillWeight = 169.5432F;
            this.NazwaParametruColumn.HeaderText = "Nazwa parametru";
            this.NazwaParametruColumn.Name = "NazwaParametruColumn";
            this.NazwaParametruColumn.ReadOnly = true;
            // 
            // buttonDodajParametr
            // 
            this.buttonDodajParametr.Location = new System.Drawing.Point(253, 101);
            this.buttonDodajParametr.Name = "buttonDodajParametr";
            this.buttonDodajParametr.Size = new System.Drawing.Size(96, 23);
            this.buttonDodajParametr.TabIndex = 9;
            this.buttonDodajParametr.Text = "Dodaj Parametr";
            this.buttonDodajParametr.UseVisualStyleBackColor = true;
            this.buttonDodajParametr.Click += new System.EventHandler(this.buttonDodajParametr_Click);
            // 
            // oknokonf3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 355);
            this.Controls.Add(this.buttonDodajParametr);
            this.Controls.Add(this.dataGridViewParametry);
            this.Controls.Add(this.parametr1_textBox);
            this.Controls.Add(this.parametrNazwa_label);
            this.Controls.Add(this.nazwaprofilu_textBox);
            this.Controls.Add(this.nazwaprofilu_label);
            this.Controls.Add(this.zapiszprofil_button);
            this.Controls.Add(this.utworzprofil_label);
            this.MaximumSize = new System.Drawing.Size(487, 394);
            this.MinimumSize = new System.Drawing.Size(487, 394);
            this.Name = "oknokonf3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfiguracja - Profil";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParametry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label utworzprofil_label;
        private System.Windows.Forms.Button zapiszprofil_button;
        private System.Windows.Forms.Label nazwaprofilu_label;
        private System.Windows.Forms.TextBox nazwaprofilu_textBox;
        private System.Windows.Forms.Label parametrNazwa_label;
        private System.Windows.Forms.TextBox parametr1_textBox;
        private System.Windows.Forms.DataGridView dataGridViewParametry;
        private System.Windows.Forms.Button buttonDodajParametr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrParametruColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaParametruColumn;
    }
}