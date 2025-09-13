namespace Project_HerrP
{
    partial class ProductosForm
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
            btnLimpiar = new Button();
            btnCrear = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            productosDataGridView = new DataGridView();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(87, 179);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 29);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(87, 211);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(108, 29);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(87, 246);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(87, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 41);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "CRUD PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 132);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Precio";
            // 
            // productosDataGridView
            // 
            productosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productosDataGridView.Location = new Point(260, 160);
            productosDataGridView.Name = "productosDataGridView";
            productosDataGridView.Size = new Size(310, 150);
            productosDataGridView.TabIndex = 8;
            productosDataGridView.CellClick += productosDataGridView_CellClick;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(351, 55);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(219, 23);
            txtCodigo.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(351, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(351, 124);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(219, 23);
            txtPrecio.TabIndex = 11;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(589, 362);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(productosDataGridView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnCrear);
            Controls.Add(btnLimpiar);
            Name = "ProductosForm";
            Text = "ProductosForm";
            Load += ProductosForm_Load;
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnCrear;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView productosDataGridView;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
    }
}