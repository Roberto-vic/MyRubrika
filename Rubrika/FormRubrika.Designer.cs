namespace Rubrika
{
    partial class FormRubrika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRubrika));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontaktenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTitel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFormular = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkBoxFav = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNotizen = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtHandy = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtPlz = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTabelle = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelTitel.SuspendLayout();
            this.panelFormular.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontaktenToolStripMenuItem,
            this.closeStripMenu});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.dateiToolStripMenuItem.Text = "Kontakte";
            // 
            // kontaktenToolStripMenuItem
            // 
            this.kontaktenToolStripMenuItem.Name = "kontaktenToolStripMenuItem";
            this.kontaktenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.kontaktenToolStripMenuItem.Text = "Kontakten";
            this.kontaktenToolStripMenuItem.Click += new System.EventHandler(this.KontaktenToolStripMenuItem_Click);
            // 
            // closeStripMenu
            // 
            this.closeStripMenu.Name = "closeStripMenu";
            this.closeStripMenu.Size = new System.Drawing.Size(128, 22);
            this.closeStripMenu.Text = "Exit";
            this.closeStripMenu.Click += new System.EventHandler(this.CloseStripMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // panelTitel
            // 
            this.panelTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelTitel.Controls.Add(this.label1);
            this.panelTitel.Location = new System.Drawing.Point(0, 28);
            this.panelTitel.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitel.Name = "panelTitel";
            this.panelTitel.Size = new System.Drawing.Size(695, 73);
            this.panelTitel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(151, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyPersonal Rubrika";
            // 
            // panelFormular
            // 
            this.panelFormular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFormular.Controls.Add(this.button2);
            this.panelFormular.Controls.Add(this.txtDatum);
            this.panelFormular.Controls.Add(this.label12);
            this.panelFormular.Controls.Add(this.chkBoxFav);
            this.panelFormular.Controls.Add(this.btnClear);
            this.panelFormular.Controls.Add(this.button1);
            this.panelFormular.Controls.Add(this.txtNotizen);
            this.panelFormular.Controls.Add(this.txtMail);
            this.panelFormular.Controls.Add(this.txtHandy);
            this.panelFormular.Controls.Add(this.txtTelefon);
            this.panelFormular.Controls.Add(this.txtPlz);
            this.panelFormular.Controls.Add(this.txtOrt);
            this.panelFormular.Controls.Add(this.txtAdresse);
            this.panelFormular.Controls.Add(this.txtNachname);
            this.panelFormular.Controls.Add(this.txtName);
            this.panelFormular.Controls.Add(this.label11);
            this.panelFormular.Controls.Add(this.label10);
            this.panelFormular.Controls.Add(this.label9);
            this.panelFormular.Controls.Add(this.label8);
            this.panelFormular.Controls.Add(this.label7);
            this.panelFormular.Controls.Add(this.label6);
            this.panelFormular.Controls.Add(this.label5);
            this.panelFormular.Controls.Add(this.label4);
            this.panelFormular.Controls.Add(this.label3);
            this.panelFormular.Controls.Add(this.label2);
            this.panelFormular.Location = new System.Drawing.Point(0, 105);
            this.panelFormular.Margin = new System.Windows.Forms.Padding(2);
            this.panelFormular.Name = "panelFormular";
            this.panelFormular.Size = new System.Drawing.Size(303, 500);
            this.panelFormular.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(11, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Favoriten";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnFavoriten_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(109, 249);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(181, 20);
            this.txtDatum.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Kontakt erstellen";
            // 
            // chkBoxFav
            // 
            this.chkBoxFav.AutoSize = true;
            this.chkBoxFav.Location = new System.Drawing.Point(109, 439);
            this.chkBoxFav.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxFav.Name = "chkBoxFav";
            this.chkBoxFav.Size = new System.Drawing.Size(70, 17);
            this.chkBoxFav.TabIndex = 22;
            this.chkBoxFav.Text = "Favoriten";
            this.chkBoxFav.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClear.Location = new System.Drawing.Point(11, 364);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 29);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(11, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtNotizen
            // 
            this.txtNotizen.Location = new System.Drawing.Point(109, 280);
            this.txtNotizen.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotizen.Multiline = true;
            this.txtNotizen.Name = "txtNotizen";
            this.txtNotizen.Size = new System.Drawing.Size(181, 146);
            this.txtNotizen.TabIndex = 19;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(109, 222);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(181, 20);
            this.txtMail.TabIndex = 17;
            // 
            // txtHandy
            // 
            this.txtHandy.Location = new System.Drawing.Point(109, 192);
            this.txtHandy.Margin = new System.Windows.Forms.Padding(2);
            this.txtHandy.Name = "txtHandy";
            this.txtHandy.Size = new System.Drawing.Size(181, 20);
            this.txtHandy.TabIndex = 16;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(109, 165);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(181, 20);
            this.txtTelefon.TabIndex = 15;
            // 
            // txtPlz
            // 
            this.txtPlz.Location = new System.Drawing.Point(109, 138);
            this.txtPlz.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlz.Name = "txtPlz";
            this.txtPlz.Size = new System.Drawing.Size(181, 20);
            this.txtPlz.TabIndex = 14;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(109, 113);
            this.txtOrt.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(181, 20);
            this.txtOrt.TabIndex = 13;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(109, 88);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(181, 20);
            this.txtAdresse.TabIndex = 12;
            // 
            // txtNachname
            // 
            this.txtNachname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNachname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNachname.Location = new System.Drawing.Point(109, 65);
            this.txtNachname.Margin = new System.Windows.Forms.Padding(2);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(181, 20);
            this.txtNachname.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(109, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 282);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "NOTIZEN: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 252);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "GEBURTSTAG:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "EMAIL: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "HANDY: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "TELEFON: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "PLZ:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "STADT: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ADRESSE: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NACHNAME: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NAME: ";
            // 
            // panelTabelle
            // 
            this.panelTabelle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTabelle.BackgroundImage")));
            this.panelTabelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTabelle.Location = new System.Drawing.Point(307, 105);
            this.panelTabelle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTabelle.Name = "panelTabelle";
            this.panelTabelle.Size = new System.Drawing.Size(387, 500);
            this.panelTabelle.TabIndex = 3;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 22);
            this.toolStripMenuItem1.Text = "?";
            // 
            // FormRubrika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(695, 614);
            this.Controls.Add(this.panelTabelle);
            this.Controls.Add(this.panelFormular);
            this.Controls.Add(this.panelTitel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRubrika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyRubrika 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTitel.ResumeLayout(false);
            this.panelTitel.PerformLayout();
            this.panelFormular.ResumeLayout(false);
            this.panelFormular.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFormular;
        private System.Windows.Forms.Panel panelTabelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotizen;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtHandy;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtPlz;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkBoxFav;
        private System.Windows.Forms.ToolStripMenuItem closeStripMenu;
        private System.Windows.Forms.ToolStripMenuItem kontaktenToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

