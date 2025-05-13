using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace View
{
    public partial class AddAlbumForm : Form
    {
        private Album album = null;

        private OpenFileDialog archive = null;

        public AddAlbumForm()
        {
            InitializeComponent();
        }

        public AddAlbumForm(Album album)
        {
            InitializeComponent();
            this.album = album;
            Text = "Edit your album";
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
                    txtSongs.Text = album.Songs;
                    txtImageURL.Text = album.ImageURL;
                    LoadImage(album.ImageURL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoadImage(string imagen)
        {
            try
            {
                pcbAddAlbum.Load(imagen);
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
            GenreEditionBusiness business = new GenreEditionBusiness();

            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
