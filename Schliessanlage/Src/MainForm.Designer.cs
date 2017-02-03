namespace Schliessanlage
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // tbGreen
            // 
            this.tbGreen.LargeChange = 30;
            this.tbGreen.Location = new System.Drawing.Point(158, 63);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(548, 45);
            this.tbGreen.TabIndex = 2;
            this.tbGreen.TickFrequency = 15;
            this.tbGreen.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbRed
            // 
            this.tbRed.LargeChange = 30;
            this.tbRed.Location = new System.Drawing.Point(158, 12);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(548, 45);
            this.tbRed.TabIndex = 3;
            this.tbRed.TickFrequency = 15;
            this.tbRed.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.LargeChange = 30;
            this.tbBlue.Location = new System.Drawing.Point(158, 114);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(548, 45);
            this.tbBlue.TabIndex = 4;
            this.tbBlue.TickFrequency = 15;
            this.tbBlue.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blau";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.tbGreen);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer loop;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

