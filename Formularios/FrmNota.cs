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

    public partial class FrmNota : Form
    {
        Clases.operacion k = new Clases.operacion();

        public FrmNota()
        {
            InitializeComponent();
        }
        public void vali(double g)
        {
            if (g < 0 || g > 20)
            {
                MessageBox.Show("El numero ingresado es menor que 0 o mayor que 20");


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {



            double a = Convert.ToDouble(n1.Text.Trim());
            double b = Convert.ToDouble(n2.Text.Trim());
            double c = Convert.ToDouble(n3.Text.Trim());
            MessageBox.Show(" " + " Hola " + n.Text.Trim() + " " + " Para aprobar necesita : " + k.nota(a, b, c).ToString());
        }

        private void FrmNota_Load(object sender, EventArgs e)
        {

        }


        private void n1_TextChanged(object sender, EventArgs e)
        {
            try {


                double b = double.Parse(n1.Text);
                vali(b);



            }
            catch (FormatException )
            {
                
                
            }
            
            
          
           
        }

        private void n2_TextChanged(object sender, EventArgs e)
        {

            try
            {


                double b = double.Parse(n2.Text);
                vali(b);



            }
            catch (FormatException)
            {


            }


        }

        private void n3_TextChanged(object sender, EventArgs e)
        {

            try
            {


                double b = double.Parse(n3.Text);
                vali(b);



            }
            catch (FormatException)
            {


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(TextBox t in this.Controls.OfType<TextBox>())
            {
                t.Clear();
                n.Focus();
            }
        }
    }
}
