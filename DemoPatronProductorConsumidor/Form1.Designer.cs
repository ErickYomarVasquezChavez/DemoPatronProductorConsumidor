namespace DemoPatronProductorConsumidor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRegistrar = new Button();
            label1 = new Label();
            txtCorreo = new TextBox();
            textBox1 = new TextBox();
            TxtNombre = new Label();
            panel2 = new Panel();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            btnProcesar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(TxtNombre);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 241);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(227, 184);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(127, 39);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 108);
            label1.Name = "label1";
            label1.Size = new Size(138, 18);
            label1.TabIndex = 3;
            label1.Text = "Correo Eelectronico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(30, 128);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(324, 23);
            txtCorreo.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 1;
            // 
            // TxtNombre
            // 
            TxtNombre.AutoSize = true;
            TxtNombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TxtNombre.Location = new Point(30, 22);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(63, 18);
            TxtNombre.TabIndex = 0;
            TxtNombre.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvUsuarios);
            panel2.Location = new Point(12, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 218);
            panel2.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.Red;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(581, 212);
            dgvUsuarios.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(128, 255, 255);
            btnProcesar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProcesar.Location = new Point(477, 274);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(97, 23);
            btnProcesar.TabIndex = 2;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(btnProcesar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Demostracion patron Productor _Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label TxtNombre;
        private Label label1;
        private TextBox txtCorreo;
        private Button btnRegistrar;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnProcesar;
    }
}
