using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            //Objeto
            clmulti pMultip = new clmulti();
            pMultip.Nume1 = int.Parse(txtNum1.Text);
            pMultip.Nume2 = int.Parse(txtNum2.Text);
            textBox3.Text = pMultip.multip().ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            textBox3.Clear();
        }
    }
}
