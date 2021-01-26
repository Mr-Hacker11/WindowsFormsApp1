
namespace WindowsFormsApp1
{
    partial class AnzeigeWert
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
            this.Lautstärkeeinstellung = new System.Windows.Forms.TrackBar();
            this.Geschwindigkeitseinstellung = new System.Windows.Forms.NumericUpDown();
            this.Textlabel = new System.Windows.Forms.Label();
            this.Geschwindigkeit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lautstärkeeinstellung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geschwindigkeitseinstellung)).BeginInit();
            this.SuspendLayout();
            // 
            // Lautstärkeeinstellung
            // 
            this.Lautstärkeeinstellung.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lautstärkeeinstellung.Location = new System.Drawing.Point(12, 39);
            this.Lautstärkeeinstellung.Name = "Lautstärkeeinstellung";
            this.Lautstärkeeinstellung.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Lautstärkeeinstellung.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lautstärkeeinstellung.Size = new System.Drawing.Size(45, 261);
            this.Lautstärkeeinstellung.TabIndex = 0;
            this.Lautstärkeeinstellung.Value = 2;
            // 
            // Geschwindigkeitseinstellung
            // 
            this.Geschwindigkeitseinstellung.Location = new System.Drawing.Point(228, 55);
            this.Geschwindigkeitseinstellung.Maximum = new decimal(new int[] {
            -1863462912,
            46,
            0,
            0});
            this.Geschwindigkeitseinstellung.Name = "Geschwindigkeitseinstellung";
            this.Geschwindigkeitseinstellung.Size = new System.Drawing.Size(226, 20);
            this.Geschwindigkeitseinstellung.TabIndex = 1;
            this.Geschwindigkeitseinstellung.Tag = "Simon";
            this.Geschwindigkeitseinstellung.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Textlabel
            // 
            this.Textlabel.AutoSize = true;
            this.Textlabel.Location = new System.Drawing.Point(9, 23);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(57, 13);
            this.Textlabel.TabIndex = 2;
            this.Textlabel.Text = "Lautstärke";
            // 
            // Geschwindigkeit
            // 
            this.Geschwindigkeit.AutoSize = true;
            this.Geschwindigkeit.Location = new System.Drawing.Point(256, 39);
            this.Geschwindigkeit.Name = "Geschwindigkeit";
            this.Geschwindigkeit.Size = new System.Drawing.Size(85, 13);
            this.Geschwindigkeit.TabIndex = 3;
            this.Geschwindigkeit.Text = "Geschwindigkeit";
            this.Geschwindigkeit.Click += new System.EventHandler(this.Geschwindigkeit_Click);
            // 
            // AnzeigeWert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Geschwindigkeit);
            this.Controls.Add(this.Textlabel);
            this.Controls.Add(this.Geschwindigkeitseinstellung);
            this.Controls.Add(this.Lautstärkeeinstellung);
            this.IsMdiContainer = true;
            this.Name = "AnzeigeWert";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Lautstärkeeinstellung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Geschwindigkeitseinstellung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Lautstärkeeinstellung;
        private System.Windows.Forms.NumericUpDown Geschwindigkeitseinstellung;
        private System.Windows.Forms.Label Textlabel;
        private System.Windows.Forms.Label Geschwindigkeit;
    }
}

