namespace Views
{
    partial class FrmContinentSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContinentSheet));
            this.rchTxtBox_Description = new System.Windows.Forms.RichTextBox();
            this.grpBox_Information = new System.Windows.Forms.GroupBox();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.grpBox_Edit = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBox_Information.SuspendLayout();
            this.grpBox_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchTxtBox_Description
            // 
            this.rchTxtBox_Description.Location = new System.Drawing.Point(17, 124);
            this.rchTxtBox_Description.Name = "rchTxtBox_Description";
            this.rchTxtBox_Description.Size = new System.Drawing.Size(351, 136);
            this.rchTxtBox_Description.TabIndex = 1;
            this.rchTxtBox_Description.Text = "";
            this.rchTxtBox_Description.TextChanged += new System.EventHandler(this.rchTxtBox_Description_TextChanged);
            // 
            // grpBox_Information
            // 
            this.grpBox_Information.Controls.Add(this.label3);
            this.grpBox_Information.Controls.Add(this.label1);
            this.grpBox_Information.Controls.Add(this.txtBox_Name);
            this.grpBox_Information.Controls.Add(this.rchTxtBox_Description);
            this.grpBox_Information.Location = new System.Drawing.Point(12, 23);
            this.grpBox_Information.Name = "grpBox_Information";
            this.grpBox_Information.Size = new System.Drawing.Size(395, 266);
            this.grpBox_Information.TabIndex = 2;
            this.grpBox_Information.TabStop = false;
            this.grpBox_Information.Text = "Information";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(17, 34);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(351, 20);
            this.txtBox_Name.TabIndex = 2;
            this.txtBox_Name.TextChanged += new System.EventHandler(this.txtBox_Name_TextChanged);
            // 
            // grpBox_Edit
            // 
            this.grpBox_Edit.BackColor = System.Drawing.Color.Transparent;
            this.grpBox_Edit.Controls.Add(this.btn_Cancel);
            this.grpBox_Edit.Controls.Add(this.btn_Accept);
            this.grpBox_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_Edit.Location = new System.Drawing.Point(413, 195);
            this.grpBox_Edit.Name = "grpBox_Edit";
            this.grpBox_Edit.Size = new System.Drawing.Size(144, 94);
            this.grpBox_Edit.TabIndex = 8;
            this.grpBox_Edit.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Black;
            this.btn_Cancel.BackgroundImage = global::Maro_MVP.Resources.reject;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Location = new System.Drawing.Point(6, 21);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(60, 60);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_Accept.BackgroundImage = global::Maro_MVP.Resources.accept;
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Accept.Location = new System.Drawing.Point(78, 21);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(60, 60);
            this.btn_Accept.TabIndex = 7;
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Continent Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // FrmContinentSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 301);
            this.Controls.Add(this.grpBox_Edit);
            this.Controls.Add(this.grpBox_Information);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContinentSheet";
            this.Text = "Continent Sheet";
            this.grpBox_Information.ResumeLayout(false);
            this.grpBox_Information.PerformLayout();
            this.grpBox_Edit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchTxtBox_Description;
        private System.Windows.Forms.GroupBox grpBox_Information;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.GroupBox grpBox_Edit;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}