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

    public partial class MainForm : Form
    {
        private List<Album> albumList;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadWindow();
        }

        private void LoadWindow()
        {
            AlbumBusiness business = new AlbumBusiness();

            try
            {
                albumList = business.AlbumList();
                dgvAlbums.DataSource = albumList;
                HideColumns();
                LoadImage(albumList[0].ImageURL);
                
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
                pcbAlbums.Load(image);
                pcbLogo.Load("https://narcmagazine.com/wp-content/uploads/2023/04/Interview-Rhythms-1024x768-1.jpeg");
                pcbTop.Load("https://rythm.com/wp-content/themes/rythm/assets/images/rythm-wave-primary.png");
            }
            catch (Exception)
            {
                pcbAlbums.Load("https://www.afim.com.eg/public/images/no-photo.png");
            }
        }

        private void HideColumns()
        {
            dgvAlbums.Columns["Id"].Visible = false;
            dgvAlbums.Columns["ImageURL"].Visible = false;
        }

        private void CustomizeDesign()
        {
            panelSubMenu.Visible = false;
        }

        private void HideSubMenu()
        {
            if(panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenu);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadWindow();
        }

        private void dgvAlbums_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvAlbums.CurrentRow != null)
            {
                Album selected = (Album)dgvAlbums.CurrentRow.DataBoundItem;
                LoadImage(selected.ImageURL);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAlbumForm open = new AddAlbumForm();
            open.ShowDialog();
            LoadWindow();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvAlbums.CurrentRow == null)
            {
                MessageBox.Show("There is no album selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Album selected;
            selected = (Album)dgvAlbums.CurrentRow.DataBoundItem;
            AddAlbumForm Modify = new AddAlbumForm(selected);
            Modify.ShowDialog();
            LoadWindow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvAlbums.CurrentRow == null)
            {
                MessageBox.Show("There is no album selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Delete();
        }

        private void Delete()
        {
            AlbumBusiness business = new AlbumBusiness();
            Album selected;

            try
            {
                DialogResult answer = MessageBox.Show("Do you want to delete this album?", "Removed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    selected = (Album)dgvAlbums.CurrentRow.DataBoundItem;
                    business.Delete(selected.Id);
                    LoadWindow();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Album> list;
            string filter = txtSearch.Text;

            if (filter.Length >= 3)
                list = albumList.FindAll(x => x.Title.ToUpper().Contains(filter.ToUpper()) || x.Artist.ToUpper().Contains(filter.ToUpper()));
            else
                list = albumList;

            dgvAlbums.DataSource = null;
            dgvAlbums.DataSource = list;
            HideColumns();         
        }
    }
}
