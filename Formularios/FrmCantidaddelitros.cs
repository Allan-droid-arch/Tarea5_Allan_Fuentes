using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_Allan_Fuentes.Formularios
{
    public partial class FrmCantidaddelitros : Form
    {
        Clases.operacion k = new Clases.operacion();
        public FrmCantidaddelitros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(alt.Text.Trim());
            double h = Convert.ToDouble(anch.Text.Trim());

            MessageBox.Show("Los litros nesesarios son :" + k.tanque(r, h));
        }
       
    }
}
