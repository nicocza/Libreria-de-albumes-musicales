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
                LoadImage(albumList[0].ImageURL);
                HideColumns();

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
    }
}
