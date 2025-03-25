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
            lblCodigo = new Label();
            textBox1 = new TextBox();
            btbIngresarAlumno = new Button();
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
            dateTimePicker1.Location = new Point(543, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(347, 101);
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
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(347, 51);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(139, 25);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código Alumno";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(543, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 31);
            textBox1.TabIndex = 7;
            // 
            // btbIngresarAlumno
            // 
            btbIngresarAlumno.Location = new Point(295, 175);
            btbIngresarAlumno.Name = "btbIngresarAlumno";
            btbIngresarAlumno.Size = new Size(138, 34);
            btbIngresarAlumno.TabIndex = 8;
            btbIngresarAlumno.Text = "Ingresar";
            btbIngresarAlumno.UseVisualStyleBackColor = true;
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btbIngresarAlumno);
            Controls.Add(textBox1);
            Controls.Add(lblCodigo);
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
        private Label lblCodigo;
        private TextBox textBox1;
        private Button btbIngresarAlumno;
    }
}