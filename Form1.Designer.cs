
using System.Windows.Forms;

namespace AboutMe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NameLabel = new System.Windows.Forms.Label();
            this.roundedButton1 = new AboutMe.RoundedButton("https://github.com/JavaDevMC");
            this.roundedButton2 = new AboutMe.RoundedButton("https://discord.gg/gbqF32Qsv2");
            this.roundedButton3 = new AboutMe.RoundedButton("https://tiktok.com/@maximclient");
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Constantia", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLabel.Location = new System.Drawing.Point(249, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(327, 78);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "MaximDe";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.Location = new System.Drawing.Point(319, 149);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(187, 47);
            this.roundedButton1.TabIndex = 2;
            this.roundedButton1.Text = "Github";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.White;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.Location = new System.Drawing.Point(319, 238);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(187, 47);
            this.roundedButton2.TabIndex = 3;
            this.roundedButton2.Text = "Discord";
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.White;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.Location = new System.Drawing.Point(319, 327);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(187, 47);
            this.roundedButton3.TabIndex = 4;
            this.roundedButton3.Text = "TikTok";
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.NameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
    }
}

