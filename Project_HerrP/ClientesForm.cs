using System.Data;
using System.Data.SqlClient;

namespace Project_HerrP
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ClienteId, NIT, Nombre, Telefono FROM Clientes", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridClientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNit.Clear();
            txtTelefono.Clear();
            txtxNombre.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int clienteId = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells["ClienteId"].Value);

                    using (SqlConnection conexion = DBConexion.AbrirConexion())
                    {
                        string sql = "DELETE FROM Clientes WHERE ClienteId = @id";
                        using (SqlCommand cmd = new SqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", clienteId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cliente eliminado exitosamente.");
                            CargarClientes();
                            LimpiarCampos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }
            }
        }

        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    string sql = "INSERT INTO Clientes (NIT, Nombre, Telefono) VALUES (@nit, @nombre, @telefono)";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nit", txtNit.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtxNombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente guardado exitosamente.");
                        CargarClientes();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
                return;
            }

            try
            {
                // Obtiene el ID del cliente de la fila seleccionada
                int clienteId = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells["ClienteId"].Value);

                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    string sql = "UPDATE Clientes SET NIT = @nit, Nombre = @nombre, Telefono = @telefono WHERE ClienteId = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nit", txtNit.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtxNombre.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@id", clienteId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente actualizado exitosamente.");
                        CargarClientes();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
            }
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.dataGridClientes.Rows[e.RowIndex];
                txtNit.Text = fila.Cells["NIT"].Value.ToString();
                txtxNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            }
        }
    }
}
