namespace Project_HerrP
{
    partial class ClientesForm
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
            btnEditar = new Button();
            btnEliminar = new Button();
            lblClientes = new Label();
            dataGridClientes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNit = new TextBox();
            txtTelefono = new TextBox();
            txtxNombre = new TextBox();
            btnAlmacenar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(70, 260);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(129, 26);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(70, 294);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 28);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(70, 43);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(92, 15);
            lblClientes.TabIndex = 3;
            lblClientes.Text = "CRUD CLIENTES";
            // 
            // dataGridClientes
            // 
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(231, 156);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.Size = new Size(328, 166);
            dataGridClientes.TabIndex = 4;
            dataGridClientes.CellClick += dataGridClientes_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 53);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 5;
            label1.Text = "Nit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // txtNit
            // 
            txtNit.Location = new Point(346, 53);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(213, 23);
            txtNit.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(346, 113);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(213, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtxNombre
            // 
            txtxNombre.Location = new Point(346, 83);
            txtxNombre.Name = "txtxNombre";
            txtxNombre.Size = new Size(213, 23);
            txtxNombre.TabIndex = 11;
            // 
            // btnAlmacenar
            // 
            btnAlmacenar.Location = new Point(70, 226);
            btnAlmacenar.Name = "btnAlmacenar";
            btnAlmacenar.Size = new Size(129, 28);
            btnAlmacenar.TabIndex = 12;
            btnAlmacenar.Text = "Crear";
            btnAlmacenar.UseVisualStyleBackColor = true;
            btnAlmacenar.Click += btnAlmacenar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(70, 192);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 28);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(589, 362);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAlmacenar);
            Controls.Add(txtxNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtNit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridClientes);
            Controls.Add(lblClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Name = "ClientesForm";
            Text = "ClientesForm";
            Load += ClientesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditar;
        private Button btnEliminar;
        private Label lblClientes;
        private DataGridView dataGridClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNit;
        private TextBox txtTelefono;
        private TextBox txtxNombre;
        private Button btnAlmacenar;
        private Button btnLimpiar;
    }
}