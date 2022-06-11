using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_App.Screens
{
    public partial class Dashborad : MetroFramework.Forms.MetroForm
    {
        public Dashborad()
        {
            InitializeComponent();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ProductDefination pd = new ProductDefination();
            pd.Show();
        }
    }
}
