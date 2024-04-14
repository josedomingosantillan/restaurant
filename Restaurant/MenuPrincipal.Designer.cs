namespace Restaurant
{
    partial class MenuPrincipal
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            empleados = new Button();
            clientes = new Button();
            comandas = new Button();
            ventas = new Button();
            proveedores = new Button();
            inventario = new Button();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 24);
            label1.Name = "label1";
            label1.Size = new Size(607, 46);
            label1.TabIndex = 1;
            label1.Text = "Menú Principal del Restaurant";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(524, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // empleados
            // 
            empleados.Font = new Font("Arial Rounded MT Bold", 16.2F);
            empleados.Location = new Point(24, 110);
            empleados.Name = "empleados";
            empleados.Size = new Size(176, 86);
            empleados.TabIndex = 3;
            empleados.Text = "Empleados";
            empleados.UseVisualStyleBackColor = true;
            empleados.Click += empleados_Click;
            // 
            // clientes
            // 
            clientes.Font = new Font("Arial Rounded MT Bold", 16.2F);
            clientes.Location = new Point(273, 110);
            clientes.Name = "clientes";
            clientes.Size = new Size(176, 86);
            clientes.TabIndex = 4;
            clientes.Text = "Clientes";
            clientes.UseVisualStyleBackColor = true;
            clientes.Click += clientes_Click;
            // 
            // comandas
            // 
            comandas.Font = new Font("Arial Rounded MT Bold", 16.2F);
            comandas.Location = new Point(24, 212);
            comandas.Name = "comandas";
            comandas.Size = new Size(176, 86);
            comandas.TabIndex = 5;
            comandas.Text = "Comandas";
            comandas.UseVisualStyleBackColor = true;
            comandas.Click += comandas_Click;
            // 
            // ventas
            // 
            ventas.Font = new Font("Arial Rounded MT Bold", 16.2F);
            ventas.Location = new Point(273, 212);
            ventas.Name = "ventas";
            ventas.Size = new Size(176, 86);
            ventas.TabIndex = 6;
            ventas.Text = "Ventas";
            ventas.UseVisualStyleBackColor = true;
            ventas.Click += ventas_Click;
            // 
            // proveedores
            // 
            proveedores.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            proveedores.Location = new Point(24, 315);
            proveedores.Name = "proveedores";
            proveedores.Size = new Size(176, 86);
            proveedores.TabIndex = 7;
            proveedores.Text = "Proveedores";
            proveedores.UseVisualStyleBackColor = true;
            proveedores.Click += proveedores_Click;
            // 
            // inventario
            // 
            inventario.Font = new Font("Arial Rounded MT Bold", 16.2F);
            inventario.Location = new Point(273, 315);
            inventario.Name = "inventario";
            inventario.Size = new Size(176, 86);
            inventario.TabIndex = 8;
            inventario.Text = "Inventario";
            inventario.UseVisualStyleBackColor = true;
            inventario.Click += inventario_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Red;
            logout.Font = new Font("Arial Rounded MT Bold", 16.2F);
            logout.ForeColor = Color.White;
            logout.Location = new Point(524, 334);
            logout.Name = "logout";
            logout.Size = new Size(242, 49);
            logout.TabIndex = 9;
            logout.Text = "Cerrar Sesión";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(inventario);
            Controls.Add(proveedores);
            Controls.Add(ventas);
            Controls.Add(comandas);
            Controls.Add(clientes);
            Controls.Add(empleados);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button empleados;
        private Button clientes;
        private Button comandas;
        private Button ventas;
        private Button proveedores;
        private Button inventario;
        private Button logout;
    }
}