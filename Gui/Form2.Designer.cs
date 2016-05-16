namespace Gui
{
    partial class oknokonf1
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.poczatek = new System.Windows.Forms.TextBox();
            this.koniec = new System.Windows.Forms.TextBox();
            this.Dalej_button = new System.Windows.Forms.Button();
            this.Anuluj_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(85, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zdecyduj czy chcesz analizować cały plik \r\nczy tylko jego fragment:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(131, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cały plik";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(131, 149);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tylko fragment pliku:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Początek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koniec:";
            // 
            // poczatek
            // 
            this.poczatek.Enabled = false;
            this.poczatek.Location = new System.Drawing.Point(220, 177);
            this.poczatek.Name = "poczatek";
            this.poczatek.Size = new System.Drawing.Size(100, 20);
            this.poczatek.TabIndex = 5;
            // 
            // koniec
            // 
            this.koniec.Enabled = false;
            this.koniec.Location = new System.Drawing.Point(220, 199);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(100, 20);
            this.koniec.TabIndex = 6;
            // 
            // Dalej_button
            // 
            this.Dalej_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dalej_button.Location = new System.Drawing.Point(381, 324);
            this.Dalej_button.Name = "Dalej_button";
            this.Dalej_button.Size = new System.Drawing.Size(75, 23);
            this.Dalej_button.TabIndex = 8;
            this.Dalej_button.Text = "Dalej";
            this.Dalej_button.UseVisualStyleBackColor = true;
            this.Dalej_button.Click += new System.EventHandler(this.Dalej_button_Click);
            // 
            // Anuluj_button
            // 
            this.Anuluj_button.Location = new System.Drawing.Point(12, 324);
            this.Anuluj_button.Name = "Anuluj_button";
            this.Anuluj_button.Size = new System.Drawing.Size(75, 23);
            this.Anuluj_button.TabIndex = 9;
            this.Anuluj_button.Text = "Anuluj";
            this.Anuluj_button.UseVisualStyleBackColor = true;
            this.Anuluj_button.Click += new System.EventHandler(this.Anuluj_button_Click);
            // 
            // oknokonf1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 355);
            this.Controls.Add(this.Anuluj_button);
            this.Controls.Add(this.Dalej_button);
            this.Controls.Add(this.koniec);
            this.Controls.Add(this.poczatek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(487, 394);
            this.MinimumSize = new System.Drawing.Size(487, 394);
            this.Name = "oknokonf1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Konfiguracja - krok 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox koniec;
        private System.Windows.Forms.Button Dalej_button;
        private System.Windows.Forms.Button Anuluj_button;
        public System.Windows.Forms.TextBox poczatek;
    }
}