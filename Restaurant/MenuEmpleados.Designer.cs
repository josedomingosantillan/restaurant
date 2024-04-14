namespace Restaurant
{
    partial class MenuEmpleados
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
            consultar_emp = new Button();
            insertar_emp = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuprincipal = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // consultar_emp
            // 
            consultar_emp.Font = new Font("Arial Rounded MT Bold", 16.2F);
            consultar_emp.Location = new Point(274, 95);
            consultar_emp.Name = "consultar_emp";
            consultar_emp.Size = new Size(176, 86);
            consultar_emp.TabIndex = 8;
            consultar_emp.Text = "Consultar Empleados";
            consultar_emp.UseVisualStyleBackColor = true;
            consultar_emp.Click += consultar_emp_Click;
            // 
            // insertar_emp
            // 
            insertar_emp.Font = new Font("Arial Rounded MT Bold", 16.2F);
            insertar_emp.Location = new Point(25, 95);
            insertar_emp.Name = "insertar_emp";
            insertar_emp.Size = new Size(176, 86);
            insertar_emp.TabIndex = 7;
            insertar_emp.Text = "Agregar Empleados";
            insertar_emp.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(525, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(534, 46);
            label1.TabIndex = 5;
            label1.Text = "Empleados del Restaurant";
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(525, 309);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 10;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button1.Location = new Point(274, 244);
            button1.Name = "button1";
            button1.Size = new Size(176, 86);
            button1.TabIndex = 12;
            button1.Text = "Eliminar Empleados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 16.2F);
            button2.Location = new Point(25, 244);
            button2.Name = "button2";
            button2.Size = new Size(176, 86);
            button2.TabIndex = 11;
            button2.Text = "Editar Empleados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(menuprincipal);
            Controls.Add(consultar_emp);
            Controls.Add(insertar_emp);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MenuEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuEmpleados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button consultar_emp;
        private Button insertar_emp;
        private PictureBox pictureBox1;
        private Label label1;
        private Button menuprincipal;
        private Button button1;
        private Button button2;
    }
}