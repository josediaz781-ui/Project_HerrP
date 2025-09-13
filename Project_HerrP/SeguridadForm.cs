using System.Data;
using System.Data.SqlClient;

namespace Project_HerrP
{
    public partial class SeguridadForm : Form
    {
        public SeguridadForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT UsuarioId, Nombre, Usuario, Contrasena FROM Usuario", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    usuariosDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
        }

        private void usuariosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.usuariosDataGridView.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtCont.Text = fila.Cells["Contrasena"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtCont.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    string sql = "INSERT INTO Usuario (Nombre, Usuario, Contrasena) VALUES (@nombre, @usuario, @contrasena)";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtCont.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario guardado exitosamente.");
                        CargarUsuarios();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (usuariosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
                return;
            }

            try
            {
                int usuarioId = Convert.ToInt32(usuariosDataGridView.SelectedRows[0].Cells["UsuarioId"].Value);

                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    string sql = "UPDATE Usuario SET Nombre = @nombre, Usuario = @usuario, Contrasena = @contrasena WHERE UsuarioId = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@usuario", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtCont.Text);
                        cmd.Parameters.AddWithValue("@id", usuarioId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado exitosamente.");
                        CargarUsuarios();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuariosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int usuarioId = Convert.ToInt32(usuariosDataGridView.SelectedRows[0].Cells["UsuarioId"].Value);

                    using (SqlConnection conexion = DBConexion.AbrirConexion())
                    {
                        string sql = "DELETE FROM Usuario WHERE UsuarioId = @id";
                        using (SqlCommand cmd = new SqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", usuarioId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario eliminado exitosamente.");
                            CargarUsuarios();
                            LimpiarCampos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
