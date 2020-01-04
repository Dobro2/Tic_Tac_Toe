namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wButton = new System.Windows.Forms.Button();
            this.oButton = new System.Windows.Forms.Button();
            this.rButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.wButton);
            this.panel2.Controls.Add(this.oButton);
            this.panel2.Controls.Add(this.rButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // wButton
            // 
            this.wButton.Location = new System.Drawing.Point(380, 30);
            this.wButton.Name = "wButton";
            this.wButton.Size = new System.Drawing.Size(108, 43);
            this.wButton.TabIndex = 2;
            this.wButton.Text = "Wyjscie";
            this.wButton.UseVisualStyleBackColor = true;
            this.wButton.Click += new System.EventHandler(this.wButton_Click);
            // 
            // oButton
            // 
            this.oButton.Location = new System.Drawing.Point(253, 30);
            this.oButton.Name = "oButton";
            this.oButton.Size = new System.Drawing.Size(108, 41);
            this.oButton.TabIndex = 1;
            this.oButton.Text = "O projekcie";
            this.oButton.UseVisualStyleBackColor = true;
            this.oButton.Click += new System.EventHandler(this.oButton_Click);
            // 
            // rButton
            // 
            this.rButton.Location = new System.Drawing.Point(26, 13);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(107, 75);
            this.rButton.TabIndex = 0;
            this.rButton.Text = "Restart";
            this.rButton.UseVisualStyleBackColor = true;
            this.rButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(161, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 639);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 639);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button wButton;
        private System.Windows.Forms.Button oButton;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Label label1;
    }
}

