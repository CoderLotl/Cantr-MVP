namespace Views
{
    partial class FrmLocationsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocationsManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddContinent = new System.Windows.Forms.Button();
            this.btn_AddLocation = new System.Windows.Forms.Button();
            this.tCtrl_General = new System.Windows.Forms.TabControl();
            this.tPg_Locations = new System.Windows.Forms.TabPage();
            this.dgv_Locations = new System.Windows.Forms.DataGridView();
            this.tPg_Continents = new System.Windows.Forms.TabPage();
            this.dgv_Continents = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tCtrl_General.SuspendLayout();
            this.tPg_Locations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Locations)).BeginInit();
            this.tPg_Continents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Continents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImage = global::Maro_MVP.Resources.aaf8c99e04d0a36f6aaaed0baf9183c6;
            this.groupBox1.Controls.Add(this.btn_AddContinent);
            this.groupBox1.Controls.Add(this.btn_AddLocation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 554);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btn_AddContinent
            // 
            this.btn_AddContinent.BackColor = System.Drawing.Color.Red;
            this.btn_AddContinent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddContinent.BackgroundImage")));
            this.btn_AddContinent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddContinent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AddContinent.FlatAppearance.BorderSize = 3;
            this.btn_AddContinent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddContinent.Location = new System.Drawing.Point(6, 99);
            this.btn_AddContinent.Name = "btn_AddContinent";
            this.btn_AddContinent.Size = new System.Drawing.Size(152, 44);
            this.btn_AddContinent.TabIndex = 2;
            this.btn_AddContinent.Text = "Add a new Continent";
            this.btn_AddContinent.UseVisualStyleBackColor = false;
            this.btn_AddContinent.Click += new System.EventHandler(this.btn_AddContinent_Click);
            // 
            // btn_AddLocation
            // 
            this.btn_AddLocation.BackColor = System.Drawing.Color.Red;
            this.btn_AddLocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddLocation.BackgroundImage")));
            this.btn_AddLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AddLocation.FlatAppearance.BorderSize = 3;
            this.btn_AddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLocation.Location = new System.Drawing.Point(6, 19);
            this.btn_AddLocation.Name = "btn_AddLocation";
            this.btn_AddLocation.Size = new System.Drawing.Size(152, 44);
            this.btn_AddLocation.TabIndex = 1;
            this.btn_AddLocation.Text = "Add a new Location";
            this.btn_AddLocation.UseVisualStyleBackColor = false;
            this.btn_AddLocation.Click += new System.EventHandler(this.btn_AddLocation_Click);
            // 
            // tCtrl_General
            // 
            this.tCtrl_General.Controls.Add(this.tPg_Locations);
            this.tCtrl_General.Controls.Add(this.tPg_Continents);
            this.tCtrl_General.Location = new System.Drawing.Point(182, 12);
            this.tCtrl_General.Name = "tCtrl_General";
            this.tCtrl_General.SelectedIndex = 0;
            this.tCtrl_General.Size = new System.Drawing.Size(966, 554);
            this.tCtrl_General.TabIndex = 9;
            // 
            // tPg_Locations
            // 
            this.tPg_Locations.BackColor = System.Drawing.Color.DimGray;
            this.tPg_Locations.Controls.Add(this.dgv_Locations);
            this.tPg_Locations.Location = new System.Drawing.Point(4, 22);
            this.tPg_Locations.Name = "tPg_Locations";
            this.tPg_Locations.Padding = new System.Windows.Forms.Padding(3);
            this.tPg_Locations.Size = new System.Drawing.Size(958, 528);
            this.tPg_Locations.TabIndex = 0;
            this.tPg_Locations.Text = "Locations";
            // 
            // dgv_Locations
            // 
            this.dgv_Locations.AllowUserToAddRows = false;
            this.dgv_Locations.AllowUserToDeleteRows = false;
            this.dgv_Locations.AllowUserToOrderColumns = true;
            this.dgv_Locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Locations.Location = new System.Drawing.Point(6, 35);
            this.dgv_Locations.Name = "dgv_Locations";
            this.dgv_Locations.Size = new System.Drawing.Size(946, 487);
            this.dgv_Locations.TabIndex = 0;
            this.dgv_Locations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Locations_CellContentClick);
            // 
            // tPg_Continents
            // 
            this.tPg_Continents.BackColor = System.Drawing.Color.DimGray;
            this.tPg_Continents.Controls.Add(this.dgv_Continents);
            this.tPg_Continents.Location = new System.Drawing.Point(4, 22);
            this.tPg_Continents.Name = "tPg_Continents";
            this.tPg_Continents.Padding = new System.Windows.Forms.Padding(3);
            this.tPg_Continents.Size = new System.Drawing.Size(958, 528);
            this.tPg_Continents.TabIndex = 1;
            this.tPg_Continents.Text = "Continents";
            // 
            // dgv_Continents
            // 
            this.dgv_Continents.AllowUserToAddRows = false;
            this.dgv_Continents.AllowUserToDeleteRows = false;
            this.dgv_Continents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Continents.Location = new System.Drawing.Point(6, 35);
            this.dgv_Continents.Name = "dgv_Continents";
            this.dgv_Continents.Size = new System.Drawing.Size(946, 487);
            this.dgv_Continents.TabIndex = 1;
            this.dgv_Continents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Continents_CellContentClick);
            // 
            // FrmLocationsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1180, 578);
            this.Controls.Add(this.tCtrl_General);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocationsManager";
            this.Text = "LocationsManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLocationsManager_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.tCtrl_General.ResumeLayout(false);
            this.tPg_Locations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Locations)).EndInit();
            this.tPg_Continents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Continents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tCtrl_General;
        private System.Windows.Forms.TabPage tPg_Locations;
        private System.Windows.Forms.TabPage tPg_Continents;
        private System.Windows.Forms.DataGridView dgv_Locations;
        private System.Windows.Forms.DataGridView dgv_Continents;
        private System.Windows.Forms.Button btn_AddLocation;
        private System.Windows.Forms.Button btn_AddContinent;
    }
}