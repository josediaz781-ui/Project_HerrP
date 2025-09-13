namespace Project_HerrP
{
    partial class SeguridadForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtCont = new TextBox();
            usuariosDataGridView = new DataGridView();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label4 = new Label();
            txtUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 0;
            label1.Text = "ACTALIZAR DATOS DE USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 127);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 58);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(267, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtCont
            // 
            txtCont.Location = new Point(267, 119);
            txtCont.Name = "txtCont";
            txtCont.Size = new Size(168, 23);
            txtCont.TabIndex = 4;
            // 
            // usuariosDataGridView
            // 
            usuariosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuariosDataGridView.Location = new Point(195, 176);
            usuariosDataGridView.Name = "usuariosDataGridView";
            usuariosDataGridView.Size = new Size(240, 109);
            usuariosDataGridView.TabIndex = 5;
            usuariosDataGridView.CellClick += usuariosDataGridView_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(27, 176);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(27, 204);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(27, 233);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(27, 262);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 89);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 10;
            label4.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(267, 81);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(168, 23);
            txtUsuario.TabIndex = 11;
            // 
            // SeguridadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(447, 306);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(usuariosDataGridView);
            Controls.Add(txtCont);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SeguridadForm";
            Text = "SeguridadForm";
            Load += UsuariosForm_Load;
            ((System.ComponentModel.ISupportInitialize)usuariosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtCont;
        private DataGridView usuariosDataGridView;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label4;
        private TextBox txtUsuario;
    }
}