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
    public partial class Frmnotadevarios : Form
    {

        double total;
        double a, b, c, d;
        int p = 0;
        int ap = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Dastu.Rows.Clear();
        }

        public Frmnotadevarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                a = Convert.ToDouble(n1.Text.Trim());
            }
            catch(FormatException)
            {

            }
            try
            {
                b = Convert.ToDouble(n2.Text.Trim());
            }
            catch (FormatException)
            {

            }
            try
            {
                c= Convert.ToDouble(n3.Text.Trim());
            }
            catch (FormatException)
            {

            }
            try
            {
                d = Convert.ToDouble(n4.Text.Trim());
            }
            catch (FormatException)
            {

            }


            total = (a + b + c + d) / 4;

            if (total>=65)
            {
                p++;
            }
            else
            {
                ap++;
            }

            Dastu.Rows.Add(n.Text.Trim(), n1.Text.Trim(), n2.Text.Trim(), n3.Text.Trim(), n4.Text.Trim(),total,p,ap);
            
            foreach(TextBox u in this.Controls.OfType<TextBox>())
            {
                u.Clear();
            }
         


        }
    }
}
