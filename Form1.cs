namespace GestionnarEmpleadosTxT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CamposVacios()
        {
            if (txtID.Text == "" ||
                txtNombre.Text == "" ||
                txtApellidos.Text == "" ||
                txtDireccion.Text == "" ||
                txtTelefono.Text == "" ||
                txtEmail.Text == "" ||
                txtCargo.Text == "" ||
                txtSalario.Text == "" ||
                cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Todos los campos son obligatorios",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return true;
            }
            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (CamposVacios()) return;

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Archivo de texto (*.txt)|*.txt";
            guardar.Title = "Guardar datos del empleado";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(guardar.FileName))
                {
                    sw.WriteLine("ID | Nombre | Apellidos | Dirección | Teléfono | Email | Cargo | Salario | Fecha Ingreso | Género");
                    sw.WriteLine("----------------------------------------------------------------------------------------------");
                    sw.WriteLine(
                        txtID.Text + " | " +
                        txtNombre.Text + " | " +
                        txtApellidos.Text + " | " +
                        txtDireccion.Text + " | " +
                        txtTelefono.Text + " | " +
                        txtEmail.Text + " | " +
                        txtCargo.Text + " | " +
                        txtSalario.Text + " | " +
                        dtpFechaIngreso.Value.ToShortDateString() + " | " +
                        cmbGenero.Text
                    );
                }

                MessageBox.Show(
                    "Archivo guardado correctamente",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivo de texto (*.txt)|*.txt";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start("notepad.exe", abrir.FileName);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
    "¿Desea salir de la aplicación?",
    "Salir",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCargo.Clear();
            txtSalario.Clear();
            cmbGenero.SelectedIndex = -1;
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");
            cmbGenero.Items.Add("Otro");
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un género",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
