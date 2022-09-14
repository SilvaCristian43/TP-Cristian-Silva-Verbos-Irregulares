using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace Frontend
{
    public partial class PluralesIrregulares : Form
    {
        Info mostrarinfo= new Info();
        public PluralesIrregulares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu LlamarMenu = new Menu();
            LlamarMenu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtmostrarplurales.Text = mostrarinfo.MostrarPlurales();

        }
    }
}
