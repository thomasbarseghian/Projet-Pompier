namespace Barseghian_Nezami_SAE25
{
    partial class ucDashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlChoisirGrade = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFiltre = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tlpMissions = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlChoisirGrade.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.pnlHeader.Controls.Add(this.pnlChoisirGrade);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.Coral;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(771, 73);
            this.pnlHeader.TabIndex = 3;
            this.pnlHeader.Resize += new System.EventHandler(this.pnlHeader_Resize);
            // 
            // pnlChoisirGrade
            // 
            this.pnlChoisirGrade.AutoSize = true;
            this.pnlChoisirGrade.BackColor = System.Drawing.Color.Transparent;
            this.pnlChoisirGrade.Controls.Add(this.label9);
            this.pnlChoisirGrade.Controls.Add(this.cboFiltre);
            this.pnlChoisirGrade.Location = new System.Drawing.Point(3, 35);
            this.pnlChoisirGrade.Name = "pnlChoisirGrade";
            this.pnlChoisirGrade.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnlChoisirGrade.Size = new System.Drawing.Size(201, 38);
            this.pnlChoisirGrade.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Filtre";
            // 
            // cboFiltre
            // 
            this.cboFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cboFiltre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboFiltre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cboFiltre.FormattingEnabled = true;
            this.cboFiltre.Items.AddRange(new object[] {
            "Toutes",
            "En cours",
            "Terminées"});
            this.cboFiltre.Location = new System.Drawing.Point(47, 0);
            this.cboFiltre.Name = "cboFiltre";
            this.cboFiltre.Size = new System.Drawing.Size(149, 30);
            this.cboFiltre.TabIndex = 8;
            this.cboFiltre.SelectionChangeCommitted += new System.EventHandler(this.cboGrade_SelectionChangeCommitted);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblHeader.Location = new System.Drawing.Point(195, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(406, 55);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tableau de bord";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpMissions
            // 
            this.tlpMissions.AutoSize = true;
            this.tlpMissions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMissions.ColumnCount = 2;
            this.tlpMissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMissions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMissions.Location = new System.Drawing.Point(0, 0);
            this.tlpMissions.Name = "tlpMissions";
            this.tlpMissions.RowCount = 1;
            this.tlpMissions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMissions.Size = new System.Drawing.Size(771, 0);
            this.tlpMissions.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tlpMissions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 599);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 19);
            this.panel2.TabIndex = 6;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(771, 697);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlChoisirGrade.ResumeLayout(false);
            this.pnlChoisirGrade.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tlpMissions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlChoisirGrade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFiltre;
        private System.Windows.Forms.Panel panel2;
    }
}

