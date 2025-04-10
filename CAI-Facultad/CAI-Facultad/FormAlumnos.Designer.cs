namespace CAI_Facultad
{
    partial class FormAlumnos
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
            lblNombreAlumnos = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblFechaNac = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btbListarAlumnos = new Button();
            btbModificar = new Button();
            lstAlumnos = new ListBox();
            SuspendLayout();
            // 
            // lblNombreAlumnos
            // 
            lblNombreAlumnos.AutoSize = true;
            lblNombreAlumnos.Location = new Point(52, 48);
            lblNombreAlumnos.Name = "lblNombreAlumnos";
            lblNombreAlumnos.Size = new Size(78, 25);
            lblNombreAlumnos.TabIndex = 0;
            lblNombreAlumnos.Text = "Nombre";
            lblNombreAlumnos.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(264, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(52, 155);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(177, 25);
            lblFechaNac.TabIndex = 2;
            lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(52, 95);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(78, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 31);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(156, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(173, 31);
            txtApellido.TabIndex = 5;
            // 
            // btbListarAlumnos
            // 
            btbListarAlumnos.Location = new Point(47, 258);
            btbListarAlumnos.Name = "btbListarAlumnos";
            btbListarAlumnos.Size = new Size(165, 34);
            btbListarAlumnos.TabIndex = 9;
            btbListarAlumnos.Text = "Listar";
            btbListarAlumnos.UseVisualStyleBackColor = true;
            btbListarAlumnos.Click += btbListarAlumnos_Click;
            // 
            // btbModificar
            // 
            btbModificar.Location = new Point(47, 328);
            btbModificar.Name = "btbModificar";
            btbModificar.Size = new Size(165, 34);
            btbModificar.TabIndex = 10;
            btbModificar.Text = "Modificar";
            btbModificar.UseVisualStyleBackColor = true;
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.ItemHeight = 25;
            lstAlumnos.Location = new Point(240, 243);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(346, 129);
            lstAlumnos.TabIndex = 11;
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstAlumnos);
            Controls.Add(btbModificar);
            Controls.Add(btbListarAlumnos);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblFechaNac);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblNombreAlumnos);
            Name = "FormAlumnos";
            Text = "Alumnos";
            Load += FormAlumnos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreAlumnos;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaNac;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btbListarAlumnos;
        private Button btbModificar;
        private ListBox lstAlumnos;
    }
}