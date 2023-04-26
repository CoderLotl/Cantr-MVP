namespace Views
{
    partial class FrmCharactersMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCharactersMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ViewMap = new System.Windows.Forms.Button();
            this.btn_ManageLocations = new System.Windows.Forms.Button();
            this.btn_CalcAgeAll = new System.Windows.Forms.Button();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_AddCharacter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpBox_Data = new System.Windows.Forms.GroupBox();
            this.lbl_LoadedValue = new System.Windows.Forms.Label();
            this.lbl_Loaded = new System.Windows.Forms.Label();
            this.lbl_CharactersCount = new System.Windows.Forms.Label();
            this.lbl_Characters = new System.Windows.Forms.Label();
            this.lbl_MaroDate = new System.Windows.Forms.Label();
            this.btn_SaveToHtmlSpecial = new System.Windows.Forms.Button();
            this.btn_NewDB = new System.Windows.Forms.Button();
            this.grpBox_Search = new System.Windows.Forms.GroupBox();
            this.rdb_Language = new System.Windows.Forms.RadioButton();
            this.rdb_Age = new System.Windows.Forms.RadioButton();
            this.rdb_Gender = new System.Windows.Forms.RadioButton();
            this.rdb_Name = new System.Windows.Forms.RadioButton();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_SaveToHtml = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpBox_Data.SuspendLayout();
            this.grpBox_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.BackgroundImage = global::Maro_MVP.Resources.aaf8c99e04d0a36f6aaaed0baf9183c6;
            this.groupBox1.Controls.Add(this.btn_ViewMap);
            this.groupBox1.Controls.Add(this.btn_ManageLocations);
            this.groupBox1.Controls.Add(this.btn_CalcAgeAll);
            this.groupBox1.Controls.Add(this.btn_ClearList);
            this.groupBox1.Controls.Add(this.btn_Load);
            this.groupBox1.Controls.Add(this.btn_AddCharacter);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 690);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btn_ViewMap
            // 
            this.btn_ViewMap.BackColor = System.Drawing.Color.Red;
            this.btn_ViewMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ViewMap.BackgroundImage")));
            this.btn_ViewMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ViewMap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ViewMap.FlatAppearance.BorderSize = 3;
            this.btn_ViewMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ViewMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewMap.Location = new System.Drawing.Point(6, 640);
            this.btn_ViewMap.Name = "btn_ViewMap";
            this.btn_ViewMap.Size = new System.Drawing.Size(152, 44);
            this.btn_ViewMap.TabIndex = 5;
            this.btn_ViewMap.Text = "View Cantr map";
            this.btn_ViewMap.UseVisualStyleBackColor = false;
            this.btn_ViewMap.Click += new System.EventHandler(this.btn_ViewMap_Click);
            // 
            // btn_ManageLocations
            // 
            this.btn_ManageLocations.BackColor = System.Drawing.Color.Red;
            this.btn_ManageLocations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ManageLocations.BackgroundImage")));
            this.btn_ManageLocations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ManageLocations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ManageLocations.FlatAppearance.BorderSize = 3;
            this.btn_ManageLocations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ManageLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageLocations.Location = new System.Drawing.Point(6, 139);
            this.btn_ManageLocations.Name = "btn_ManageLocations";
            this.btn_ManageLocations.Size = new System.Drawing.Size(152, 44);
            this.btn_ManageLocations.TabIndex = 4;
            this.btn_ManageLocations.Text = "Manage Locations";
            this.btn_ManageLocations.UseVisualStyleBackColor = false;
            this.btn_ManageLocations.Click += new System.EventHandler(this.btn_ManageLocations_Click);
            // 
            // btn_CalcAgeAll
            // 
            this.btn_CalcAgeAll.BackColor = System.Drawing.Color.Red;
            this.btn_CalcAgeAll.BackgroundImage = global::Maro_MVP.Resources.glossy_background_hd_wallpaper_wallpaper_preview;
            this.btn_CalcAgeAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CalcAgeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcAgeAll.Location = new System.Drawing.Point(6, 469);
            this.btn_CalcAgeAll.Name = "btn_CalcAgeAll";
            this.btn_CalcAgeAll.Size = new System.Drawing.Size(152, 44);
            this.btn_CalcAgeAll.TabIndex = 3;
            this.btn_CalcAgeAll.Text = "Auto-calc Characters Age";
            this.btn_CalcAgeAll.UseVisualStyleBackColor = false;
            this.btn_CalcAgeAll.Click += new System.EventHandler(this.Btn_CalcAgeAllClick);
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.BackColor = System.Drawing.Color.Red;
            this.btn_ClearList.BackgroundImage = global::Maro_MVP.Resources.images;
            this.btn_ClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ClearList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ClearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ClearList.Location = new System.Drawing.Point(6, 349);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(152, 48);
            this.btn_ClearList.TabIndex = 2;
            this.btn_ClearList.Text = "Clear List";
            this.btn_ClearList.UseVisualStyleBackColor = false;
            this.btn_ClearList.Click += new System.EventHandler(this.Btn_ClearListClick);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Red;
            this.btn_Load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Load.BackgroundImage")));
            this.btn_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Load.Location = new System.Drawing.Point(6, 237);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(152, 48);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load List";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.Btn_LoadClick);
            // 
            // btn_AddCharacter
            // 
            this.btn_AddCharacter.BackColor = System.Drawing.Color.Red;
            this.btn_AddCharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddCharacter.BackgroundImage")));
            this.btn_AddCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddCharacter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_AddCharacter.FlatAppearance.BorderSize = 3;
            this.btn_AddCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCharacter.Location = new System.Drawing.Point(6, 89);
            this.btn_AddCharacter.Name = "btn_AddCharacter";
            this.btn_AddCharacter.Size = new System.Drawing.Size(152, 44);
            this.btn_AddCharacter.TabIndex = 0;
            this.btn_AddCharacter.Text = "Add a new Character";
            this.btn_AddCharacter.UseVisualStyleBackColor = false;
            this.btn_AddCharacter.Click += new System.EventHandler(this.btn_AddCharacter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(196, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 545);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
            // 
            // grpBox_Data
            // 
            this.grpBox_Data.Controls.Add(this.lbl_LoadedValue);
            this.grpBox_Data.Controls.Add(this.lbl_Loaded);
            this.grpBox_Data.Controls.Add(this.lbl_CharactersCount);
            this.grpBox_Data.Controls.Add(this.lbl_Characters);
            this.grpBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Data.Location = new System.Drawing.Point(205, 12);
            this.grpBox_Data.Name = "grpBox_Data";
            this.grpBox_Data.Size = new System.Drawing.Size(499, 100);
            this.grpBox_Data.TabIndex = 9;
            this.grpBox_Data.TabStop = false;
            // 
            // lbl_LoadedValue
            // 
            this.lbl_LoadedValue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_LoadedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LoadedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoadedValue.Location = new System.Drawing.Point(112, 62);
            this.lbl_LoadedValue.Name = "lbl_LoadedValue";
            this.lbl_LoadedValue.Size = new System.Drawing.Size(100, 23);
            this.lbl_LoadedValue.TabIndex = 3;
            this.lbl_LoadedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_LoadedValue.Visible = false;
            // 
            // lbl_Loaded
            // 
            this.lbl_Loaded.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Loaded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Loaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Loaded.Location = new System.Drawing.Point(6, 62);
            this.lbl_Loaded.Name = "lbl_Loaded";
            this.lbl_Loaded.Size = new System.Drawing.Size(100, 23);
            this.lbl_Loaded.TabIndex = 2;
            this.lbl_Loaded.Text = "Loaded File:";
            this.lbl_Loaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Loaded.Visible = false;
            // 
            // lbl_CharactersCount
            // 
            this.lbl_CharactersCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_CharactersCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CharactersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CharactersCount.Location = new System.Drawing.Point(249, 25);
            this.lbl_CharactersCount.Name = "lbl_CharactersCount";
            this.lbl_CharactersCount.Size = new System.Drawing.Size(100, 23);
            this.lbl_CharactersCount.TabIndex = 1;
            this.lbl_CharactersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Characters
            // 
            this.lbl_Characters.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Characters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Characters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Characters.Location = new System.Drawing.Point(6, 25);
            this.lbl_Characters.Name = "lbl_Characters";
            this.lbl_Characters.Size = new System.Drawing.Size(237, 23);
            this.lbl_Characters.TabIndex = 0;
            this.lbl_Characters.Text = "My Characters Count:";
            this.lbl_Characters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_MaroDate
            // 
            this.lbl_MaroDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MaroDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MaroDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaroDate.Location = new System.Drawing.Point(723, 34);
            this.lbl_MaroDate.Name = "lbl_MaroDate";
            this.lbl_MaroDate.Size = new System.Drawing.Size(499, 23);
            this.lbl_MaroDate.TabIndex = 11;
            this.lbl_MaroDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SaveToHtmlSpecial
            // 
            this.btn_SaveToHtmlSpecial.BackColor = System.Drawing.Color.Red;
            this.btn_SaveToHtmlSpecial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SaveToHtmlSpecial.BackgroundImage")));
            this.btn_SaveToHtmlSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SaveToHtmlSpecial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SaveToHtmlSpecial.FlatAppearance.BorderSize = 3;
            this.btn_SaveToHtmlSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SaveToHtmlSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveToHtmlSpecial.Location = new System.Drawing.Point(354, 128);
            this.btn_SaveToHtmlSpecial.Name = "btn_SaveToHtmlSpecial";
            this.btn_SaveToHtmlSpecial.Size = new System.Drawing.Size(152, 44);
            this.btn_SaveToHtmlSpecial.TabIndex = 12;
            this.btn_SaveToHtmlSpecial.Text = "Save To Html With Selection";
            this.btn_SaveToHtmlSpecial.UseVisualStyleBackColor = false;
            this.btn_SaveToHtmlSpecial.Click += new System.EventHandler(this.btn_SaveToHtmlSpecial_Click);
            // 
            // btn_NewDB
            // 
            this.btn_NewDB.BackColor = System.Drawing.Color.Red;
            this.btn_NewDB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NewDB.BackgroundImage")));
            this.btn_NewDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NewDB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_NewDB.FlatAppearance.BorderSize = 3;
            this.btn_NewDB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NewDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewDB.Location = new System.Drawing.Point(196, 128);
            this.btn_NewDB.Name = "btn_NewDB";
            this.btn_NewDB.Size = new System.Drawing.Size(152, 44);
            this.btn_NewDB.TabIndex = 13;
            this.btn_NewDB.Text = "New DataBase";
            this.btn_NewDB.UseVisualStyleBackColor = false;
            this.btn_NewDB.Click += new System.EventHandler(this.btn_NewDB_Click);
            // 
            // grpBox_Search
            // 
            this.grpBox_Search.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.grpBox_Search.Controls.Add(this.rdb_Language);
            this.grpBox_Search.Controls.Add(this.rdb_Age);
            this.grpBox_Search.Controls.Add(this.rdb_Gender);
            this.grpBox_Search.Controls.Add(this.rdb_Name);
            this.grpBox_Search.Controls.Add(this.txtBox_Search);
            this.grpBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpBox_Search.Location = new System.Drawing.Point(723, 65);
            this.grpBox_Search.Name = "grpBox_Search";
            this.grpBox_Search.Size = new System.Drawing.Size(631, 107);
            this.grpBox_Search.TabIndex = 14;
            this.grpBox_Search.TabStop = false;
            this.grpBox_Search.Text = "Search";
            // 
            // rdb_Language
            // 
            this.rdb_Language.AutoSize = true;
            this.rdb_Language.Location = new System.Drawing.Point(219, 47);
            this.rdb_Language.Name = "rdb_Language";
            this.rdb_Language.Size = new System.Drawing.Size(94, 20);
            this.rdb_Language.TabIndex = 4;
            this.rdb_Language.TabStop = true;
            this.rdb_Language.Text = "Language";
            this.rdb_Language.UseVisualStyleBackColor = true;
            // 
            // rdb_Age
            // 
            this.rdb_Age.AutoSize = true;
            this.rdb_Age.Location = new System.Drawing.Point(160, 47);
            this.rdb_Age.Name = "rdb_Age";
            this.rdb_Age.Size = new System.Drawing.Size(53, 20);
            this.rdb_Age.TabIndex = 3;
            this.rdb_Age.TabStop = true;
            this.rdb_Age.Text = "Age";
            this.rdb_Age.UseVisualStyleBackColor = true;
            // 
            // rdb_Gender
            // 
            this.rdb_Gender.AutoSize = true;
            this.rdb_Gender.Location = new System.Drawing.Point(78, 47);
            this.rdb_Gender.Name = "rdb_Gender";
            this.rdb_Gender.Size = new System.Drawing.Size(76, 20);
            this.rdb_Gender.TabIndex = 2;
            this.rdb_Gender.TabStop = true;
            this.rdb_Gender.Text = "Gender";
            this.rdb_Gender.UseVisualStyleBackColor = true;
            // 
            // rdb_Name
            // 
            this.rdb_Name.AutoSize = true;
            this.rdb_Name.Checked = true;
            this.rdb_Name.Location = new System.Drawing.Point(6, 47);
            this.rdb_Name.Name = "rdb_Name";
            this.rdb_Name.Size = new System.Drawing.Size(66, 20);
            this.rdb_Name.TabIndex = 1;
            this.rdb_Name.TabStop = true;
            this.rdb_Name.Text = "Name";
            this.rdb_Name.UseVisualStyleBackColor = true;
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(6, 19);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(309, 22);
            this.txtBox_Search.TabIndex = 0;
            this.txtBox_Search.TextChanged += new System.EventHandler(this.txtBox_Search_TextChanged);
            // 
            // btn_SaveToHtml
            // 
            this.btn_SaveToHtml.BackColor = System.Drawing.Color.Red;
            this.btn_SaveToHtml.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SaveToHtml.BackgroundImage")));
            this.btn_SaveToHtml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SaveToHtml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_SaveToHtml.FlatAppearance.BorderSize = 3;
            this.btn_SaveToHtml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SaveToHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveToHtml.Location = new System.Drawing.Point(512, 128);
            this.btn_SaveToHtml.Name = "btn_SaveToHtml";
            this.btn_SaveToHtml.Size = new System.Drawing.Size(152, 44);
            this.btn_SaveToHtml.TabIndex = 15;
            this.btn_SaveToHtml.Text = "Save To Html";
            this.btn_SaveToHtml.UseVisualStyleBackColor = false;
            this.btn_SaveToHtml.Click += new System.EventHandler(this.btn_SaveToHtml_Click);
            // 
            // FrmCharactersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1366, 746);
            this.Controls.Add(this.btn_SaveToHtml);
            this.Controls.Add(this.grpBox_Search);
            this.Controls.Add(this.btn_NewDB);
            this.Controls.Add(this.btn_SaveToHtmlSpecial);
            this.Controls.Add(this.lbl_MaroDate);
            this.Controls.Add(this.grpBox_Data);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCharactersMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Characters Main";
            this.Load += new System.EventHandler(this.FrmCharactersMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCharactersMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpBox_Data.ResumeLayout(false);
            this.grpBox_Search.ResumeLayout(false);
            this.grpBox_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddCharacter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpBox_Data;
        private System.Windows.Forms.Label lbl_LoadedValue;
        private System.Windows.Forms.Label lbl_Loaded;
        private System.Windows.Forms.Label lbl_CharactersCount;
        private System.Windows.Forms.Label lbl_Characters;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_ClearList;
        private System.Windows.Forms.Label lbl_MaroDate;
        private System.Windows.Forms.Button btn_CalcAgeAll;
        private System.Windows.Forms.Button btn_ManageLocations;
        private System.Windows.Forms.Button btn_SaveToHtmlSpecial;
        private System.Windows.Forms.Button btn_NewDB;
        private System.Windows.Forms.Button btn_ViewMap;
        private System.Windows.Forms.GroupBox grpBox_Search;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.RadioButton rdb_Name;
        private System.Windows.Forms.RadioButton rdb_Gender;
        private System.Windows.Forms.RadioButton rdb_Age;
        private System.Windows.Forms.RadioButton rdb_Language;
        private System.Windows.Forms.Button btn_SaveToHtml;
    }
}