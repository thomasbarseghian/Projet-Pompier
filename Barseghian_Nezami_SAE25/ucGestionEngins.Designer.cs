namespace Barseghian_Nezami_SAE25
{
    partial class ucGestionEngins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGestionEngins));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblEngin = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.lblState = new System.Windows.Forms.Label();
            this.pbEngin = new System.Windows.Forms.PictureBox();
            this.lblReception = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.btnDebutEngin = new System.Windows.Forms.Button();
            this.btnFinEngin = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.Coral;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(978, 73);
            this.pnlHeader.TabIndex = 2;
            this.pnlHeader.Resize += new System.EventHandler(this.pnlHeader_Resize);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblHeader.Location = new System.Drawing.Point(195, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(453, 55);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Gestion De Engins";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCaserne
            // 
            this.cboCaserne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboCaserne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaserne.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaserne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(406, 87);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(252, 30);
            this.cboCaserne.TabIndex = 3;
            this.cboCaserne.SelectionChangeCommitted += new System.EventHandler(this.cboCaserne_SelectionChangeCommitted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(201, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "Choisissez la Caserne";
            // 
            // lblEngin
            // 
            this.lblEngin.AutoSize = true;
            this.lblEngin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblEngin.Location = new System.Drawing.Point(217, 24);
            this.lblEngin.Name = "lblEngin";
            this.lblEngin.Size = new System.Drawing.Size(165, 28);
            this.lblEngin.TabIndex = 0;
            this.lblEngin.Text = "Engin 2 Sur 7";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPrevious.Location = new System.Drawing.Point(148, 75);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 35);
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Text = "← Précedent";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnNext.Location = new System.Drawing.Point(350, 75);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 35);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Suivant  →";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pbEngin);
            this.panel1.Controls.Add(this.lblReception);
            this.panel1.Controls.Add(this.lblCaserne);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(2, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 390);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pbStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(246, 270);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(183, 49);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(101, 3);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(40, 40);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 15;
            this.pbStatus.TabStop = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblState.Location = new System.Drawing.Point(3, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(92, 49);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "En Panne";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEngin
            // 
            this.pbEngin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEngin.Location = new System.Drawing.Point(460, 42);
            this.pbEngin.Name = "pbEngin";
            this.pbEngin.Size = new System.Drawing.Size(300, 300);
            this.pbEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEngin.TabIndex = 14;
            this.pbEngin.TabStop = false;
            // 
            // lblReception
            // 
            this.lblReception.AutoSize = true;
            this.lblReception.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblReception.Location = new System.Drawing.Point(251, 215);
            this.lblReception.Name = "lblReception";
            this.lblReception.Size = new System.Drawing.Size(61, 22);
            this.lblReception.TabIndex = 12;
            this.lblReception.Text = "label8";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblCaserne.Location = new System.Drawing.Point(251, 148);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(61, 22);
            this.lblCaserne.TabIndex = 11;
            this.lblCaserne.Text = "label7";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblCode.Location = new System.Drawing.Point(251, 75);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(61, 22);
            this.lblCode.TabIndex = 10;
            this.lblCode.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(78, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "ÉTAT ACTUAL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(78, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "RÉCEPTION :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(78, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "CASERNE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(78, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "C0DE : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 270);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblType.Location = new System.Drawing.Point(176, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(50, 22);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "BRS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TYPE D\'ENGIN :";
            // 
            // pnlLayout
            // 
            this.pnlLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLayout.Controls.Add(this.btnDebutEngin);
            this.pnlLayout.Controls.Add(this.btnFinEngin);
            this.pnlLayout.Controls.Add(this.panel1);
            this.pnlLayout.Controls.Add(this.btnNext);
            this.pnlLayout.Controls.Add(this.btnPrevious);
            this.pnlLayout.Controls.Add(this.lblEngin);
            this.pnlLayout.Location = new System.Drawing.Point(105, 120);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(811, 632);
            this.pnlLayout.TabIndex = 13;
            this.pnlLayout.Visible = false;
            // 
            // btnDebutEngin
            // 
            this.btnDebutEngin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebutEngin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnDebutEngin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebutEngin.FlatAppearance.BorderSize = 0;
            this.btnDebutEngin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDebutEngin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebutEngin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebutEngin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDebutEngin.Location = new System.Drawing.Point(75, 75);
            this.btnDebutEngin.Name = "btnDebutEngin";
            this.btnDebutEngin.Size = new System.Drawing.Size(54, 35);
            this.btnDebutEngin.TabIndex = 14;
            this.btnDebutEngin.Text = "<<";
            this.btnDebutEngin.UseVisualStyleBackColor = false;
            this.btnDebutEngin.Click += new System.EventHandler(this.btnDebutEngin_Click);
            // 
            // btnFinEngin
            // 
            this.btnFinEngin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnFinEngin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinEngin.FlatAppearance.BorderSize = 0;
            this.btnFinEngin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinEngin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinEngin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinEngin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnFinEngin.Location = new System.Drawing.Point(489, 75);
            this.btnFinEngin.Name = "btnFinEngin";
            this.btnFinEngin.Size = new System.Drawing.Size(54, 35);
            this.btnFinEngin.TabIndex = 13;
            this.btnFinEngin.Text = ">>";
            this.btnFinEngin.UseVisualStyleBackColor = false;
            this.btnFinEngin.Click += new System.EventHandler(this.btnFinEngin_Click);
            // 
            // ucGestionEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.cboCaserne);
            this.Controls.Add(this.label14);
            this.Name = "ucGestionEngins";
            this.Size = new System.Drawing.Size(978, 701);
            this.Load += new System.EventHandler(this.ucGestionEngins_Load);
            this.Resize += new System.EventHandler(this.ucGestionEngins_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblEngin;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReception;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Panel pnlLayout;
        private System.Windows.Forms.PictureBox pbEngin;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFinEngin;
        private System.Windows.Forms.Button btnDebutEngin;
    }
}
