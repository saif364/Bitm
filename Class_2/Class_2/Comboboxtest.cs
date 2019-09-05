using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_2
{
    public partial class Comboboxtest : Form
    {
        public Comboboxtest()
        {
            InitializeComponent();
        }

        private void btnComboTest_Click(object sender, EventArgs e)
        {

            string planet = cmbPlanet.Text;

            if (planet=="world")
            {
                MessageBox.Show("You have selected the world");
            }

          else   if(planet=="earth")
            {
                MessageBox.Show("you have selected earth " );

            }

            else
            {
                MessageBox.Show("you have not selected anything");
            }

        }
    }
}
