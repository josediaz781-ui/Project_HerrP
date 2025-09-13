namespace Project_HerrP
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
            lblValidUser = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnValidar = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblValidUser
            // 
            lblValidUser.AutoSize = true;
            lblValidUser.Location = new Point(119, 92);
            lblValidUser.Name = "lblValidUser";
            lblValidUser.Size = new Size(105, 15);
            lblValidUser.TabIndex = 1;
            lblValidUser.Text = "VALIDAR USUARIO";
            lblValidUser.Click += lblValidUser_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(119, 134);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(277, 23);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(119, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(277, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(119, 240);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(127, 32);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "VALIDAR";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(269, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 32);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(540, 344);
            Controls.Add(btnCancel);
            Controls.Add(btnValidar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblValidUser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblValidUser;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnValidar;
        private Button btnCancel;
    }
}
