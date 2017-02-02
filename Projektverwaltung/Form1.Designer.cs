namespace Projektverwaltung
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
            this.lstbProjekte = new System.Windows.Forms.ListBox();
            this.lstbTasks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProNumber = new System.Windows.Forms.TextBox();
            this.txtProBudget = new System.Windows.Forms.TextBox();
            this.btnProSpeichern = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtTaskProNumber = new System.Windows.Forms.TextBox();
            this.txtTaskTime = new System.Windows.Forms.TextBox();
            this.txtTaskStatus = new System.Windows.Forms.TextBox();
            this.btnTaskSpeichern = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGesamtZeit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGesamtzeitaufwand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbProjekte
            // 
            this.lstbProjekte.FormattingEnabled = true;
            this.lstbProjekte.ItemHeight = 16;
            this.lstbProjekte.Location = new System.Drawing.Point(13, 30);
            this.lstbProjekte.Margin = new System.Windows.Forms.Padding(4);
            this.lstbProjekte.Name = "lstbProjekte";
            this.lstbProjekte.Size = new System.Drawing.Size(170, 228);
            this.lstbProjekte.TabIndex = 0;
            this.lstbProjekte.SelectedIndexChanged += new System.EventHandler(this.lstbProjekte_SelectedIndexChanged);
            // 
            // lstbTasks
            // 
            this.lstbTasks.FormattingEnabled = true;
            this.lstbTasks.ItemHeight = 16;
            this.lstbTasks.Location = new System.Drawing.Point(216, 30);
            this.lstbTasks.Margin = new System.Windows.Forms.Padding(4);
            this.lstbTasks.Name = "lstbTasks";
            this.lstbTasks.Size = new System.Drawing.Size(170, 228);
            this.lstbTasks.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projekte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tasks";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(421, 74);
            this.txtProName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(168, 22);
            this.txtProName.TabIndex = 4;
            // 
            // txtProNumber
            // 
            this.txtProNumber.Location = new System.Drawing.Point(421, 119);
            this.txtProNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtProNumber.Name = "txtProNumber";
            this.txtProNumber.Size = new System.Drawing.Size(168, 22);
            this.txtProNumber.TabIndex = 5;
            this.txtProNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowOnlyNumbers);
            // 
            // txtProBudget
            // 
            this.txtProBudget.Location = new System.Drawing.Point(421, 170);
            this.txtProBudget.Margin = new System.Windows.Forms.Padding(4);
            this.txtProBudget.Name = "txtProBudget";
            this.txtProBudget.Size = new System.Drawing.Size(168, 22);
            this.txtProBudget.TabIndex = 6;
            this.txtProBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowOnlyNumbers);
            // 
            // btnProSpeichern
            // 
            this.btnProSpeichern.Location = new System.Drawing.Point(425, 213);
            this.btnProSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.btnProSpeichern.Name = "btnProSpeichern";
            this.btnProSpeichern.Size = new System.Drawing.Size(163, 36);
            this.btnProSpeichern.TabIndex = 7;
            this.btnProSpeichern.Text = "speichern";
            this.btnProSpeichern.UseVisualStyleBackColor = true;
            this.btnProSpeichern.Click += new System.EventHandler(this.btnProSpeichern_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Eigenschaften Projekt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Projektname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Projektnummer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Projektbudget";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(648, 74);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(168, 22);
            this.txtTaskName.TabIndex = 12;
            // 
            // txtTaskProNumber
            // 
            this.txtTaskProNumber.Location = new System.Drawing.Point(647, 119);
            this.txtTaskProNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskProNumber.Name = "txtTaskProNumber";
            this.txtTaskProNumber.Size = new System.Drawing.Size(168, 22);
            this.txtTaskProNumber.TabIndex = 13;
            this.txtTaskProNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowOnlyNumbers);
            // 
            // txtTaskTime
            // 
            this.txtTaskTime.Location = new System.Drawing.Point(647, 170);
            this.txtTaskTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskTime.Name = "txtTaskTime";
            this.txtTaskTime.Size = new System.Drawing.Size(168, 22);
            this.txtTaskTime.TabIndex = 14;
            this.txtTaskTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShowOnlyNumbers);
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.Location = new System.Drawing.Point(647, 219);
            this.txtTaskStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.Size = new System.Drawing.Size(168, 22);
            this.txtTaskStatus.TabIndex = 15;
            // 
            // btnTaskSpeichern
            // 
            this.btnTaskSpeichern.Location = new System.Drawing.Point(649, 260);
            this.btnTaskSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaskSpeichern.Name = "btnTaskSpeichern";
            this.btnTaskSpeichern.Size = new System.Drawing.Size(163, 41);
            this.btnTaskSpeichern.TabIndex = 16;
            this.btnTaskSpeichern.Text = "speichern";
            this.btnTaskSpeichern.UseVisualStyleBackColor = true;
            this.btnTaskSpeichern.Click += new System.EventHandler(this.btnTaskSpeichern_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Eigenschaften Task";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(652, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Taskname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Projektnummer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 149);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Zeitaufwand";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(649, 198);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Status";
            // 
            // txtGesamtZeit
            // 
            this.txtGesamtZeit.Enabled = false;
            this.txtGesamtZeit.Location = new System.Drawing.Point(37, 306);
            this.txtGesamtZeit.Margin = new System.Windows.Forms.Padding(4);
            this.txtGesamtZeit.Name = "txtGesamtZeit";
            this.txtGesamtZeit.ReadOnly = true;
            this.txtGesamtZeit.Size = new System.Drawing.Size(281, 22);
            this.txtGesamtZeit.TabIndex = 22;
            this.txtGesamtZeit.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(287, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Gsamtzeitaufwand für ausgewähltes Projekt:";
            // 
            // btnGesamtzeitaufwand
            // 
            this.btnGesamtzeitaufwand.Location = new System.Drawing.Point(328, 305);
            this.btnGesamtzeitaufwand.Margin = new System.Windows.Forms.Padding(4);
            this.btnGesamtzeitaufwand.Name = "btnGesamtzeitaufwand";
            this.btnGesamtzeitaufwand.Size = new System.Drawing.Size(181, 25);
            this.btnGesamtzeitaufwand.TabIndex = 24;
            this.btnGesamtzeitaufwand.Text = "Gesamtzeitaufwand";
            this.btnGesamtzeitaufwand.UseVisualStyleBackColor = true;
            this.btnGesamtzeitaufwand.Click += new System.EventHandler(this.btnGesamtzeitaufwand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 350);
            this.Controls.Add(this.btnGesamtzeitaufwand);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGesamtZeit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTaskSpeichern);
            this.Controls.Add(this.txtTaskStatus);
            this.Controls.Add(this.txtTaskTime);
            this.Controls.Add(this.txtTaskProNumber);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProSpeichern);
            this.Controls.Add(this.txtProBudget);
            this.Controls.Add(this.txtProNumber);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbTasks);
            this.Controls.Add(this.lstbProjekte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Projektverwaltung - Pascal Hobza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbProjekte;
        private System.Windows.Forms.ListBox lstbTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProNumber;
        private System.Windows.Forms.TextBox txtProBudget;
        private System.Windows.Forms.Button btnProSpeichern;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtTaskProNumber;
        private System.Windows.Forms.TextBox txtTaskTime;
        private System.Windows.Forms.TextBox txtTaskStatus;
        private System.Windows.Forms.Button btnTaskSpeichern;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGesamtZeit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGesamtzeitaufwand;
    }
}

