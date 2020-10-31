namespace Tarea5_Allan_Fuentes.Formularios
{
    partial class Frmnotadevarios
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.n3 = new System.Windows.Forms.TextBox();
            this.n4 = new System.Windows.Forms.TextBox();
            this.Dastu = new System.Windows.Forms.DataGridView();
            this.Cnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnota3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnota4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caprobado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caprovado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dastu)).BeginInit();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(291, 108);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(86, 28);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE DEL ESTUDIANTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(288, 28);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(431, 25);
            this.n.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOTA 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOTA 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOTA 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "NOTA 4";
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(261, 67);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(56, 25);
            this.n1.TabIndex = 7;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(415, 69);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(56, 25);
            this.n2.TabIndex = 8;
            // 
            // n3
            // 
            this.n3.Location = new System.Drawing.Point(568, 69);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(56, 25);
            this.n3.TabIndex = 9;
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(755, 69);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(56, 25);
            this.n4.TabIndex = 10;
            // 
            // Dastu
            // 
            this.Dastu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dastu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cnombre,
            this.Cnota1,
            this.Cnota2,
            this.Cnota3,
            this.Cnota4,
            this.CPromedio,
            this.Caprobado,
            this.Caprovado});
            this.Dastu.Location = new System.Drawing.Point(12, 142);
            this.Dastu.Name = "Dastu";
            this.Dastu.Size = new System.Drawing.Size(897, 150);
            this.Dastu.TabIndex = 11;
            // 
            // Cnombre
            // 
            this.Cnombre.HeaderText = "Nombre";
            this.Cnombre.Name = "Cnombre";
            this.Cnombre.Width = 200;
            // 
            // Cnota1
            // 
            this.Cnota1.HeaderText = "Nota 1";
            this.Cnota1.Name = "Cnota1";
            this.Cnota1.Width = 70;
            // 
            // Cnota2
            // 
            this.Cnota2.HeaderText = "Nota 2";
            this.Cnota2.Name = "Cnota2";
            // 
            // Cnota3
            // 
            this.Cnota3.HeaderText = "Nota 3";
            this.Cnota3.Name = "Cnota3";
            // 
            // Cnota4
            // 
            this.Cnota4.HeaderText = "Nota 4";
            this.Cnota4.Name = "Cnota4";
            // 
            // CPromedio
            // 
            this.CPromedio.HeaderText = "Promedio";
            this.CPromedio.Name = "CPromedio";
            // 
            // Caprobado
            // 
            this.Caprobado.HeaderText = "Reprobado";
            this.Caprobado.Name = "Caprobado";
            // 
            // Caprovado
            // 
            this.Caprovado.HeaderText = "Aprovado";
            this.Caprovado.Name = "Caprovado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmnotadevarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(939, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dastu);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmnotadevarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.Dastu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox n3;
        private System.Windows.Forms.TextBox n4;
        private System.Windows.Forms.DataGridView Dastu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnota3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnota4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caprovado;
        private System.Windows.Forms.Button button1;
    }
}