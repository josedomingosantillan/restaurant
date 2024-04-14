namespace Restaurant
{
    partial class EditarClientes
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
            actualizarCliente = new Button();
            selectClientes = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            nombreCliente = new TextBox();
            label3 = new Label();
            apeCliente = new TextBox();
            label4 = new Label();
            telCliente = new TextBox();
            label6 = new Label();
            emailcliente = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(158, 506);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 36;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // actualizarCliente
            // 
            actualizarCliente.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizarCliente.Location = new Point(448, 506);
            actualizarCliente.Name = "actualizarCliente";
            actualizarCliente.Size = new Size(177, 49);
            actualizarCliente.TabIndex = 35;
            actualizarCliente.Text = "Actualizar";
            actualizarCliente.UseVisualStyleBackColor = true;
            actualizarCliente.Click += actualizarCliente_Click;
            // 
            // selectClientes
            // 
            selectClientes.FormattingEnabled = true;
            selectClientes.Location = new Point(194, 164);
            selectClientes.Name = "selectClientes";
            selectClientes.Size = new Size(397, 28);
            selectClientes.TabIndex = 34;
            selectClientes.Text = "Selecciona un Cliente.";
            selectClientes.SelectedIndexChanged += selectUsuarios_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(39, 158);
            label5.Name = "label5";
            label5.Size = new Size(143, 34);
            label5.TabIndex = 33;
            label5.Text = "Clientes:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 9);
            label1.Name = "label1";
            label1.Size = new Size(777, 93);
            label1.TabIndex = 32;
            label1.Text = "Actualizar Clientes";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(689, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 233);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 40;
            label2.Text = "Nombre:";
            // 
            // nombreCliente
            // 
            nombreCliente.Location = new Point(158, 227);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.Size = new Size(433, 27);
            nombreCliente.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 304);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 42;
            label3.Text = "Apellido:";
            // 
            // apeCliente
            // 
            apeCliente.Location = new Point(158, 298);
            apeCliente.Name = "apeCliente";
            apeCliente.Size = new Size(433, 27);
            apeCliente.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 373);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 44;
            label4.Text = "Teléfono:";
            // 
            // telCliente
            // 
            telCliente.Location = new Point(158, 367);
            telCliente.Name = "telCliente";
            telCliente.Size = new Size(433, 27);
            telCliente.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 440);
            label6.Name = "label6";
            label6.Size = new Size(184, 21);
            label6.TabIndex = 46;
            label6.Text = "Correo electrónico:";
            // 
            // emailcliente
            // 
            emailcliente.Location = new Point(226, 434);
            emailcliente.Name = "emailcliente";
            emailcliente.Size = new Size(365, 27);
            emailcliente.TabIndex = 45;
            // 
            // EditarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 598);
            Controls.Add(label6);
            Controls.Add(emailcliente);
            Controls.Add(label4);
            Controls.Add(telCliente);
            Controls.Add(label3);
            Controls.Add(apeCliente);
            Controls.Add(label2);
            Controls.Add(nombreCliente);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizarCliente);
            Controls.Add(selectClientes);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EditarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarClientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button menuprincipal;
        private Button actualizarCliente;
        private ComboBox selectClientes;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox nombreCliente;
        private Label label3;
        private TextBox apeCliente;
        private Label label4;
        private TextBox telCliente;
        private Label label6;
        private TextBox emailcliente;
    }
}