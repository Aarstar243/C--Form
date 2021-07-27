
namespace Projet_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1044, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afficher ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Enabled = false;
            this.Prenom.Location = new System.Drawing.Point(69, 97);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(79, 15);
            this.Prenom.TabIndex = 3;
            this.Prenom.Text = "Votre prenom";
            this.Prenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(69, 145);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(65, 15);
            this.Nom.TabIndex = 4;
            this.Nom.Text = "Votre nom ";
            this.Nom.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 697);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Nom;
    }
}

