namespace CAI_Facultad
{
    partial class FormMenu
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
            btbMenuAlumno = new Button();
            btbMenuEmpleado = new Button();
            SuspendLayout();
            // 
            // btbMenuAlumno
            // 
            btbMenuAlumno.Location = new Point(149, 147);
            btbMenuAlumno.Name = "btbMenuAlumno";
            btbMenuAlumno.Size = new Size(183, 34);
            btbMenuAlumno.TabIndex = 0;
            btbMenuAlumno.Text = "Soy Alumno";
            btbMenuAlumno.UseVisualStyleBackColor = true;
            btbMenuAlumno.Click += btbMenuAlumno_Click;
            // 
            // btbMenuEmpleado
            // 
            btbMenuEmpleado.Location = new Point(405, 147);
            btbMenuEmpleado.Name = "btbMenuEmpleado";
            btbMenuEmpleado.Size = new Size(173, 34);
            btbMenuEmpleado.TabIndex = 1;
            btbMenuEmpleado.Text = "Soy Empleado";
            btbMenuEmpleado.UseVisualStyleBackColor = true;
            btbMenuEmpleado.Click += btbMenuEmpleado_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btbMenuEmpleado);
            Controls.Add(btbMenuAlumno);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btbMenuAlumno;
        private Button btbMenuEmpleado;
    }
}