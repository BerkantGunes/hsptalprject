using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        hastane_yonetimEntities ef = new hastane_yonetimEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            var list = ef.Giris.ToList();

            foreach (var item in list)
            {
                if (item.email == txtEmail.Text && item.password == txtParola.Text)
                {
                    hospitalMain hMain = new hospitalMain();
                    this.Hide();
                    hMain.Show();
                }
                else
                {
                    MessageBox.Show("Email veya Parola Hatali!");
                }
            }
        }
    }
}
