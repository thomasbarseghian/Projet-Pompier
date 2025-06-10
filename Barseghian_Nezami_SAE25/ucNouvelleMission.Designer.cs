namespace Barseghian_Nezami_SAE25
{
    partial class ucNouvelleMission
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDeclenche = new System.Windows.Forms.Label();
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNatureSinistre = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.flpVehicules = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbMotif = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbVille = new System.Windows.Forms.RichTextBox();
            this.rtbCP = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbRue = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlEnginPompier = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flpPompiers = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.epNouvelleMission = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlEnginPompier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNouvelleMission)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblMission.Location = new System.Drawing.Point(43, 123);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(102, 22);
            this.lblMission.TabIndex = 0;
            this.lblMission.Text = "Mission n° ";
            // 
            // lblDeclenche
            // 
            this.lblDeclenche.AutoSize = true;
            this.lblDeclenche.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblDeclenche.Location = new System.Drawing.Point(511, 123);
            this.lblDeclenche.Name = "lblDeclenche";
            this.lblDeclenche.Size = new System.Drawing.Size(144, 22);
            this.lblDeclenche.TabIndex = 1;
            this.lblDeclenche.Text = "déclenchée le : ";
            // 
            // btnEquipe
            // 
            this.btnEquipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEquipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEquipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipe.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEquipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEquipe.Location = new System.Drawing.Point(776, 100);
            this.btnEquipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(136, 42);
            this.btnEquipe.TabIndex = 8;
            this.btnEquipe.Text = "Constituer";
            this.btnEquipe.UseVisualStyleBackColor = false;
            this.btnEquipe.Click += new System.EventHandler(this.btnEquipe_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAnnuler.Location = new System.Drawing.Point(622, 100);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(136, 42);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Effacer";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboCaserne
            // 
            this.cboCaserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCaserne.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboCaserne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(702, 53);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(211, 30);
            this.cboCaserne.TabIndex = 6;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCaserne.Location = new System.Drawing.Point(547, 59);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(149, 18);
            this.lblCaserne.TabIndex = 5;
            this.lblCaserne.Text = "Caserne à Mobiliser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(34, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nature du sinistre";
            // 
            // cboNatureSinistre
            // 
            this.cboNatureSinistre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.cboNatureSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNatureSinistre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboNatureSinistre.Font = new System.Drawing.Font("Arial", 14.25F);
            this.cboNatureSinistre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cboNatureSinistre.FormattingEnabled = true;
            this.cboNatureSinistre.Location = new System.Drawing.Point(174, 53);
            this.cboNatureSinistre.Name = "cboNatureSinistre";
            this.cboNatureSinistre.Size = new System.Drawing.Size(352, 30);
            this.cboNatureSinistre.TabIndex = 0;
            this.cboNatureSinistre.SelectedIndexChanged += new System.EventHandler(this.cboNatureSinistre_SelectedIndexChanged);
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnCreer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.btnCreer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCreer.Location = new System.Drawing.Point(776, 265);
            this.btnCreer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(136, 42);
            this.btnCreer.TabIndex = 9;
            this.btnCreer.Text = "Creer";
            this.btnCreer.UseVisualStyleBackColor = false;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // flpVehicules
            // 
            this.flpVehicules.AutoScroll = true;
            this.flpVehicules.Location = new System.Drawing.Point(15, 88);
            this.flpVehicules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpVehicules.Name = "flpVehicules";
            this.flpVehicules.Size = new System.Drawing.Size(382, 165);
            this.flpVehicules.TabIndex = 13;
            // 
            // rtbMotif
            // 
            this.rtbMotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.rtbMotif.Location = new System.Drawing.Point(15, 75);
            this.rtbMotif.Name = "rtbMotif";
            this.rtbMotif.Size = new System.Drawing.Size(348, 127);
            this.rtbMotif.TabIndex = 0;
            this.rtbMotif.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(464, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse sinistre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(465, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(465, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(465, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ville";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 73);
            this.panel1.TabIndex = 11;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblHeader.Location = new System.Drawing.Point(304, 16);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(416, 55);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Nouvelle Mission";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbVille);
            this.panel2.Controls.Add(this.rtbCP);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.rtbRue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rtbMotif);
            this.panel2.Location = new System.Drawing.Point(47, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 214);
            this.panel2.TabIndex = 12;
            // 
            // rtbVille
            // 
            this.rtbVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.rtbVille.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbVille.Location = new System.Drawing.Point(507, 163);
            this.rtbVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbVille.Name = "rtbVille";
            this.rtbVille.Size = new System.Drawing.Size(381, 27);
            this.rtbVille.TabIndex = 11;
            this.rtbVille.Text = "";
            this.rtbVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbVille_KeyPress);
            // 
            // rtbCP
            // 
            this.rtbCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.rtbCP.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbCP.Location = new System.Drawing.Point(563, 127);
            this.rtbCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbCP.MaxLength = 5;
            this.rtbCP.Name = "rtbCP";
            this.rtbCP.Size = new System.Drawing.Size(68, 27);
            this.rtbCP.TabIndex = 6;
            this.rtbCP.Text = "";
            this.rtbCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbCP_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Informations usagers";
            // 
            // rtbRue
            // 
            this.rtbRue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.rtbRue.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbRue.Location = new System.Drawing.Point(507, 90);
            this.rtbRue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbRue.Name = "rtbRue";
            this.rtbRue.Size = new System.Drawing.Size(381, 27);
            this.rtbRue.TabIndex = 7;
            this.rtbRue.Text = "";
            this.rtbRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbRue_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnEquipe);
            this.panel3.Controls.Add(this.cboCaserne);
            this.panel3.Controls.Add(this.cboNatureSinistre);
            this.panel3.Controls.Add(this.btnAnnuler);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblCaserne);
            this.panel3.Font = new System.Drawing.Font("Arial", 12F);
            this.panel3.Location = new System.Drawing.Point(47, 395);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 153);
            this.panel3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label8.Location = new System.Drawing.Point(11, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Décisions du régulateur";
            // 
            // pnlEnginPompier
            // 
            this.pnlEnginPompier.Controls.Add(this.label12);
            this.pnlEnginPompier.Controls.Add(this.label13);
            this.pnlEnginPompier.Controls.Add(this.flpPompiers);
            this.pnlEnginPompier.Controls.Add(this.label11);
            this.pnlEnginPompier.Controls.Add(this.label10);
            this.pnlEnginPompier.Controls.Add(this.label9);
            this.pnlEnginPompier.Controls.Add(this.flpVehicules);
            this.pnlEnginPompier.Controls.Add(this.btnCreer);
            this.pnlEnginPompier.Location = new System.Drawing.Point(47, 570);
            this.pnlEnginPompier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlEnginPompier.Name = "pnlEnginPompier";
            this.pnlEnginPompier.Size = new System.Drawing.Size(928, 360);
            this.pnlEnginPompier.TabIndex = 14;
            this.pnlEnginPompier.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F);
            this.label12.Location = new System.Drawing.Point(692, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Habillitation";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F);
            this.label13.Location = new System.Drawing.Point(495, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 17;
            this.label13.Text = "Matricule";
            // 
            // flpPompiers
            // 
            this.flpPompiers.AutoScroll = true;
            this.flpPompiers.Location = new System.Drawing.Point(499, 88);
            this.flpPompiers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpPompiers.Name = "flpPompiers";
            this.flpPompiers.Size = new System.Drawing.Size(383, 165);
            this.flpPompiers.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.Location = new System.Drawing.Point(209, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(12, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Code Type Engin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.label9.Location = new System.Drawing.Point(11, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(413, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mobilisation des engins et des pompiers";
            // 
            // epNouvelleMission
            // 
            this.epNouvelleMission.ContainerControl = this;
            // 
            // ucNouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.pnlEnginPompier);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDeclenche);
            this.Controls.Add(this.lblMission);
            this.Name = "ucNouvelleMission";
            this.Size = new System.Drawing.Size(1021, 1349);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlEnginPompier.ResumeLayout(false);
            this.pnlEnginPompier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNouvelleMission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDeclenche;
        private System.Windows.Forms.ComboBox cboNatureSinistre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.RichTextBox rtbMotif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.FlowLayoutPanel flpVehicules;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbRue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbCP;
        private System.Windows.Forms.RichTextBox rtbVille;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlEnginPompier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flpPompiers;
        private System.Windows.Forms.ErrorProvider epNouvelleMission;
    }
}
