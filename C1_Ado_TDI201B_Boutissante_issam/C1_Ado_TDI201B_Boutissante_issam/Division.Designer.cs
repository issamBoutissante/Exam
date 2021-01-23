
namespace C1_Ado_TDI201B_Boutissante_issam
{
    partial class Division
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
            this.Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idDivision = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Divisions";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(159, 80);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(159, 124);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(100, 20);
            this.Description.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gestion Division";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idDivision
            // 
            this.idDivision.FormattingEnabled = true;
            this.idDivision.Items.AddRange(new object[] {
            "Desktop",
            "Web",
            "Mobile"});
            this.idDivision.Location = new System.Drawing.Point(159, 41);
            this.idDivision.Name = "idDivision";
            this.idDivision.Size = new System.Drawing.Size(100, 21);
            this.idDivision.TabIndex = 10;
            this.idDivision.SelectedIndexChanged += new System.EventHandler(this.idDivision_SelectedIndexChanged);
            // 
            // Division
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idDivision);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Division";
            this.Text = "Division";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox idDivision;
    }
}