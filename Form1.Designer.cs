namespace GestionnarEmpleadosTxT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label11 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnGuardar = new Button();
            btnAbrir = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtCargo = new TextBox();
            txtSalario = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            cmbGenero = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 78, 121);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 71);
            panel1.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(331, 21);
            label11.Name = "label11";
            label11.Size = new Size(398, 39);
            label11.TabIndex = 23;
            label11.Text = "Registro De Empleados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 145);
            label1.Name = "label1";
            label1.Size = new Size(35, 22);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 306);
            label2.Name = "label2";
            label2.Size = new Size(95, 22);
            label2.TabIndex = 1;
            label2.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 363);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 197);
            label4.Name = "label4";
            label4.Size = new Size(85, 22);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 249);
            label5.Name = "label5";
            label5.Size = new Size(98, 22);
            label5.TabIndex = 4;
            label5.Text = "Apellidos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(510, 197);
            label6.Name = "label6";
            label6.Size = new Size(65, 22);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(510, 145);
            label7.Name = "label7";
            label7.Size = new Size(70, 22);
            label7.TabIndex = 11;
            label7.Text = "Cargo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(510, 306);
            label8.Name = "label8";
            label8.Size = new Size(143, 22);
            label8.TabIndex = 12;
            label8.Text = "Fecha ingreso:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(510, 244);
            label9.Name = "label9";
            label9.Size = new Size(79, 22);
            label9.TabIndex = 13;
            label9.Text = "Salario:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(510, 364);
            label10.Name = "label10";
            label10.Size = new Size(82, 22);
            label10.TabIndex = 14;
            label10.Text = "Genero:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 204, 113);
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(151, 438);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 58);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.FromArgb(52, 152, 219);
            btnAbrir.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrir.Location = new Point(322, 438);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(155, 58);
            btnAbrir.TabIndex = 24;
            btnAbrir.Text = "Abrir Archivo";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(231, 76, 60);
            btnSalir.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(498, 438);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 58);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(241, 196, 15);
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(798, 455);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 41);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtID.Location = new Point(210, 144);
            txtID.Name = "txtID";
            txtID.Size = new Size(254, 27);
            txtID.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtNombre.Location = new Point(210, 197);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 27);
            txtNombre.TabIndex = 28;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtApellidos.Location = new Point(210, 244);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(254, 27);
            txtApellidos.TabIndex = 29;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtDireccion.Location = new Point(210, 304);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(254, 27);
            txtDireccion.TabIndex = 30;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTelefono.Location = new Point(210, 363);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(254, 27);
            txtTelefono.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtEmail.Location = new Point(615, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 27);
            txtEmail.TabIndex = 32;
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtCargo.Location = new Point(615, 192);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(249, 27);
            txtCargo.TabIndex = 33;
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSalario.Location = new Point(615, 243);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(249, 27);
            txtSalario.TabIndex = 34;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.CalendarFont = new Font("Microsoft Sans Serif", 10.2F);
            dtpFechaIngreso.Location = new Point(659, 301);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(275, 27);
            dtpFechaIngreso.TabIndex = 35;
            // 
            // cmbGenero
            // 
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(615, 362);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(241, 28);
            cmbGenero.TabIndex = 36;
            cmbGenero.SelectedIndexChanged += cmbGenero_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1098, 564);
            Controls.Add(cmbGenero);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(txtSalario);
            Controls.Add(txtCargo);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnAbrir);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label11;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnGuardar;
        private Button btnAbrir;
        private Button btnSalir;
        private Button btnLimpiar;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtCargo;
        private TextBox txtSalario;
        private DateTimePicker dtpFechaIngreso;
        private ComboBox cmbGenero;
        private PictureBox pictureBox1;
    }
}
