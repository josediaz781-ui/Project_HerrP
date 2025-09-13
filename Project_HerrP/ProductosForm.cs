using System.Data;
using System.Data.SqlClient;

namespace Project_HerrP
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ProductoId, Codigo, Nombre, Precio FROM Productos", conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    productosDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void productosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = this.productosDataGridView.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    string sql = "INSERT INTO Productos (Codigo, Nombre, Precio) VALUES (@codigo, @nombre, @precio)";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto guardado exitosamente.");
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (productosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para editar.");
                return;
            }

            try
            {
                int productoId = Convert.ToInt32(productosDataGridView.SelectedRows[0].Cells["ProductoId"].Value);

                using (SqlConnection conexion = DBConexion.AbrirConexion())
                {
                    string sql = "UPDATE Productos SET Codigo = @codigo, Nombre = @nombre, Precio = @precio WHERE ProductoId = @id";
                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
                        cmd.Parameters.AddWithValue("@id", productoId);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto actualizado exitosamente.");
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    int productoId = Convert.ToInt32(productosDataGridView.SelectedRows[0].Cells["ProductoId"].Value);

                    using (SqlConnection conexion = DBConexion.AbrirConexion())
                    {
                        string sql = "DELETE FROM Productos WHERE ProductoId = @id";
                        using (SqlCommand cmd = new SqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", productoId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Producto eliminado exitosamente.");
                            CargarProductos();
                            LimpiarCampos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
