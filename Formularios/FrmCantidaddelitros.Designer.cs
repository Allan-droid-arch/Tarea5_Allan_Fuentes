namespace Tarea5_Allan_Fuentes.Formularios
{
    partial class FrmCantidaddelitros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.anch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btncalcular
            // 
            this.Btncalcular.Location = new System.Drawing.Point(137, 143);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(75, 28);
            this.Btncalcular.TabIndex = 0;
            this.Btncalcular.Text = "Calcular";
            this.Btncalcular.UseVisualStyleBackColor = true;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la altura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alt
            // 
            this.alt.Location = new System.Drawing.Point(137, 43);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(100, 25);
            this.alt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el ancho\r\n";
            // 
            // anch
            // 
            this.anch.Location = new System.Drawing.Point(137, 94);
            this.anch.Name = "anch";
            this.anch.Size = new System.Drawing.Size(100, 25);
            this.anch.TabIndex = 4;
            // 
            // FrmCantidaddelitros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(373, 183);
            this.Controls.Add(this.anch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btncalcular);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCantidaddelitros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de canridad de litros que necesita un tanque de agua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox anch;
    }
}