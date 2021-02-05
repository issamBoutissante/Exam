
namespace C1_Ado_TDI201B_Boutissante_issam
{
    partial class Gestion_Employe
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
            this.Email = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OuiRadio = new System.Windows.Forms.RadioButton();
            this.NonRadio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.EmpoyedataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Division = new System.Windows.Forms.ComboBox();
            this.DateEmbauche = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.EmpoyedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(180, 59);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(180, 95);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Embauche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Division";
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(180, 220);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(100, 20);
            this.Adresse.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresse";
            // 
            // OuiRadio
            // 
            this.OuiRadio.AutoSize = true;
            this.OuiRadio.Location = new System.Drawing.Point(180, 258);
            this.OuiRadio.Name = "OuiRadio";
            this.OuiRadio.Size = new System.Drawing.Size(41, 17);
            this.OuiRadio.TabIndex = 10;
            this.OuiRadio.TabStop = true;
            this.OuiRadio.Text = "Oui";
            this.OuiRadio.UseVisualStyleBackColor = true;
            this.OuiRadio.CheckedChanged += new System.EventHandler(this.OuiRadio_CheckedChanged);
            // 
            // NonRadio
            // 
            this.NonRadio.AutoSize = true;
            this.NonRadio.Location = new System.Drawing.Point(248, 257);
            this.NonRadio.Name = "NonRadio";
            this.NonRadio.Size = new System.Drawing.Size(47, 17);
            this.NonRadio.TabIndex = 11;
            this.NonRadio.TabStop = true;
            this.NonRadio.Text = "Nom";
            this.NonRadio.UseVisualStyleBackColor = true;
            this.NonRadio.CheckedChanged += new System.EventHandler(this.NonRadio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Responsable";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "|<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Vider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Modifeir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(489, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(608, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Ajouter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(489, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(489, 197);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = ">>|";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(608, 238);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "Enregistrer";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // EmpoyedataGridView
            // 
            this.EmpoyedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpoyedataGridView.Location = new System.Drawing.Point(26, 296);
            this.EmpoyedataGridView.Name = "EmpoyedataGridView";
            this.EmpoyedataGridView.Size = new System.Drawing.Size(762, 138);
            this.EmpoyedataGridView.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gestion Emplye";
            // 
            // Division
            // 
            this.Division.FormattingEnabled = true;
            this.Division.Location = new System.Drawing.Point(180, 174);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(100, 21);
            this.Division.TabIndex = 23;
            // 
            // DateEmbauche
            // 
            this.DateEmbauche.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEmbauche.Location = new System.Drawing.Point(180, 136);
            this.DateEmbauche.Name = "DateEmbauche";
            this.DateEmbauche.Size = new System.Drawing.Size(100, 20);
            this.DateEmbauche.TabIndex = 24;
            // 
            // Gestion_Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.DateEmbauche);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmpoyedataGridView);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NonRadio);
            this.Controls.Add(this.OuiRadio);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_Employe";
            this.Text = "Gestion_Employe";
            this.Load += new System.EventHandler(this.Gestion_Employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpoyedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton OuiRadio;
        private System.Windows.Forms.RadioButton NonRadio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView EmpoyedataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Division;
        private System.Windows.Forms.DateTimePicker DateEmbauche;
    }
}