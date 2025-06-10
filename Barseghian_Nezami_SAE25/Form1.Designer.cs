using System.Drawing;

namespace Barseghian_Nezami_SAE25
{
    partial class mainLayout
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainLayout));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnGestionEngins = new System.Windows.Forms.Button();
            this.btnGestionPersonnel = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnNouvelleMission = new System.Windows.Forms.Button();
            this.btnTableauBord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMainLayout = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Controls.Add(this.panel1);
            this.pnlSideBar.Controls.Add(this.btnQuitter);
            this.pnlSideBar.Controls.Add(this.btnGestionEngins);
            this.pnlSideBar.Controls.Add(this.btnGestionPersonnel);
            this.pnlSideBar.Controls.Add(this.btnStatistiques);
            this.pnlSideBar.Controls.Add(this.btnNouvelleMission);
            this.pnlSideBar.Controls.Add(this.btnTableauBord);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(452, 1050);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(459, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 1158);
            this.panel1.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.AutoSize = true;
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuitter.Location = new System.Drawing.Point(0, 971);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(450, 77);
            this.btnQuitter.TabIndex = 11;
            this.btnQuitter.Text = "   Quitter";
            this.btnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnGestionEngins
            // 
            this.btnGestionEngins.AutoSize = true;
            this.btnGestionEngins.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionEngins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionEngins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionEngins.FlatAppearance.BorderSize = 0;
            this.btnGestionEngins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGestionEngins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGestionEngins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEngins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionEngins.ForeColor = System.Drawing.Color.White;
            this.btnGestionEngins.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGestionEngins.Location = new System.Drawing.Point(0, 406);
            this.btnGestionEngins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionEngins.Name = "btnGestionEngins";
            this.btnGestionEngins.Size = new System.Drawing.Size(520, 77);
            this.btnGestionEngins.TabIndex = 10;
            this.btnGestionEngins.Text = "   Gestion des Engins";
            this.btnGestionEngins.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionEngins.UseVisualStyleBackColor = false;
            this.btnGestionEngins.Click += new System.EventHandler(this.btnGestionEngins_Click);
            // 
            // btnGestionPersonnel
            // 
            this.btnGestionPersonnel.AutoSize = true;
            this.btnGestionPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.btnGestionPersonnel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGestionPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionPersonnel.FlatAppearance.BorderSize = 0;
            this.btnGestionPersonnel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGestionPersonnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGestionPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPersonnel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPersonnel.ForeColor = System.Drawing.Color.White;
            this.btnGestionPersonnel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGestionPersonnel.Location = new System.Drawing.Point(0, 514);
            this.btnGestionPersonnel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionPersonnel.Name = "btnGestionPersonnel";
            this.btnGestionPersonnel.Size = new System.Drawing.Size(586, 77);
            this.btnGestionPersonnel.TabIndex = 9;
            this.btnGestionPersonnel.Text = "   Ressources humaines";
            this.btnGestionPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionPersonnel.UseVisualStyleBackColor = false;
            this.btnGestionPersonnel.Click += new System.EventHandler(this.btnGestionPersonnel_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.AutoSize = true;
            this.btnStatistiques.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistiques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.FlatAppearance.BorderSize = 0;
            this.btnStatistiques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStatistiques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistiques.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiques.ForeColor = System.Drawing.Color.White;
            this.btnStatistiques.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStatistiques.Location = new System.Drawing.Point(0, 622);
            this.btnStatistiques.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(450, 77);
            this.btnStatistiques.TabIndex = 8;
            this.btnStatistiques.Text = "   Statistiques";
            this.btnStatistiques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistiques.UseVisualStyleBackColor = false;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnNouvelleMission
            // 
            this.btnNouvelleMission.AutoSize = true;
            this.btnNouvelleMission.BackColor = System.Drawing.Color.Transparent;
            this.btnNouvelleMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNouvelleMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNouvelleMission.FlatAppearance.BorderSize = 0;
            this.btnNouvelleMission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNouvelleMission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNouvelleMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNouvelleMission.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvelleMission.ForeColor = System.Drawing.Color.White;
            this.btnNouvelleMission.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNouvelleMission.Location = new System.Drawing.Point(0, 298);
            this.btnNouvelleMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNouvelleMission.Name = "btnNouvelleMission";
            this.btnNouvelleMission.Size = new System.Drawing.Size(466, 77);
            this.btnNouvelleMission.TabIndex = 7;
            this.btnNouvelleMission.Text = "   Nouvelle Mission";
            this.btnNouvelleMission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNouvelleMission.UseVisualStyleBackColor = false;
            this.btnNouvelleMission.Click += new System.EventHandler(this.btnNouvelleMission_Click);
            // 
            // btnTableauBord
            // 
            this.btnTableauBord.AutoSize = true;
            this.btnTableauBord.BackColor = System.Drawing.Color.Transparent;
            this.btnTableauBord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTableauBord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableauBord.FlatAppearance.BorderSize = 0;
            this.btnTableauBord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTableauBord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableauBord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauBord.ForeColor = System.Drawing.Color.White;
            this.btnTableauBord.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTableauBord.Location = new System.Drawing.Point(0, 198);
            this.btnTableauBord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTableauBord.Name = "btnTableauBord";
            this.btnTableauBord.Size = new System.Drawing.Size(456, 77);
            this.btnTableauBord.TabIndex = 6;
            this.btnTableauBord.Text = "   Tableau de bord";
            this.btnTableauBord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTableauBord.UseVisualStyleBackColor = false;
            this.btnTableauBord.Click += new System.EventHandler(this.btnTableauBord_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // pnlMainLayout
            // 
            this.pnlMainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainLayout.AutoScroll = true;
            this.pnlMainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(230)))));
            this.pnlMainLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainLayout.Controls.Add(this.label2);
            this.pnlMainLayout.Location = new System.Drawing.Point(453, 2);
            this.pnlMainLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMainLayout.Name = "pnlMainLayout";
            this.pnlMainLayout.Size = new System.Drawing.Size(1056, 1150);
            this.pnlMainLayout.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main Form Layout Panel";
            this.label2.Visible = false;
            // 
            // mainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1510, 1050);
            this.Controls.Add(this.pnlMainLayout);
            this.Controls.Add(this.pnlSideBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Âme Brûlée";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainLayout_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMainLayout.ResumeLayout(false);
            this.pnlMainLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button btnTableauBord;
        private System.Windows.Forms.Button btnGestionEngins;
        private System.Windows.Forms.Button btnGestionPersonnel;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnNouvelleMission;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMainLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
