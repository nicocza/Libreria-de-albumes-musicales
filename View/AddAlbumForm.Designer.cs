namespace View
{
    partial class AddAlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlbumForm));
            this.panelSideAdd = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblImageURL = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtSongs = new System.Windows.Forms.TextBox();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.pcbAddAlbum = new System.Windows.Forms.PictureBox();
            this.lblEdition = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.cboEdition = new System.Windows.Forms.ComboBox();
            this.panelSideAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideAdd
            // 
            this.panelSideAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideAdd.Controls.Add(this.lblEdition);
            this.panelSideAdd.Controls.Add(this.lblImageURL);
            this.panelSideAdd.Controls.Add(this.lblSongs);
            this.panelSideAdd.Controls.Add(this.lblGenre);
            this.panelSideAdd.Controls.Add(this.label3);
            this.panelSideAdd.Controls.Add(this.lblTitle);
            this.panelSideAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideAdd.Location = new System.Drawing.Point(0, 0);
            this.panelSideAdd.Name = "panelSideAdd";
            this.panelSideAdd.Size = new System.Drawing.Size(250, 421);
            this.panelSideAdd.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(31, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artist";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(31, 137);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(83, 27);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongs.ForeColor = System.Drawing.Color.White;
            this.lblSongs.Location = new System.Drawing.Point(31, 241);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(76, 27);
            this.lblSongs.TabIndex = 4;
            this.lblSongs.Text = "Songs";
            // 
            // lblImageURL
            // 
            this.lblImageURL.AutoSize = true;
            this.lblImageURL.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageURL.ForeColor = System.Drawing.Color.White;
            this.lblImageURL.Location = new System.Drawing.Point(31, 288);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(133, 27);
            this.lblImageURL.TabIndex = 5;
            this.lblImageURL.Text = "Image URL";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(272, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(216, 28);
            this.txtTitle.TabIndex = 2;
            // 
            // txtArtist
            // 
            this.txtArtist.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(272, 82);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(216, 28);
            this.txtArtist.TabIndex = 3;
            // 
            // txtSongs
            // 
            this.txtSongs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongs.Location = new System.Drawing.Point(272, 240);
            this.txtSongs.Name = "txtSongs";
            this.txtSongs.Size = new System.Drawing.Size(216, 28);
            this.txtSongs.TabIndex = 4;
            // 
            // txtImageURL
            // 
            this.txtImageURL.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageURL.Location = new System.Drawing.Point(272, 287);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(216, 28);
            this.txtImageURL.TabIndex = 5;
            this.txtImageURL.Leave += new System.EventHandler(this.txtImageURL_Leave);
            // 
            // pcbAddAlbum
            // 
            this.pcbAddAlbum.Location = new System.Drawing.Point(494, 35);
            this.pcbAddAlbum.Name = "pcbAddAlbum";
            this.pcbAddAlbum.Size = new System.Drawing.Size(249, 280);
            this.pcbAddAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAddAlbum.TabIndex = 6;
            this.pcbAddAlbum.TabStop = false;
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.Location = new System.Drawing.Point(31, 188);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(89, 27);
            this.lblEdition.TabIndex = 6;
            this.lblEdition.Text = "Edition";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(363, 353);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 41);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(494, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 41);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cboGenre
            // 
            this.cboGenre.BackColor = System.Drawing.Color.MidnightBlue;
            this.cboGenre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.ForeColor = System.Drawing.Color.White;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(272, 135);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(216, 29);
            this.cboGenre.TabIndex = 9;
            // 
            // cboEdition
            // 
            this.cboEdition.BackColor = System.Drawing.Color.MidnightBlue;
            this.cboEdition.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEdition.ForeColor = System.Drawing.Color.White;
            this.cboEdition.FormattingEnabled = true;
            this.cboEdition.Location = new System.Drawing.Point(272, 186);
            this.cboEdition.Name = "cboEdition";
            this.cboEdition.Size = new System.Drawing.Size(216, 29);
            this.cboEdition.TabIndex = 10;
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(755, 421);
            this.Controls.Add(this.cboEdition);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pcbAddAlbum);
            this.Controls.Add(this.txtImageURL);
            this.Controls.Add(this.txtSongs);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.panelSideAdd);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(773, 468);
            this.MinimumSize = new System.Drawing.Size(773, 468);
            this.Name = "AddAlbumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rhythm";
            this.Load += new System.EventHandler(this.AddAlbumForm_Load);
            this.panelSideAdd.ResumeLayout(false);
            this.panelSideAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblImageURL;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtSongs;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.PictureBox pcbAddAlbum;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.ComboBox cboEdition;
    }
}