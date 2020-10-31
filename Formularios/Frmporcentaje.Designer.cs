namespace Tarea5_Allan_Fuentes.Formularios
{
    partial class Frmporcentaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pre = new System.Windows.Forms.TextBox();
            this.prev = new System.Windows.Forms.TextBox();
            this.ganan = new System.Windows.Forms.TextBox();
            this.Btncalcular = new System.Windows.Forms.Button();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ganancia obtenida";
            // 
            // pre
            // 
            this.pre.Location = new System.Drawing.Point(133, 26);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(100, 25);
            this.pre.TabIndex = 3;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(133, 74);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(100, 25);
            this.prev.TabIndex = 4;
            // 
            // ganan
            // 
            this.ganan.Location = new System.Drawing.Point(133, 120);
            this.ganan.Name = "ganan";
            this.ganan.ReadOnly = true;
            this.ganan.Size = new System.Drawing.Size(100, 25);
            this.ganan.TabIndex = 5;
            // 
            // Btncalcular
            // 
            this.Btncalcular.Location = new System.Drawing.Point(84, 160);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(75, 30);
            this.Btncalcular.TabIndex = 6;
            this.Btncalcular.Text = "Calcular";
            this.Btncalcular.UseVisualStyleBackColor = true;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.Location = new System.Drawing.Point(182, 160);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(75, 30);
            this.Btnlimpiar.TabIndex = 7;
            this.Btnlimpiar.Text = "Limpiar";
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // Frmporcentaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(389, 221);
            this.Controls.Add(this.Btnlimpiar);
            this.Controls.Add(this.Btncalcular);
            this.Controls.Add(this.ganan);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmporcentaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porcentaje de ganacia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pre;
        private System.Windows.Forms.TextBox prev;
        private System.Windows.Forms.TextBox ganan;
        private System.Windows.Forms.Button Btncalcular;
        private System.Windows.Forms.Button Btnlimpiar;
    }
}