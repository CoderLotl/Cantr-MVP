namespace Maro_MVP.Views.Forms.Characters_Forms
{
    partial class FrmCharactersDataGridSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCharactersDataGridSelector));
            this.btn_SaveToHtml = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_SaveToHtml.Location = new System.Drawing.Point(13, 122);
            this.btn_SaveToHtml.Name = "btn_SaveToHtml";
            this.btn_SaveToHtml.Size = new System.Drawing.Size(152, 44);
            this.btn_SaveToHtml.TabIndex = 13;
            this.btn_SaveToHtml.Text = "Save";
            this.btn_SaveToHtml.UseVisualStyleBackColor = false;
            this.btn_SaveToHtml.Click += new System.EventHandler(this.btn_SaveToHtml_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(11, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1074, 529);
            this.dataGridView1.TabIndex = 14;
            // 
            // FrmCharactersDataGridSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1097, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SaveToHtml);
            this.Name = "FrmCharactersDataGridSelector";
            this.Text = "FrmCharactersDataGridSelector";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveToHtml;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}