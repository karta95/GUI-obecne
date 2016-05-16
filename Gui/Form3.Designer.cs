namespace Gui
{
    partial class oknokonf2
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
            this.llistaprofili_listBox = new System.Windows.Forms.ListBox();
            this.listaparametro_listBox = new System.Windows.Forms.ListBox();
            this.listaprofili_label = new System.Windows.Forms.Label();
            this.listaparametrow_label = new System.Windows.Forms.Label();
            this.wstecz_button = new System.Windows.Forms.Button();
            this.dodajprofil_button = new System.Windows.Forms.Button();
            this.dalej_button = new System.Windows.Forms.Button();
            this.wybierzprofil_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llistaprofili_listBox
            // 
            this.llistaprofili_listBox.FormattingEnabled = true;
            this.llistaprofili_listBox.Items.AddRange(new object[] {
            "Profil1",
            "Profil2",
            "Profil3"});
            this.llistaprofili_listBox.Location = new System.Drawing.Point(37, 78);
            this.llistaprofili_listBox.Name = "llistaprofili_listBox";
            this.llistaprofili_listBox.Size = new System.Drawing.Size(166, 225);
            this.llistaprofili_listBox.TabIndex = 0;
            this.llistaprofili_listBox.SelectedIndexChanged += new System.EventHandler(this.llistaprofili_listBox_SelectedIndexChanged);
            // 
            // listaparametro_listBox
            // 
            this.listaparametro_listBox.FormattingEnabled = true;
            this.listaparametro_listBox.Location = new System.Drawing.Point(269, 78);
            this.listaparametro_listBox.Name = "listaparametro_listBox";
            this.listaparametro_listBox.Size = new System.Drawing.Size(166, 225);
            this.listaparametro_listBox.TabIndex = 1;
            // 
            // listaprofili_label
            // 
            this.listaprofili_label.AutoSize = true;
            this.listaprofili_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaprofili_label.Location = new System.Drawing.Point(33, 55);
            this.listaprofili_label.Name = "listaprofili_label";
            this.listaprofili_label.Size = new System.Drawing.Size(88, 20);
            this.listaprofili_label.TabIndex = 2;
            this.listaprofili_label.Text = "Lista profili:";
            // 
            // listaparametrow_label
            // 
            this.listaparametrow_label.AutoSize = true;
            this.listaparametrow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaparametrow_label.Location = new System.Drawing.Point(265, 55);
            this.listaparametrow_label.Name = "listaparametrow_label";
            this.listaparametrow_label.Size = new System.Drawing.Size(139, 20);
            this.listaparametrow_label.TabIndex = 3;
            this.listaparametrow_label.Text = "Lista parametrów: ";
            // 
            // wstecz_button
            // 
            this.wstecz_button.Location = new System.Drawing.Point(37, 320);
            this.wstecz_button.Name = "wstecz_button";
            this.wstecz_button.Size = new System.Drawing.Size(75, 23);
            this.wstecz_button.TabIndex = 4;
            this.wstecz_button.Text = "Wstecz";
            this.wstecz_button.UseVisualStyleBackColor = true;
            this.wstecz_button.Click += new System.EventHandler(this.wstecz_button_Click);
            // 
            // dodajprofil_button
            // 
            this.dodajprofil_button.Location = new System.Drawing.Point(128, 320);
            this.dodajprofil_button.Name = "dodajprofil_button";
            this.dodajprofil_button.Size = new System.Drawing.Size(75, 23);
            this.dodajprofil_button.TabIndex = 5;
            this.dodajprofil_button.Text = "Dodaj";
            this.dodajprofil_button.UseVisualStyleBackColor = true;
            this.dodajprofil_button.Click += new System.EventHandler(this.dodajprofil_button_Click);
            // 
            // dalej_button
            // 
            this.dalej_button.Location = new System.Drawing.Point(360, 320);
            this.dalej_button.Name = "dalej_button";
            this.dalej_button.Size = new System.Drawing.Size(75, 23);
            this.dalej_button.TabIndex = 6;
            this.dalej_button.Text = "Dalej";
            this.dalej_button.UseVisualStyleBackColor = true;
            this.dalej_button.Click += new System.EventHandler(this.dalej_button_Click);
            // 
            // wybierzprofil_label
            // 
            this.wybierzprofil_label.AutoSize = true;
            this.wybierzprofil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wybierzprofil_label.ForeColor = System.Drawing.Color.Gray;
            this.wybierzprofil_label.Location = new System.Drawing.Point(173, 23);
            this.wybierzprofil_label.Name = "wybierzprofil_label";
            this.wybierzprofil_label.Size = new System.Drawing.Size(117, 20);
            this.wybierzprofil_label.TabIndex = 7;
            this.wybierzprofil_label.Text = "Wybierz profil";
            // 
            // oknokonf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 355);
            this.Controls.Add(this.wybierzprofil_label);
            this.Controls.Add(this.dalej_button);
            this.Controls.Add(this.dodajprofil_button);
            this.Controls.Add(this.wstecz_button);
            this.Controls.Add(this.listaparametrow_label);
            this.Controls.Add(this.listaprofili_label);
            this.Controls.Add(this.listaparametro_listBox);
            this.Controls.Add(this.llistaprofili_listBox);
            this.MaximumSize = new System.Drawing.Size(487, 394);
            this.MinimumSize = new System.Drawing.Size(487, 394);
            this.Name = "oknokonf2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfiguracja - krok 2";
            this.Load += new System.EventHandler(this.oknokonf2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox llistaprofili_listBox;
        private System.Windows.Forms.ListBox listaparametro_listBox;
        private System.Windows.Forms.Label listaprofili_label;
        private System.Windows.Forms.Label listaparametrow_label;
        private System.Windows.Forms.Button wstecz_button;
        private System.Windows.Forms.Button dodajprofil_button;
        private System.Windows.Forms.Button dalej_button;
        private System.Windows.Forms.Label wybierzprofil_label;

    }
}