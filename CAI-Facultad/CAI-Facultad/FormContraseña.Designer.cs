namespace CAI_Facultad
{
    partial class FormContraseña
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
            txtNuevaContraseña = new TextBox();
            lblContraseñaNueva = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            btbActualizarContraseña = new Button();
            SuspendLayout();
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Location = new Point(384, 159);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(150, 31);
            txtNuevaContraseña.TabIndex = 0;
            // 
            // lblContraseñaNueva
            // 
            lblContraseñaNueva.AutoSize = true;
            lblContraseñaNueva.Location = new Point(209, 159);
            lblContraseñaNueva.Name = "lblContraseñaNueva";
            lblContraseñaNueva.Size = new Size(153, 25);
            lblContraseñaNueva.TabIndex = 1;
            lblContraseñaNueva.Text = "Contraseña nueva";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(290, 104);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(384, 104);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 3;
            // 
            // btbActualizarContraseña
            // 
            btbActualizarContraseña.Location = new Point(209, 237);
            btbActualizarContraseña.Name = "btbActualizarContraseña";
            btbActualizarContraseña.Size = new Size(325, 34);
            btbActualizarContraseña.TabIndex = 4;
            btbActualizarContraseña.Text = "Actualizar Contraseña";
            btbActualizarContraseña.UseVisualStyleBackColor = true;
            // 
            // FormContraseña
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btbActualizarContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblContraseñaNueva);
            Controls.Add(txtNuevaContraseña);
            Name = "FormContraseña";
            Text = "Actualizar Contraseña";
           // Load += this.FormContraseña_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNuevaContraseña;
        private Label lblContraseñaNueva;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btbActualizarContraseña;
    }
}