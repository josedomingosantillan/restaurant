namespace Restaurant
{
    partial class EditarEmpleados
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
            label6 = new Label();
            salarioEmpleados = new TextBox();
            label4 = new Label();
            puestoEmpleados = new TextBox();
            label3 = new Label();
            apeEmpleados = new TextBox();
            label2 = new Label();
            nombreEmpleados = new TextBox();
            pictureBox1 = new PictureBox();
            menuprincipal = new Button();
            actualizarCliente = new Button();
            selectEmpleados = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 440);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 60;
            label6.Text = "Salario:";
            // 
            // salarioEmpleados
            // 
            salarioEmpleados.Location = new Point(106, 434);
            salarioEmpleados.Name = "salarioEmpleados";
            salarioEmpleados.Size = new Size(467, 27);
            salarioEmpleados.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 373);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 58;
            label4.Text = "Puesto:";
            // 
            // puestoEmpleados
            // 
            puestoEmpleados.Location = new Point(104, 367);
            puestoEmpleados.Name = "puestoEmpleados";
            puestoEmpleados.Size = new Size(469, 27);
            puestoEmpleados.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 304);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 56;
            label3.Text = "Apellido:";
            // 
            // apeEmpleados
            // 
            apeEmpleados.Location = new Point(115, 298);
            apeEmpleados.Name = "apeEmpleados";
            apeEmpleados.Size = new Size(458, 27);
            apeEmpleados.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 233);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 54;
            label2.Text = "Nombre:";
            // 
            // nombreEmpleados
            // 
            nombreEmpleados.Location = new Point(115, 227);
            nombreEmpleados.Name = "nombreEmpleados";
            nombreEmpleados.Size = new Size(458, 27);
            nombreEmpleados.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(671, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(140, 506);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 51;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // actualizarCliente
            // 
            actualizarCliente.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizarCliente.Location = new Point(430, 506);
            actualizarCliente.Name = "actualizarCliente";
            actualizarCliente.Size = new Size(177, 49);
            actualizarCliente.TabIndex = 50;
            actualizarCliente.Text = "Actualizar";
            actualizarCliente.UseVisualStyleBackColor = true;
            actualizarCliente.Click += actualizarCliente_Click;
            // 
            // selectEmpleados
            // 
            selectEmpleados.FormattingEnabled = true;
            selectEmpleados.Location = new Point(208, 164);
            selectEmpleados.Name = "selectEmpleados";
            selectEmpleados.Size = new Size(365, 28);
            selectEmpleados.TabIndex = 49;
            selectEmpleados.Text = "Selecciona un Empleado.";
            selectEmpleados.SelectedIndexChanged += selectEmpleados_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(21, 158);
            label5.Name = "label5";
            label5.Size = new Size(187, 34);
            label5.TabIndex = 48;
            label5.Text = "Empleados:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(892, 93);
            label1.TabIndex = 47;
            label1.Text = "Actualizar Empleados";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 590);
            Controls.Add(label6);
            Controls.Add(salarioEmpleados);
            Controls.Add(label4);
            Controls.Add(puestoEmpleados);
            Controls.Add(label3);
            Controls.Add(apeEmpleados);
            Controls.Add(label2);
            Controls.Add(nombreEmpleados);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizarCliente);
            Controls.Add(selectEmpleados);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EditarEmpleados";
            Text = "EditarEmpleados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox salarioEmpleados;
        private Label label4;
        private TextBox puestoEmpleados;
        private Label label3;
        private TextBox apeEmpleados;
        private Label label2;
        private TextBox nombreEmpleados;
        private PictureBox pictureBox1;
        private Button menuprincipal;
        private Button actualizarCliente;
        private ComboBox selectEmpleados;
        private Label label5;
        private Label label1;
    }
}