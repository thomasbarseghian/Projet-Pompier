namespace Barseghian_Nezami_SAE25
{
    partial class frmAjoutePompier
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.NOM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbHomme = new System.Windows.Forms.RadioButton();
            this.rdbFemme = new System.Windows.Forms.RadioButton();
            this.rdbVolantaire = new System.Windows.Forms.RadioButton();
            this.rdbPompier = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.dtpEmbauche = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.pnlGenre = new System.Windows.Forms.Panel();
            this.pnlType = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlGenre.SuspendLayout();
            this.pnlType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblHeader.Location = new System.Drawing.Point(195, 21);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(439, 55);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Nouveau Pompier";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Brown;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.Coral;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 73);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Resize += new System.EventHandler(this.pnlHeader_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(20, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 2);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom et Prénom";
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.RosyBrown;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNom.Location = new System.Drawing.Point(295, 140);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(195, 25);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.RosyBrown;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrenom.Location = new System.Drawing.Point(531, 140);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(195, 25);
            this.txtPrenom.TabIndex = 8;
            // 
            // NOM
            // 
            this.NOM.AutoSize = true;
            this.NOM.Location = new System.Drawing.Point(293, 168);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(32, 13);
            this.NOM.TabIndex = 9;
            this.NOM.Text = "NOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(20, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de Naissance";
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.CalendarForeColor = System.Drawing.Color.RosyBrown;
            this.dtpNaissance.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.dtpNaissance.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.dtpNaissance.CalendarTitleForeColor = System.Drawing.Color.RosyBrown;
            this.dtpNaissance.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dtpNaissance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNaissance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNaissance.Location = new System.Drawing.Point(295, 200);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(249, 26);
            this.dtpNaissance.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(20, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sexe";
            // 
            // rdbHomme
            // 
            this.rdbHomme.AutoSize = true;
            this.rdbHomme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.rdbHomme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHomme.Location = new System.Drawing.Point(2, 4);
            this.rdbHomme.Name = "rdbHomme";
            this.rdbHomme.Size = new System.Drawing.Size(81, 22);
            this.rdbHomme.TabIndex = 14;
            this.rdbHomme.TabStop = true;
            this.rdbHomme.Text = "Homme";
            this.rdbHomme.UseVisualStyleBackColor = true;
            // 
            // rdbFemme
            // 
            this.rdbFemme.AutoSize = true;
            this.rdbFemme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemme.Location = new System.Drawing.Point(167, 4);
            this.rdbFemme.Name = "rdbFemme";
            this.rdbFemme.Size = new System.Drawing.Size(80, 22);
            this.rdbFemme.TabIndex = 15;
            this.rdbFemme.TabStop = true;
            this.rdbFemme.Text = "Femme";
            this.rdbFemme.UseVisualStyleBackColor = true;
            // 
            // rdbVolantaire
            // 
            this.rdbVolantaire.AutoSize = true;
            this.rdbVolantaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVolantaire.Location = new System.Drawing.Point(177, 3);
            this.rdbVolantaire.Name = "rdbVolantaire";
            this.rdbVolantaire.Size = new System.Drawing.Size(96, 22);
            this.rdbVolantaire.TabIndex = 18;
            this.rdbVolantaire.TabStop = true;
            this.rdbVolantaire.Text = "Volantaire";
            this.rdbVolantaire.UseVisualStyleBackColor = true;
            // 
            // rdbPompier
            // 
            this.rdbPompier.AutoSize = true;
            this.rdbPompier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPompier.Location = new System.Drawing.Point(4, 3);
            this.rdbPompier.Name = "rdbPompier";
            this.rdbPompier.Size = new System.Drawing.Size(86, 22);
            this.rdbPompier.TabIndex = 17;
            this.rdbPompier.TabStop = true;
            this.rdbPompier.Text = "Pompier";
            this.rdbPompier.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(20, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Type";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.RosyBrown;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.Location = new System.Drawing.Point(296, 320);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(195, 25);
            this.txtPhone.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(20, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Portable";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(24, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(729, 2);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel4.Location = new System.Drawing.Point(2, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(729, 2);
            this.panel4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-2, -30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(314, 56);
            this.label9.TabIndex = 6;
            this.label9.Text = "\r\nInformations personnelles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(357, 28);
            this.label10.TabIndex = 21;
            this.label10.Text = "Informations Professionnelles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(20, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Caserne";
            // 
            // cboCaserne
            // 
            this.cboCaserne.BackColor = System.Drawing.Color.RosyBrown;
            this.cboCaserne.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserne.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Items.AddRange(new object[] {
            "Sangy bo na kai kor"});
            this.cboCaserne.Location = new System.Drawing.Point(296, 430);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(195, 27);
            this.cboCaserne.TabIndex = 24;
            this.cboCaserne.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboCaserne_DrawItem);
            // 
            // dtpEmbauche
            // 
            this.dtpEmbauche.CalendarForeColor = System.Drawing.Color.RosyBrown;
            this.dtpEmbauche.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.dtpEmbauche.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.dtpEmbauche.CalendarTitleForeColor = System.Drawing.Color.RosyBrown;
            this.dtpEmbauche.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dtpEmbauche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEmbauche.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmbauche.Location = new System.Drawing.Point(296, 550);
            this.dtpEmbauche.Name = "dtpEmbauche";
            this.dtpEmbauche.Size = new System.Drawing.Size(249, 26);
            this.dtpEmbauche.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(20, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "Date d\'embauche";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAjouter.Location = new System.Drawing.Point(594, 657);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(180, 45);
            this.btnAjouter.TabIndex = 27;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // pnlGenre
            // 
            this.pnlGenre.Controls.Add(this.rdbHomme);
            this.pnlGenre.Controls.Add(this.rdbFemme);
            this.pnlGenre.Location = new System.Drawing.Point(296, 260);
            this.pnlGenre.Name = "pnlGenre";
            this.pnlGenre.Size = new System.Drawing.Size(250, 30);
            this.pnlGenre.TabIndex = 29;
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.rdbVolantaire);
            this.pnlType.Controls.Add(this.rdbPompier);
            this.pnlType.Location = new System.Drawing.Point(296, 610);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(275, 35);
            this.pnlType.TabIndex = 30;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboGrade
            // 
            this.cboGrade.BackColor = System.Drawing.Color.RosyBrown;
            this.cboGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Items.AddRange(new object[] {
            "Sangy bo na kai kor"});
            this.cboGrade.Location = new System.Drawing.Point(295, 490);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(195, 27);
            this.cboGrade.TabIndex = 32;
            this.cboGrade.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboGrade_DrawItem);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblGrade.Location = new System.Drawing.Point(19, 490);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(63, 22);
            this.lblGrade.TabIndex = 31;
            this.lblGrade.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "Informations Personnelles";
            // 
            // frmAjoutePompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.pnlType);
            this.Controls.Add(this.pnlGenre);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dtpEmbauche);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboCaserne);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmAjoutePompier";
            this.Text = "Ajoute Nouveau Pompier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAjoutePompier_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlGenre.ResumeLayout(false);
            this.pnlGenre.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label NOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbHomme;
        private System.Windows.Forms.RadioButton rdbFemme;
        private System.Windows.Forms.RadioButton rdbVolantaire;
        private System.Windows.Forms.RadioButton rdbPompier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.DateTimePicker dtpEmbauche;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel pnlGenre;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label2;
    }
}