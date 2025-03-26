namespace CAI_Facultad
{
    partial class FormEmpleados
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
            lblNombreEmpleado = new Label();
            txtNombreEmpleado = new TextBox();
            lblApellidoEmpleado = new Label();
            txtApellidoEmpleado = new TextBox();
            lblLegajo = new Label();
            txtLegajo = new TextBox();
            lblFechaNacEmpleados = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblFechaIngreso = new Label();
            dateTimePicker2 = new DateTimePicker();
            btbIngresarEmpleado = new Button();
            SuspendLayout();
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Location = new Point(40, 52);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(78, 25);
            lblNombreEmpleado.TabIndex = 0;
            lblNombreEmpleado.Text = "Nombre";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(138, 52);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(196, 31);
            txtNombreEmpleado.TabIndex = 1;
            // 
            // lblApellidoEmpleado
            // 
            lblApellidoEmpleado.AutoSize = true;
            lblApellidoEmpleado.Location = new Point(40, 112);
            lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            lblApellidoEmpleado.Size = new Size(78, 25);
            lblApellidoEmpleado.TabIndex = 2;
            lblApellidoEmpleado.Text = "Apellido";
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Location = new Point(138, 112);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(196, 31);
            txtApellidoEmpleado.TabIndex = 3;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(392, 56);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(64, 25);
            lblLegajo.TabIndex = 4;
            lblLegajo.Text = "Legajo";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(490, 52);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(264, 31);
            txtLegajo.TabIndex = 5;
            // 
            // lblFechaNacEmpleados
            // 
            lblFechaNacEmpleados.AutoSize = true;
            lblFechaNacEmpleados.Location = new Point(40, 171);
            lblFechaNacEmpleados.Name = "lblFechaNacEmpleados";
            lblFechaNacEmpleados.Size = new Size(177, 25);
            lblFechaNacEmpleados.TabIndex = 6;
            lblFechaNacEmpleados.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(234, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(213, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(392, 115);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(147, 25);
            lblFechaIngreso.TabIndex = 8;
            lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(561, 110);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(193, 31);
            dateTimePicker2.TabIndex = 9;
            // 
            // btbIngresarEmpleado
            // 
            btbIngresarEmpleado.Location = new Point(304, 237);
            btbIngresarEmpleado.Name = "btbIngresarEmpleado";
            btbIngresarEmpleado.Size = new Size(130, 38);
            btbIngresarEmpleado.TabIndex = 10;
            btbIngresarEmpleado.Text = "Ingresar";
            btbIngresarEmpleado.UseVisualStyleBackColor = true;
            // 
            // FormsEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btbIngresarEmpleado);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblFechaIngreso);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblFechaNacEmpleados);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(txtApellidoEmpleado);
            Controls.Add(lblApellidoEmpleado);
            Controls.Add(txtNombreEmpleado);
            Controls.Add(lblNombreEmpleado);
            Name = "FormsEmpleados";
            Text = "Empleados";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreEmpleado;
        private TextBox txtNombreEmpleado;
        private Label lblApellidoEmpleado;
        private TextBox txtApellidoEmpleado;
        private Label lblLegajo;
        private TextBox txtLegajo;
        private Label lblFechaNacEmpleados;
        private DateTimePicker dateTimePicker1;
        private Label lblFechaIngreso;
        private DateTimePicker dateTimePicker2;
        private Button btbIngresarEmpleado;
    }
}
