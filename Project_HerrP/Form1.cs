using System.Data.SqlClient;

namespace Project_HerrP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblValidUser_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUser.Text;
            string contrasenaIngresada = txtPassword.Text;
            using (SqlConnection conexion = DBConexion.AbrirConexion())
            {
                try
                {
                    // Consulta SQL para verificar la existencia del usuario y la contraseña
                    string query = "SELECT COUNT(*) FROM Usuario WHERE Usuario = @usuario AND Contrasena = @contrasena";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuarioIngresado);
                        cmd.Parameters.AddWithValue("@contrasena", contrasenaIngresada);

                        int resultado = (int)cmd.ExecuteScalar();

                        if (resultado > 0)
                        {
                            this.Hide();
                            HomeForm homeForm = new HomeForm();
                            homeForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
