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
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDeclenche = new System.Windows.Forms.Label();
            this.grpInfosUsagers = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMotif = new System.Windows.Forms.RichTextBox();
            this.grpDecisions = new System.Windows.Forms.GroupBox();
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNatureSinistre = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.grpEnginsPompiers = new System.Windows.Forms.GroupBox();
            this.dgvPompiers = new System.Windows.Forms.DataGridView();
            this.dgvEngins = new System.Windows.Forms.DataGridView();
            this.grpInfosUsagers.SuspendLayout();
            this.grpDecisions.SuspendLayout();
            this.grpEnginsPompiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMission.Location = new System.Drawing.Point(64, 34);
            this.lblMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(111, 29);
            this.lblMission.TabIndex = 0;
            this.lblMission.Text = "Mission n° ";
            // 
            // lblDeclenche
            // 
            this.lblDeclenche.AutoSize = true;
            this.lblDeclenche.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeclenche.Location = new System.Drawing.Point(529, 34);
            this.lblDeclenche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeclenche.Name = "lblDeclenche";
            this.lblDeclenche.Size = new System.Drawing.Size(149, 29);
            this.lblDeclenche.TabIndex = 1;
            this.lblDeclenche.Text = "déclenchée le : ";
            // 
            // grpInfosUsagers
            // 
            this.grpInfosUsagers.Controls.Add(this.txtVille);
            this.grpInfosUsagers.Controls.Add(this.txtRue);
            this.grpInfosUsagers.Controls.Add(this.txtCP);
            this.grpInfosUsagers.Controls.Add(this.label5);
            this.grpInfosUsagers.Controls.Add(this.label4);
            this.grpInfosUsagers.Controls.Add(this.label3);
            this.grpInfosUsagers.Controls.Add(this.label2);
            this.grpInfosUsagers.Controls.Add(this.label1);
            this.grpInfosUsagers.Controls.Add(this.rtbMotif);
            this.grpInfosUsagers.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosUsagers.Location = new System.Drawing.Point(69, 81);
            this.grpInfosUsagers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInfosUsagers.Name = "grpInfosUsagers";
            this.grpInfosUsagers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInfosUsagers.Size = new System.Drawing.Size(918, 197);
            this.grpInfosUsagers.TabIndex = 2;
            this.grpInfosUsagers.TabStop = false;
            this.grpInfosUsagers.Text = "Informations usagers";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(536, 140);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(350, 30);
            this.txtVille.TabIndex = 8;
            this.txtVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVille_KeyPress);
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(536, 71);
            this.txtRue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(350, 30);
            this.txtRue.TabIndex = 7;
            this.txtRue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRue_KeyPress);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(536, 105);
            this.txtCP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(152, 30);
            this.txtCP.TabIndex = 6;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Code postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse sinistre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motif";
            // 
            // rtbMotif
            // 
            this.rtbMotif.Location = new System.Drawing.Point(104, 62);
            this.rtbMotif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbMotif.Name = "rtbMotif";
            this.rtbMotif.Size = new System.Drawing.Size(220, 98);
            this.rtbMotif.TabIndex = 0;
            this.rtbMotif.Text = "";
            // 
            // grpDecisions
            // 
            this.grpDecisions.Controls.Add(this.btnEquipe);
            this.grpDecisions.Controls.Add(this.btnAnnuler);
            this.grpDecisions.Controls.Add(this.cboCaserne);
            this.grpDecisions.Controls.Add(this.lblCaserne);
            this.grpDecisions.Controls.Add(this.label6);
            this.grpDecisions.Controls.Add(this.cboNatureSinistre);
            this.grpDecisions.Location = new System.Drawing.Point(69, 288);
            this.grpDecisions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDecisions.Name = "grpDecisions";
            this.grpDecisions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDecisions.Size = new System.Drawing.Size(918, 154);
            this.grpDecisions.TabIndex = 3;
            this.grpDecisions.TabStop = false;
            this.grpDecisions.Text = "Décisions du régulateur";
            // 
            // btnEquipe
            // 
            this.btnEquipe.Location = new System.Drawing.Point(647, 75);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(192, 44);
            this.btnEquipe.TabIndex = 8;
            this.btnEquipe.Text = "Consistituer équipe";
            this.btnEquipe.UseVisualStyleBackColor = true;
            this.btnEquipe.Visible = false;
            this.btnEquipe.Click += new System.EventHandler(this.btnEquipe_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(405, 75);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(204, 44);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Effacer";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(583, 22);
            this.cboCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(200, 28);
            this.cboCaserne.TabIndex = 6;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(421, 26);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(154, 24);
            this.lblCaserne.TabIndex = 5;
            this.lblCaserne.Text = "Caserne à Mobiliser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nature du sinistre";
            // 
            // cboNatureSinistre
            // 
            this.cboNatureSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNatureSinistre.FormattingEnabled = true;
            this.cboNatureSinistre.Location = new System.Drawing.Point(188, 26);
            this.cboNatureSinistre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNatureSinistre.Name = "cboNatureSinistre";
            this.cboNatureSinistre.Size = new System.Drawing.Size(180, 28);
            this.cboNatureSinistre.TabIndex = 0;
            this.cboNatureSinistre.SelectedIndexChanged += new System.EventHandler(this.cboNatureSinistre_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(795, 671);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(192, 44);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Visible = false;
            // 
            // grpEnginsPompiers
            // 
            this.grpEnginsPompiers.Controls.Add(this.dgvPompiers);
            this.grpEnginsPompiers.Controls.Add(this.dgvEngins);
            this.grpEnginsPompiers.Location = new System.Drawing.Point(69, 450);
            this.grpEnginsPompiers.Name = "grpEnginsPompiers";
            this.grpEnginsPompiers.Size = new System.Drawing.Size(918, 206);
            this.grpEnginsPompiers.TabIndex = 10;
            this.grpEnginsPompiers.TabStop = false;
            this.grpEnginsPompiers.Text = "Mobilisation des engins et des pompiers";
            this.grpEnginsPompiers.Visible = false;
            // 
            // dgvPompiers
            // 
            this.dgvPompiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompiers.Location = new System.Drawing.Point(481, 25);
            this.dgvPompiers.Name = "dgvPompiers";
            this.dgvPompiers.RowHeadersWidth = 62;
            this.dgvPompiers.RowTemplate.Height = 28;
            this.dgvPompiers.Size = new System.Drawing.Size(290, 175);
            this.dgvPompiers.TabIndex = 12;
            // 
            // dgvEngins
            // 
            this.dgvEngins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngins.Location = new System.Drawing.Point(36, 25);
            this.dgvEngins.Name = "dgvEngins";
            this.dgvEngins.RowHeadersWidth = 62;
            this.dgvEngins.RowTemplate.Height = 28;
            this.dgvEngins.Size = new System.Drawing.Size(288, 175);
            this.dgvEngins.TabIndex = 0;
            // 
            // ucNouvelleMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.grpEnginsPompiers);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grpDecisions);
            this.Controls.Add(this.grpInfosUsagers);
            this.Controls.Add(this.lblDeclenche);
            this.Controls.Add(this.lblMission);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucNouvelleMission";
            this.Size = new System.Drawing.Size(1005, 728);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.grpInfosUsagers.ResumeLayout(false);
            this.grpInfosUsagers.PerformLayout();
            this.grpDecisions.ResumeLayout(false);
            this.grpDecisions.PerformLayout();
            this.grpEnginsPompiers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDeclenche;
        private System.Windows.Forms.GroupBox grpInfosUsagers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMotif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDecisions;
        private System.Windows.Forms.ComboBox cboNatureSinistre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox grpEnginsPompiers;
        private System.Windows.Forms.DataGridView dgvPompiers;
        private System.Windows.Forms.DataGridView dgvEngins;
    }
}
