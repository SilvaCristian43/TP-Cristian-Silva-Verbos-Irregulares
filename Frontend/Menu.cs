using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SustantivosIrregulares  LlamarSustantivos=new SustantivosIrregulares();
            LlamarSustantivos.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PluralesIrregulares LlamarPlurales =new PluralesIrregulares();
            LlamarPlurales.Show();
            this.Close();

        }
    }
}
