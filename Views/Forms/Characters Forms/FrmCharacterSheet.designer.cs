namespace Views
{
	partial class FrmCharacterSheet
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtBox_Name;
		private System.Windows.Forms.RichTextBox rchTxtBox_Description;
		private System.Windows.Forms.GroupBox grpBox_Name;
		private System.Windows.Forms.GroupBox grpBox_Age;
		private System.Windows.Forms.TextBox txtBox_Age;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCharacterSheet));
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.rchTxtBox_Description = new System.Windows.Forms.RichTextBox();
            this.grpBox_Name = new System.Windows.Forms.GroupBox();
            this.grpBox_Age = new System.Windows.Forms.GroupBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.grpBox_Edit = new System.Windows.Forms.GroupBox();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.nud_Age = new System.Windows.Forms.NumericUpDown();
            this.grpBox_Gender = new System.Windows.Forms.GroupBox();
            this.cmbBox_Gender = new System.Windows.Forms.ComboBox();
            this.grpBox_Description = new System.Windows.Forms.GroupBox();
            this.btn_Underline = new System.Windows.Forms.Button();
            this.btn_Italic = new System.Windows.Forms.Button();
            this.btn_Bold = new System.Windows.Forms.Button();
            this.grpBox_Alive = new System.Windows.Forms.GroupBox();
            this.cmbBox_IsAlive = new System.Windows.Forms.ComboBox();
            this.lbl_Characer = new System.Windows.Forms.Label();
            this.grpBox_FamilyTies = new System.Windows.Forms.GroupBox();
            this.btn_AddNewNode = new System.Windows.Forms.Button();
            this.btn_RmvFamilyTie = new System.Windows.Forms.Button();
            this.tv_Family = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picBox_Banner = new System.Windows.Forms.PictureBox();
            this.picBox_Gender = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LoadPicture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DiscardPicture = new System.Windows.Forms.Button();
            this.grpBox_Birthday = new System.Windows.Forms.GroupBox();
            this.nud_Birthday = new System.Windows.Forms.NumericUpDown();
            this.txtBox_Birthday = new System.Windows.Forms.TextBox();
            this.grpBox_Deathday = new System.Windows.Forms.GroupBox();
            this.nud_Deathday = new System.Windows.Forms.NumericUpDown();
            this.txtBox_Deathday = new System.Windows.Forms.TextBox();
            this.grpBox_Language = new System.Windows.Forms.GroupBox();
            this.grpBox_SeenFirst = new System.Windows.Forms.GroupBox();
            this.cmbBox_Language = new System.Windows.Forms.ComboBox();
            this.cmbBox_Location = new System.Windows.Forms.ComboBox();
            this.grpBox_Name.SuspendLayout();
            this.grpBox_Age.SuspendLayout();
            this.grpBox_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).BeginInit();
            this.grpBox_Gender.SuspendLayout();
            this.grpBox_Description.SuspendLayout();
            this.grpBox_Alive.SuspendLayout();
            this.grpBox_FamilyTies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpBox_Birthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Birthday)).BeginInit();
            this.grpBox_Deathday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Deathday)).BeginInit();
            this.grpBox_Language.SuspendLayout();
            this.grpBox_SeenFirst.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Enabled = false;
            this.txtBox_Name.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(200, 26);
            this.txtBox_Name.TabIndex = 0;
            this.txtBox_Name.TextChanged += new System.EventHandler(this.txtBox_Name_TextChanged);
            // 
            // rchTxtBox_Description
            // 
            this.rchTxtBox_Description.BackColor = System.Drawing.Color.Wheat;
            this.rchTxtBox_Description.Enabled = false;
            this.rchTxtBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBox_Description.Location = new System.Drawing.Point(16, 48);
            this.rchTxtBox_Description.Name = "rchTxtBox_Description";
            this.rchTxtBox_Description.Size = new System.Drawing.Size(448, 346);
            this.rchTxtBox_Description.TabIndex = 1;
            this.rchTxtBox_Description.Text = "";
            this.rchTxtBox_Description.TextChanged += new System.EventHandler(this.rchTxtBox_Description_TextChanged);
            // 
            // grpBox_Name
            // 
            this.grpBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Name.Controls.Add(this.txtBox_Name);
            this.grpBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Name.Location = new System.Drawing.Point(104, 130);
            this.grpBox_Name.Name = "grpBox_Name";
            this.grpBox_Name.Size = new System.Drawing.Size(224, 64);
            this.grpBox_Name.TabIndex = 3;
            this.grpBox_Name.TabStop = false;
            this.grpBox_Name.Text = "Name";
            // 
            // grpBox_Age
            // 
            this.grpBox_Age.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Age.Controls.Add(this.txtBox_Age);
            this.grpBox_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Age.Location = new System.Drawing.Point(104, 200);
            this.grpBox_Age.Name = "grpBox_Age";
            this.grpBox_Age.Size = new System.Drawing.Size(72, 64);
            this.grpBox_Age.TabIndex = 4;
            this.grpBox_Age.TabStop = false;
            this.grpBox_Age.Text = "Age";
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Enabled = false;
            this.txtBox_Age.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.ReadOnly = true;
            this.txtBox_Age.Size = new System.Drawing.Size(48, 26);
            this.txtBox_Age.TabIndex = 0;
            // 
            // grpBox_Edit
            // 
            this.grpBox_Edit.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Edit.Controls.Add(this.btn_Undo);
            this.grpBox_Edit.Controls.Add(this.btn_Cancel);
            this.grpBox_Edit.Controls.Add(this.btn_Accept);
            this.grpBox_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Edit.Location = new System.Drawing.Point(994, 780);
            this.grpBox_Edit.Name = "grpBox_Edit";
            this.grpBox_Edit.Size = new System.Drawing.Size(222, 94);
            this.grpBox_Edit.TabIndex = 5;
            this.grpBox_Edit.TabStop = false;
            this.grpBox_Edit.Text = "Edit";
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Undo.BackgroundImage = global::Maro_MVP.Resources.undo_1_;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Undo.Location = new System.Drawing.Point(22, 19);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(60, 60);
            this.btn_Undo.TabIndex = 9;
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.Btn_Undo_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Black;
            this.btn_Cancel.BackgroundImage = global::Maro_MVP.Resources.reject1;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Location = new System.Drawing.Point(154, 19);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Accept.BackgroundImage = global::Maro_MVP.Resources.accept;
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Accept.Location = new System.Drawing.Point(86, 19);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(60, 60);
            this.btn_Accept.TabIndex = 7;
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.Btn_Accept_Click);
            // 
            // nud_Age
            // 
            this.nud_Age.Enabled = false;
            this.nud_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Age.Location = new System.Drawing.Point(182, 224);
            this.nud_Age.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_Age.Name = "nud_Age";
            this.nud_Age.Size = new System.Drawing.Size(44, 26);
            this.nud_Age.TabIndex = 6;
            this.nud_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Age.Visible = false;
            this.nud_Age.ValueChanged += new System.EventHandler(this.nud_Age_ValueChanged);
            // 
            // grpBox_Gender
            // 
            this.grpBox_Gender.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Gender.Controls.Add(this.cmbBox_Gender);
            this.grpBox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Gender.Location = new System.Drawing.Point(104, 270);
            this.grpBox_Gender.Name = "grpBox_Gender";
            this.grpBox_Gender.Size = new System.Drawing.Size(216, 64);
            this.grpBox_Gender.TabIndex = 9;
            this.grpBox_Gender.TabStop = false;
            this.grpBox_Gender.Text = "Gender";
            // 
            // cmbBox_Gender
            // 
            this.cmbBox_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Gender.Enabled = false;
            this.cmbBox_Gender.FormattingEnabled = true;
            this.cmbBox_Gender.Location = new System.Drawing.Point(8, 24);
            this.cmbBox_Gender.Name = "cmbBox_Gender";
            this.cmbBox_Gender.Size = new System.Drawing.Size(200, 28);
            this.cmbBox_Gender.TabIndex = 7;
            this.cmbBox_Gender.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Gender_SelectedIndexChanged);
            // 
            // grpBox_Description
            // 
            this.grpBox_Description.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Description.Controls.Add(this.btn_Underline);
            this.grpBox_Description.Controls.Add(this.btn_Italic);
            this.grpBox_Description.Controls.Add(this.btn_Bold);
            this.grpBox_Description.Controls.Add(this.rchTxtBox_Description);
            this.grpBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Description.Location = new System.Drawing.Point(80, 450);
            this.grpBox_Description.Name = "grpBox_Description";
            this.grpBox_Description.Size = new System.Drawing.Size(480, 400);
            this.grpBox_Description.TabIndex = 12;
            this.grpBox_Description.TabStop = false;
            this.grpBox_Description.Text = "Description and Notes";
            // 
            // btn_Underline
            // 
            this.btn_Underline.Enabled = false;
            this.btn_Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Underline.Location = new System.Drawing.Point(112, 24);
            this.btn_Underline.Name = "btn_Underline";
            this.btn_Underline.Size = new System.Drawing.Size(40, 23);
            this.btn_Underline.TabIndex = 4;
            this.btn_Underline.Text = "U";
            this.btn_Underline.UseVisualStyleBackColor = true;
            this.btn_Underline.Click += new System.EventHandler(this.Btn_UnderlineClick);
            // 
            // btn_Italic
            // 
            this.btn_Italic.Enabled = false;
            this.btn_Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Italic.Location = new System.Drawing.Point(64, 24);
            this.btn_Italic.Name = "btn_Italic";
            this.btn_Italic.Size = new System.Drawing.Size(40, 23);
            this.btn_Italic.TabIndex = 3;
            this.btn_Italic.Text = "I";
            this.btn_Italic.UseVisualStyleBackColor = true;
            this.btn_Italic.Click += new System.EventHandler(this.Btn_ItalicClick);
            // 
            // btn_Bold
            // 
            this.btn_Bold.Enabled = false;
            this.btn_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bold.Location = new System.Drawing.Point(16, 24);
            this.btn_Bold.Name = "btn_Bold";
            this.btn_Bold.Size = new System.Drawing.Size(40, 23);
            this.btn_Bold.TabIndex = 2;
            this.btn_Bold.Text = "B";
            this.btn_Bold.UseVisualStyleBackColor = true;
            this.btn_Bold.Click += new System.EventHandler(this.Btn_BoldClick);
            // 
            // grpBox_Alive
            // 
            this.grpBox_Alive.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Alive.Controls.Add(this.cmbBox_IsAlive);
            this.grpBox_Alive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Alive.Location = new System.Drawing.Point(232, 200);
            this.grpBox_Alive.Name = "grpBox_Alive";
            this.grpBox_Alive.Size = new System.Drawing.Size(88, 64);
            this.grpBox_Alive.TabIndex = 13;
            this.grpBox_Alive.TabStop = false;
            this.grpBox_Alive.Text = "Is alive?";
            // 
            // cmbBox_IsAlive
            // 
            this.cmbBox_IsAlive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_IsAlive.Enabled = false;
            this.cmbBox_IsAlive.FormattingEnabled = true;
            this.cmbBox_IsAlive.Location = new System.Drawing.Point(8, 24);
            this.cmbBox_IsAlive.Name = "cmbBox_IsAlive";
            this.cmbBox_IsAlive.Size = new System.Drawing.Size(72, 28);
            this.cmbBox_IsAlive.TabIndex = 7;
            this.cmbBox_IsAlive.SelectedIndexChanged += new System.EventHandler(this.CmbBox_IsAliveSelectedIndexChanged);
            // 
            // lbl_Characer
            // 
            this.lbl_Characer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Characer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Characer.Location = new System.Drawing.Point(104, 98);
            this.lbl_Characer.Name = "lbl_Characer";
            this.lbl_Characer.Size = new System.Drawing.Size(354, 32);
            this.lbl_Characer.TabIndex = 14;
            this.lbl_Characer.Text = "Character Sheet";
            // 
            // grpBox_FamilyTies
            // 
            this.grpBox_FamilyTies.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_FamilyTies.Controls.Add(this.btn_AddNewNode);
            this.grpBox_FamilyTies.Controls.Add(this.btn_RmvFamilyTie);
            this.grpBox_FamilyTies.Controls.Add(this.tv_Family);
            this.grpBox_FamilyTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_FamilyTies.Location = new System.Drawing.Point(736, 77);
            this.grpBox_FamilyTies.Name = "grpBox_FamilyTies";
            this.grpBox_FamilyTies.Size = new System.Drawing.Size(480, 432);
            this.grpBox_FamilyTies.TabIndex = 15;
            this.grpBox_FamilyTies.TabStop = false;
            this.grpBox_FamilyTies.Text = "Family Ties";
            // 
            // btn_AddNewNode
            // 
            this.btn_AddNewNode.Location = new System.Drawing.Point(375, 360);
            this.btn_AddNewNode.Name = "btn_AddNewNode";
            this.btn_AddNewNode.Size = new System.Drawing.Size(89, 30);
            this.btn_AddNewNode.TabIndex = 1;
            this.btn_AddNewNode.Text = "Add";
            this.btn_AddNewNode.UseVisualStyleBackColor = true;
            this.btn_AddNewNode.Click += new System.EventHandler(this.Btn_AddNewNode_Click);
            // 
            // btn_RmvFamilyTie
            // 
            this.btn_RmvFamilyTie.Enabled = false;
            this.btn_RmvFamilyTie.Location = new System.Drawing.Point(375, 396);
            this.btn_RmvFamilyTie.Name = "btn_RmvFamilyTie";
            this.btn_RmvFamilyTie.Size = new System.Drawing.Size(89, 30);
            this.btn_RmvFamilyTie.TabIndex = 1;
            this.btn_RmvFamilyTie.Text = "Remove";
            this.btn_RmvFamilyTie.UseVisualStyleBackColor = true;
            this.btn_RmvFamilyTie.Click += new System.EventHandler(this.btn_RmvFamilyTie_Click);
            // 
            // tv_Family
            // 
            this.tv_Family.BackColor = System.Drawing.Color.LightGray;
            this.tv_Family.Location = new System.Drawing.Point(16, 32);
            this.tv_Family.Name = "tv_Family";
            this.tv_Family.Size = new System.Drawing.Size(448, 280);
            this.tv_Family.TabIndex = 0;
            this.tv_Family.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tv_Family_NodeMouseHover);
            this.tv_Family.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Family_NodeMouseDoubleClick);
            // 
            // picBox_Banner
            // 
            this.picBox_Banner.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Banner.BackgroundImage = global::Maro_MVP.Resources.banner;
            this.picBox_Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Banner.Location = new System.Drawing.Point(574, 38);
            this.picBox_Banner.Name = "picBox_Banner";
            this.picBox_Banner.Size = new System.Drawing.Size(156, 529);
            this.picBox_Banner.TabIndex = 17;
            this.picBox_Banner.TabStop = false;
            // 
            // picBox_Gender
            // 
            this.picBox_Gender.BackColor = System.Drawing.Color.Gray;
            this.picBox_Gender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Gender.Location = new System.Drawing.Point(615, 159);
            this.picBox_Gender.Name = "picBox_Gender";
            this.picBox_Gender.Size = new System.Drawing.Size(70, 70);
            this.picBox_Gender.TabIndex = 19;
            this.picBox_Gender.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(38, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LoadPicture
            // 
            this.btn_LoadPicture.BackgroundImage = global::Maro_MVP.Resources.image_gallery;
            this.btn_LoadPicture.Location = new System.Drawing.Point(8, 30);
            this.btn_LoadPicture.Name = "btn_LoadPicture";
            this.btn_LoadPicture.Size = new System.Drawing.Size(23, 23);
            this.btn_LoadPicture.TabIndex = 25;
            this.btn_LoadPicture.UseVisualStyleBackColor = true;
            this.btn_LoadPicture.Click += new System.EventHandler(this.btn_LoadPictore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_DiscardPicture);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_LoadPicture);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(360, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Character Picture";
            // 
            // btn_DiscardPicture
            // 
            this.btn_DiscardPicture.BackgroundImage = global::Maro_MVP.Resources.trash_bin;
            this.btn_DiscardPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DiscardPicture.Location = new System.Drawing.Point(8, 59);
            this.btn_DiscardPicture.Name = "btn_DiscardPicture";
            this.btn_DiscardPicture.Size = new System.Drawing.Size(23, 23);
            this.btn_DiscardPicture.TabIndex = 26;
            this.btn_DiscardPicture.UseVisualStyleBackColor = true;
            this.btn_DiscardPicture.Click += new System.EventHandler(this.btn_DiscardPicture_Click);
            // 
            // grpBox_Birthday
            // 
            this.grpBox_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Birthday.Controls.Add(this.nud_Birthday);
            this.grpBox_Birthday.Controls.Add(this.txtBox_Birthday);
            this.grpBox_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Birthday.Location = new System.Drawing.Point(104, 340);
            this.grpBox_Birthday.Name = "grpBox_Birthday";
            this.grpBox_Birthday.Size = new System.Drawing.Size(169, 64);
            this.grpBox_Birthday.TabIndex = 27;
            this.grpBox_Birthday.TabStop = false;
            this.grpBox_Birthday.Text = "Birthday Day";
            // 
            // nud_Birthday
            // 
            this.nud_Birthday.Enabled = false;
            this.nud_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Birthday.Location = new System.Drawing.Point(95, 23);
            this.nud_Birthday.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Birthday.Name = "nud_Birthday";
            this.nud_Birthday.Size = new System.Drawing.Size(74, 26);
            this.nud_Birthday.TabIndex = 7;
            this.nud_Birthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Birthday.Visible = false;
            this.nud_Birthday.ValueChanged += new System.EventHandler(this.nud_Birthday_ValueChanged);
            // 
            // txtBox_Birthday
            // 
            this.txtBox_Birthday.Enabled = false;
            this.txtBox_Birthday.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Birthday.Name = "txtBox_Birthday";
            this.txtBox_Birthday.ReadOnly = true;
            this.txtBox_Birthday.Size = new System.Drawing.Size(74, 26);
            this.txtBox_Birthday.TabIndex = 0;
            // 
            // grpBox_Deathday
            // 
            this.grpBox_Deathday.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Deathday.Controls.Add(this.nud_Deathday);
            this.grpBox_Deathday.Controls.Add(this.txtBox_Deathday);
            this.grpBox_Deathday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Deathday.Location = new System.Drawing.Point(279, 340);
            this.grpBox_Deathday.Name = "grpBox_Deathday";
            this.grpBox_Deathday.Size = new System.Drawing.Size(169, 64);
            this.grpBox_Deathday.TabIndex = 28;
            this.grpBox_Deathday.TabStop = false;
            this.grpBox_Deathday.Text = "Deathday Day";
            // 
            // nud_Deathday
            // 
            this.nud_Deathday.Enabled = false;
            this.nud_Deathday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Deathday.Location = new System.Drawing.Point(89, 25);
            this.nud_Deathday.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Deathday.Name = "nud_Deathday";
            this.nud_Deathday.Size = new System.Drawing.Size(74, 26);
            this.nud_Deathday.TabIndex = 7;
            this.nud_Deathday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Deathday.Visible = false;
            this.nud_Deathday.ValueChanged += new System.EventHandler(this.nud_Deathday_ValueChanged);
            // 
            // txtBox_Deathday
            // 
            this.txtBox_Deathday.Enabled = false;
            this.txtBox_Deathday.Location = new System.Drawing.Point(8, 24);
            this.txtBox_Deathday.Name = "txtBox_Deathday";
            this.txtBox_Deathday.ReadOnly = true;
            this.txtBox_Deathday.Size = new System.Drawing.Size(74, 26);
            this.txtBox_Deathday.TabIndex = 0;
            // 
            // grpBox_Language
            // 
            this.grpBox_Language.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Language.Controls.Add(this.cmbBox_Language);
            this.grpBox_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Language.Location = new System.Drawing.Point(736, 515);
            this.grpBox_Language.Name = "grpBox_Language";
            this.grpBox_Language.Size = new System.Drawing.Size(480, 69);
            this.grpBox_Language.TabIndex = 29;
            this.grpBox_Language.TabStop = false;
            this.grpBox_Language.Text = "Language";
            // 
            // grpBox_SeenFirst
            // 
            this.grpBox_SeenFirst.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_SeenFirst.Controls.Add(this.cmbBox_Location);
            this.grpBox_SeenFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_SeenFirst.Location = new System.Drawing.Point(736, 599);
            this.grpBox_SeenFirst.Name = "grpBox_SeenFirst";
            this.grpBox_SeenFirst.Size = new System.Drawing.Size(480, 69);
            this.grpBox_SeenFirst.TabIndex = 30;
            this.grpBox_SeenFirst.TabStop = false;
            this.grpBox_SeenFirst.Text = "Seen first at";
            // 
            // cmbBox_Language
            // 
            this.cmbBox_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Language.Enabled = false;
            this.cmbBox_Language.FormattingEnabled = true;
            this.cmbBox_Language.Location = new System.Drawing.Point(6, 24);
            this.cmbBox_Language.Name = "cmbBox_Language";
            this.cmbBox_Language.Size = new System.Drawing.Size(200, 28);
            this.cmbBox_Language.TabIndex = 8;
            // 
            // cmbBox_Location
            // 
            this.cmbBox_Location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Location.Enabled = false;
            this.cmbBox_Location.FormattingEnabled = true;
            this.cmbBox_Location.Location = new System.Drawing.Point(6, 25);
            this.cmbBox_Location.Name = "cmbBox_Location";
            this.cmbBox_Location.Size = new System.Drawing.Size(200, 28);
            this.cmbBox_Location.TabIndex = 9;
            // 
            // FrmCharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Maro_MVP.Resources.paper_on_wood_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 994);
            this.Controls.Add(this.grpBox_SeenFirst);
            this.Controls.Add(this.grpBox_Language);
            this.Controls.Add(this.grpBox_Deathday);
            this.Controls.Add(this.grpBox_Birthday);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBox_Gender);
            this.Controls.Add(this.picBox_Banner);
            this.Controls.Add(this.grpBox_FamilyTies);
            this.Controls.Add(this.lbl_Characer);
            this.Controls.Add(this.grpBox_Alive);
            this.Controls.Add(this.grpBox_Description);
            this.Controls.Add(this.grpBox_Gender);
            this.Controls.Add(this.nud_Age);
            this.Controls.Add(this.grpBox_Edit);
            this.Controls.Add(this.grpBox_Age);
            this.Controls.Add(this.grpBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCharacterSheet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmViewCharFormClosing);
            this.Load += new System.EventHandler(this.FrmViewCharLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmViewCharKeyDown);
            this.grpBox_Name.ResumeLayout(false);
            this.grpBox_Name.PerformLayout();
            this.grpBox_Age.ResumeLayout(false);
            this.grpBox_Age.PerformLayout();
            this.grpBox_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Age)).EndInit();
            this.grpBox_Gender.ResumeLayout(false);
            this.grpBox_Description.ResumeLayout(false);
            this.grpBox_Alive.ResumeLayout(false);
            this.grpBox_FamilyTies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpBox_Birthday.ResumeLayout(false);
            this.grpBox_Birthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Birthday)).EndInit();
            this.grpBox_Deathday.ResumeLayout(false);
            this.grpBox_Deathday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Deathday)).EndInit();
            this.grpBox_Language.ResumeLayout(false);
            this.grpBox_SeenFirst.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private System.Windows.Forms.GroupBox grpBox_Edit;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.NumericUpDown nud_Age;
        private System.Windows.Forms.GroupBox grpBox_Gender;
        private System.Windows.Forms.ComboBox cmbBox_Gender;
        private System.Windows.Forms.GroupBox grpBox_Description;
        private System.Windows.Forms.GroupBox grpBox_Alive;
        private System.Windows.Forms.ComboBox cmbBox_IsAlive;
        private System.Windows.Forms.Button btn_Bold;
        private System.Windows.Forms.Button btn_Italic;
        private System.Windows.Forms.Button btn_Underline;
        private System.Windows.Forms.Label lbl_Characer;
        private System.Windows.Forms.GroupBox grpBox_FamilyTies;
        private System.Windows.Forms.TreeView tv_Family;
        private System.Windows.Forms.Button btn_RmvFamilyTie;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picBox_Banner;
        private System.Windows.Forms.PictureBox picBox_Gender;
		private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LoadPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_DiscardPicture;
        private System.Windows.Forms.Button btn_AddNewNode;
        private System.Windows.Forms.GroupBox grpBox_Birthday;
        private System.Windows.Forms.TextBox txtBox_Birthday;
        private System.Windows.Forms.NumericUpDown nud_Birthday;
        private System.Windows.Forms.GroupBox grpBox_Deathday;
        private System.Windows.Forms.NumericUpDown nud_Deathday;
        private System.Windows.Forms.TextBox txtBox_Deathday;
        private System.Windows.Forms.GroupBox grpBox_Language;
        private System.Windows.Forms.GroupBox grpBox_SeenFirst;
        private System.Windows.Forms.ComboBox cmbBox_Language;
        private System.Windows.Forms.ComboBox cmbBox_Location;
    }
}
