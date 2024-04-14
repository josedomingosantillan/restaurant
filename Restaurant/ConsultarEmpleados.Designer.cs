namespace Restaurant
{
    partial class ConsultarEmpleados
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
            menuprincipal = new Button();
            insertar_emp = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            idempleado = new TextBox();
            empleados = new DataGridView();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button5 = new Button();
            labelMaximo = new Label();
            labelMinimo = new Label();
            labelPromedio = new Label();
            labelSuma = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleados).BeginInit();
            SuspendLayout();
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(546, 345);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 15;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // insertar_emp
            // 
            insertar_emp.Font = new Font("Arial Rounded MT Bold", 16.2F);
            insertar_emp.Location = new Point(15, 108);
            insertar_emp.Name = "insertar_emp";
            insertar_emp.Size = new Size(137, 42);
            insertar_emp.TabIndex = 13;
            insertar_emp.Text = "General";
            insertar_emp.UseVisualStyleBackColor = true;
            insertar_emp.Click += insertar_emp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(546, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(735, 46);
            label1.TabIndex = 11;
            label1.Text = "Consultar Empleados del Restaurant";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(370, 108);
            button1.Name = "button1";
            button1.Size = new Size(170, 42);
            button1.TabIndex = 16;
            button1.Text = "Específico";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // idempleado
            // 
            idempleado.Location = new Point(200, 120);
            idempleado.Name = "idempleado";
            idempleado.Size = new Size(164, 27);
            idempleado.TabIndex = 17;
            // 
            // empleados
            // 
            empleados.AllowUserToAddRows = false;
            empleados.AllowUserToDeleteRows = false;
            empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empleados.Location = new Point(15, 165);
            empleados.Name = "empleados";
            empleados.ReadOnly = true;
            empleados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            empleados.ScrollBars = ScrollBars.Horizontal;
            empleados.Size = new Size(525, 240);
            empleados.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 94);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 19;
            label2.Text = "No. de Empleado:";
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button4.Location = new Point(617, 459);
            button4.Name = "button4";
            button4.Size = new Size(146, 42);
            button4.TabIndex = 43;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button3.Location = new Point(425, 459);
            button3.Name = "button3";
            button3.Size = new Size(148, 42);
            button3.TabIndex = 42;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(200, 459);
            button2.Name = "button2";
            button2.Size = new Size(145, 42);
            button2.TabIndex = 41;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button5.Location = new Point(18, 459);
            button5.Name = "button5";
            button5.Size = new Size(144, 42);
            button5.TabIndex = 40;
            button5.Text = "Calcular";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // labelMaximo
            // 
            labelMaximo.AutoSize = true;
            labelMaximo.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMaximo.Location = new Point(617, 422);
            labelMaximo.Name = "labelMaximo";
            labelMaximo.Size = new Size(149, 21);
            labelMaximo.TabIndex = 39;
            labelMaximo.Text = "Sueldo Máximo:";
            // 
            // labelMinimo
            // 
            labelMinimo.AutoSize = true;
            labelMinimo.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinimo.Location = new Point(425, 422);
            labelMinimo.Name = "labelMinimo";
            labelMinimo.Size = new Size(145, 21);
            labelMinimo.TabIndex = 38;
            labelMinimo.Text = "Sueldo Mínimo:";
            // 
            // labelPromedio
            // 
            labelPromedio.AutoSize = true;
            labelPromedio.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPromedio.Location = new Point(200, 422);
            labelPromedio.Name = "labelPromedio";
            labelPromedio.Size = new Size(204, 21);
            labelPromedio.TabIndex = 37;
            labelPromedio.Text = "Promedio de Sueldos:";
            // 
            // labelSuma
            // 
            labelSuma.AutoSize = true;
            labelSuma.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSuma.Location = new Point(18, 422);
            labelSuma.Name = "labelSuma";
            labelSuma.Size = new Size(136, 21);
            labelSuma.TabIndex = 36;
            labelSuma.Text = "Total Sueldos:";
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(546, 280);
            button6.Name = "button6";
            button6.Size = new Size(242, 49);
            button6.TabIndex = 45;
            button6.Text = "Generar PDF";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // ConsultarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 509);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(labelMaximo);
            Controls.Add(labelMinimo);
            Controls.Add(labelPromedio);
            Controls.Add(labelSuma);
            Controls.Add(label2);
            Controls.Add(empleados);
            Controls.Add(idempleado);
            Controls.Add(button1);
            Controls.Add(menuprincipal);
            Controls.Add(insertar_emp);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ConsultarEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarEmpleados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuprincipal;
        private Button insertar_emp;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private TextBox idempleado;
        private DataGridView empleados;
        private Label label2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Label labelMaximo;
        private Label labelMinimo;
        private Label labelPromedio;
        private Label labelSuma;
        private Button button6;
    }
}