namespace CAI_Facultad
{
    partial class FormLogin
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
            lblUsuario = new Label();
            txtLoginUsuario = new TextBox();
            lblContraseña = new Label();
            txtConstraseña = new TextBox();
            btbIngresar = new Button();
            btbContraseña = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(179, 81);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtLoginUsuario
            // 
            txtLoginUsuario.Location = new Point(303, 81);
            txtLoginUsuario.Name = "txtLoginUsuario";
            txtLoginUsuario.Size = new Size(193, 31);
            txtLoginUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(179, 132);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(101, 25);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // txtConstraseña
            // 
            txtConstraseña.Location = new Point(303, 126);
            txtConstraseña.Name = "txtConstraseña";
            txtConstraseña.Size = new Size(193, 31);
            txtConstraseña.TabIndex = 3;
            // 
            // btbIngresar
            // 
            btbIngresar.Location = new Point(303, 228);
            btbIngresar.Name = "btbIngresar";
            btbIngresar.Size = new Size(193, 34);
            btbIngresar.TabIndex = 4;
            btbIngresar.Text = "Ingresar";
            btbIngresar.UseVisualStyleBackColor = true;
            btbIngresar.Click += btbIngresar_Click;
            // 
            // btbContraseña
            // 
            btbContraseña.Location = new Point(303, 294);
            btbContraseña.Name = "btbContraseña";
            btbContraseña.Size = new Size(193, 34);
            btbContraseña.TabIndex = 5;
            btbContraseña.Text = "Actualizar contraseña";
            btbContraseña.UseVisualStyleBackColor = true;
            btbContraseña.Click += btbContraseña_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(btbContraseña);
            Controls.Add(btbIngresar);
            Controls.Add(txtConstraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtLoginUsuario);
            Controls.Add(lblUsuario);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtLoginUsuario;
        private Label lblContraseña;
        private TextBox txtConstraseña;
        private Button btbIngresar;
        private Button btbContraseña;
    }
}