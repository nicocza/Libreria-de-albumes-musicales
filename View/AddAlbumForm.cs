using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Control;
using Model;

namespace View
{
    public partial class AddAlbumForm : Form
    {
        private Album album = null;

        public AddAlbumForm()
        {
            InitializeComponent();
        }

        public AddAlbumForm(Album album)
        {
            InitializeComponent();
            this.album = album;
            Text = "Modify your album";
        }

        private void AddAlbumForm_Load(object sender, EventArgs e)
        {
            GenreEditionBusiness business = new GenreEditionBusiness();

            try
            {
                cboGenre.DataSource = business.genres();
                cboGenre.ValueMember = "Id";
                cboGenre.DisplayMember = "Description";
                cboEdition.DataSource = business.Editions();
                cboEdition.ValueMember = "Id";
                cboEdition.DisplayMember = "Description";

                if(album != null)
                {
                    txtTitle.Text = album.Title;
                    txtArtist.Text = album.Artist;
                    cboGenre.SelectedValue = album.Genre.Id;
                    cboEdition.SelectedValue = album.Edition.Id;
                    txtSongs.Text = album.Songs.ToString();
                    txtImageURL.Text = album.ImageURL;
                    LoadImage(album.ImageURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadImage(string image)
        {
            try
            {
                pcbAddAlbum.Load(image);
            }
            catch (Exception ex)
            {
                pcbAddAlbum.Load("https://www.afim.com.eg/public/images/no-photo.png");
            }
        }

        private void txtImageURL_Leave(object sender, EventArgs e)
        {
            LoadImage(txtImageURL.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AlbumBusiness business = new AlbumBusiness();

            try
            {
                if(ValidateText())
                {
                    if(album == null)
                        album = new Album();

                    album.Title = txtTitle.Text;
                    album.Artist = txtArtist.Text;
                    album.Genre = (Genre)cboGenre.SelectedItem;
                    album.Edition = (Edition)cboEdition.SelectedItem;
                    album.Songs = int.Parse(txtSongs.Text);
                    album.ImageURL = txtImageURL.Text;

                    if(album.Id != 0)
                    {
                        business.Modify(album);
                        MessageBox.Show("Successfully modified");
                    }
                    else
                    {
                        business.Add(album);
                        MessageBox.Show("Successfully added");
                    }
                    Close();
                }     
                else
                {
                    if (!string.IsNullOrWhiteSpace(lblTitleEmpty.Text))
                        txtTitle.Focus();
                    else if(!string.IsNullOrWhiteSpace(lblArtistEmpty.Text))
                        txtArtist.Focus();
                    else if(!string.IsNullOrWhiteSpace(lblSongsEmpty.Text))
                        txtSongs.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool ValidateText()
        {
            bool valid = true;

            lblTitleEmpty.Text = "";
            lblArtistEmpty.Text = "";
            lblSongsEmpty.Text = "";

            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lblTitleEmpty.Text = "this is empty";
                valid = false;
            }
            if(string.IsNullOrEmpty(txtArtist.Text))
            {
                lblArtistEmpty.Text = "this is empty";
                valid = false;
            }
            if (string.IsNullOrEmpty(txtSongs.Text) || !int.TryParse(txtSongs.Text, out _))
            {
                lblSongsEmpty.Text = "only numbers please";
                valid = false;
            }
            return valid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
