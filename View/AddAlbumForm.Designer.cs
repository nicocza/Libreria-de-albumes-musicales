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
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblImageURL = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtSongs = new System.Windows.Forms.TextBox();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.pcbAddAlbum = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.cboEdition = new System.Windows.Forms.ComboBox();
            this.lblTitleEmpty = new System.Windows.Forms.Label();
            this.lblArtistEmpty = new System.Windows.Forms.Label();
            this.lblSongsEmpty = new System.Windows.Forms.Label();
            this.panelSideAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideAdd
            // 
            this.panelSideAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(12)))), ((int)(((byte)(24)))));
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
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.Location = new System.Drawing.Point(51, 207);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(89, 27);
            this.lblEdition.TabIndex = 6;
            this.lblEdition.Text = "Edition";
            // 
            // lblImageURL
            // 
            this.lblImageURL.AutoSize = true;
            this.lblImageURL.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageURL.ForeColor = System.Drawing.Color.White;
            this.lblImageURL.Location = new System.Drawing.Point(51, 300);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(133, 27);
            this.lblImageURL.TabIndex = 5;
            this.lblImageURL.Text = "Image URL";
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongs.ForeColor = System.Drawing.Color.White;
            this.lblSongs.Location = new System.Drawing.Point(51, 258);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(76, 27);
            this.lblSongs.TabIndex = 4;
            this.lblSongs.Text = "Songs";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(51, 152);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(83, 27);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artist";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(51, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(272, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(216, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // txtArtist
            // 
            this.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtist.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(272, 100);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(216, 23);
            this.txtArtist.TabIndex = 1;
            // 
            // txtSongs
            // 
            this.txtSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSongs.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongs.Location = new System.Drawing.Point(272, 262);
            this.txtSongs.Name = "txtSongs";
            this.txtSongs.Size = new System.Drawing.Size(216, 23);
            this.txtSongs.TabIndex = 4;
            // 
            // txtImageURL
            // 
            this.txtImageURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageURL.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageURL.Location = new System.Drawing.Point(272, 305);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(216, 23);
            this.txtImageURL.TabIndex = 5;
            this.txtImageURL.Leave += new System.EventHandler(this.txtImageURL_Leave);
            // 
            // pcbAddAlbum
            // 
            this.pcbAddAlbum.Location = new System.Drawing.Point(494, 57);
            this.pcbAddAlbum.Name = "pcbAddAlbum";
            this.pcbAddAlbum.Size = new System.Drawing.Size(249, 270);
            this.pcbAddAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAddAlbum.TabIndex = 6;
            this.pcbAddAlbum.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(363, 353);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 41);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(494, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 41);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGenre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.ForeColor = System.Drawing.Color.White;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(272, 156);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(216, 28);
            this.cboGenre.TabIndex = 2;
            // 
            // cboEdition
            // 
            this.cboEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(35)))));
            this.cboEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEdition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEdition.ForeColor = System.Drawing.Color.White;
            this.cboEdition.FormattingEnabled = true;
            this.cboEdition.Location = new System.Drawing.Point(272, 206);
            this.cboEdition.Name = "cboEdition";
            this.cboEdition.Size = new System.Drawing.Size(216, 28);
            this.cboEdition.TabIndex = 3;
            // 
            // lblTitleEmpty
            // 
            this.lblTitleEmpty.AutoSize = true;
            this.lblTitleEmpty.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblTitleEmpty.Location = new System.Drawing.Point(334, 80);
            this.lblTitleEmpty.Name = "lblTitleEmpty";
            this.lblTitleEmpty.Size = new System.Drawing.Size(0, 17);
            this.lblTitleEmpty.TabIndex = 11;
            // 
            // lblArtistEmpty
            // 
            this.lblArtistEmpty.AutoSize = true;
            this.lblArtistEmpty.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblArtistEmpty.Location = new System.Drawing.Point(334, 122);
            this.lblArtistEmpty.Name = "lblArtistEmpty";
            this.lblArtistEmpty.Size = new System.Drawing.Size(0, 17);
            this.lblArtistEmpty.TabIndex = 12;
            // 
            // lblSongsEmpty
            // 
            this.lblSongsEmpty.AutoSize = true;
            this.lblSongsEmpty.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongsEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblSongsEmpty.Location = new System.Drawing.Point(301, 285);
            this.lblSongsEmpty.Name = "lblSongsEmpty";
            this.lblSongsEmpty.Size = new System.Drawing.Size(0, 17);
            this.lblSongsEmpty.TabIndex = 13;
            // 
            // AddAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(755, 421);
            this.Controls.Add(this.lblSongsEmpty);
            this.Controls.Add(this.lblArtistEmpty);
            this.Controls.Add(this.lblTitleEmpty);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label lblTitleEmpty;
        private System.Windows.Forms.Label lblArtistEmpty;
        private System.Windows.Forms.Label lblSongsEmpty;
    }
}