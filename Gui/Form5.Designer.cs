namespace Gui
{
    partial class oknokonf4
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
            this.rozpocznij_button = new System.Windows.Forms.Button();
            this.algorytm_label = new System.Windows.Forms.Label();
            this.algorytm_comboBox = new System.Windows.Forms.ComboBox();
            this.wstecz_button = new System.Windows.Forms.Button();
            this.nazwaprofilu_label = new System.Windows.Forms.Label();
            this.profil_label = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.parametry_label = new System.Windows.Forms.Label();
            this.tytul_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rozpocznij_button
            // 
            this.rozpocznij_button.Location = new System.Drawing.Point(334, 320);
            this.rozpocznij_button.Name = "rozpocznij_button";
            this.rozpocznij_button.Size = new System.Drawing.Size(125, 23);
            this.rozpocznij_button.TabIndex = 0;
            this.rozpocznij_button.Text = "Rozpocznij analizę";
            this.rozpocznij_button.UseVisualStyleBackColor = true;
            this.rozpocznij_button.Click += new System.EventHandler(this.rozpocznij_button_Click);
            // 
            // algorytm_label
            // 
            this.algorytm_label.AutoSize = true;
            this.algorytm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.algorytm_label.Location = new System.Drawing.Point(12, 112);
            this.algorytm_label.Name = "algorytm_label";
            this.algorytm_label.Size = new System.Drawing.Size(79, 20);
            this.algorytm_label.TabIndex = 1;
            this.algorytm_label.Text = "Algorytm: ";
            // 
            // algorytm_comboBox
            // 
            this.algorytm_comboBox.FormattingEnabled = true;
            this.algorytm_comboBox.Items.AddRange(new object[] {
            "Szybka Transformata Fouriera(FFT)",
            "Algortym CZT",
            "Algorymt ESPRIT"});
            this.algorytm_comboBox.Location = new System.Drawing.Point(130, 114);
            this.algorytm_comboBox.Name = "algorytm_comboBox";
            this.algorytm_comboBox.Size = new System.Drawing.Size(174, 21);
            this.algorytm_comboBox.TabIndex = 2;
            // 
            // wstecz_button
            // 
            this.wstecz_button.Location = new System.Drawing.Point(16, 320);
            this.wstecz_button.Name = "wstecz_button";
            this.wstecz_button.Size = new System.Drawing.Size(75, 23);
            this.wstecz_button.TabIndex = 3;
            this.wstecz_button.Text = "Wstecz";
            this.wstecz_button.UseVisualStyleBackColor = true;
            this.wstecz_button.Click += new System.EventHandler(this.wstecz_button_Click);
            // 
            // nazwaprofilu_label
            // 
            this.nazwaprofilu_label.AutoSize = true;
            this.nazwaprofilu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaprofilu_label.Location = new System.Drawing.Point(12, 73);
            this.nazwaprofilu_label.Name = "nazwaprofilu_label";
            this.nazwaprofilu_label.Size = new System.Drawing.Size(108, 20);
            this.nazwaprofilu_label.TabIndex = 4;
            this.nazwaprofilu_label.Text = "Nazwa profilu:";
            // 
            // profil_label
            // 
            this.profil_label.AutoSize = true;
            this.profil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.profil_label.Location = new System.Drawing.Point(126, 73);
            this.profil_label.Name = "profil_label";
            this.profil_label.Size = new System.Drawing.Size(53, 20);
            this.profil_label.TabIndex = 5;
            this.profil_label.Text = "Profil1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(130, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 160);
            this.listBox1.TabIndex = 6;
            // 
            // parametry_label
            // 
            this.parametry_label.AutoSize = true;
            this.parametry_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.parametry_label.Location = new System.Drawing.Point(12, 154);
            this.parametry_label.Name = "parametry_label";
            this.parametry_label.Size = new System.Drawing.Size(85, 20);
            this.parametry_label.TabIndex = 8;
            this.parametry_label.Text = "Parametry:";
            // 
            // tytul_label
            // 
            this.tytul_label.AutoSize = true;
            this.tytul_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytul_label.ForeColor = System.Drawing.Color.Gray;
            this.tytul_label.Location = new System.Drawing.Point(162, 24);
            this.tytul_label.Name = "tytul_label";
            this.tytul_label.Size = new System.Drawing.Size(153, 24);
            this.tytul_label.TabIndex = 9;
            this.tytul_label.Text = "Podsumowanie";
            // 
            // oknokonf4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 355);
            this.Controls.Add(this.tytul_label);
            this.Controls.Add(this.parametry_label);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.profil_label);
            this.Controls.Add(this.nazwaprofilu_label);
            this.Controls.Add(this.wstecz_button);
            this.Controls.Add(this.algorytm_comboBox);
            this.Controls.Add(this.algorytm_label);
            this.Controls.Add(this.rozpocznij_button);
            this.MaximumSize = new System.Drawing.Size(487, 394);
            this.MinimumSize = new System.Drawing.Size(487, 394);
            this.Name = "oknokonf4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfiguracja ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rozpocznij_button;
        private System.Windows.Forms.Label algorytm_label;
        private System.Windows.Forms.ComboBox algorytm_comboBox;
        private System.Windows.Forms.Button wstecz_button;
        private System.Windows.Forms.Label nazwaprofilu_label;
        private System.Windows.Forms.Label profil_label;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label parametry_label;
        private System.Windows.Forms.Label tytul_label;
    }
}