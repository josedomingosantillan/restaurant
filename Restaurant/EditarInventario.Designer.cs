namespace Restaurant
{
    partial class EditarInventario
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
            precioProducto = new TextBox();
            label4 = new Label();
            cantProducto = new TextBox();
            label3 = new Label();
            descProducto = new TextBox();
            label2 = new Label();
            nombreProducto = new TextBox();
            pictureBox1 = new PictureBox();
            menuprincipal = new Button();
            actualizarCliente = new Button();
            selectProductos = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 440);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 60;
            label6.Text = "Precio:";
            // 
            // precioProducto
            // 
            precioProducto.Location = new Point(98, 434);
            precioProducto.Name = "precioProducto";
            precioProducto.Size = new Size(472, 27);
            precioProducto.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 373);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 58;
            label4.Text = "Cantidad:";
            // 
            // cantProducto
            // 
            cantProducto.Location = new Point(119, 367);
            cantProducto.Name = "cantProducto";
            cantProducto.Size = new Size(451, 27);
            cantProducto.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 304);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 56;
            label3.Text = "Descripción";
            // 
            // descProducto
            // 
            descProducto.Location = new Point(141, 298);
            descProducto.Name = "descProducto";
            descProducto.Size = new Size(429, 27);
            descProducto.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 233);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 54;
            label2.Text = "Nombre:";
            // 
            // nombreProducto
            // 
            nombreProducto.Location = new Point(137, 227);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Size = new Size(433, 27);
            nombreProducto.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(624, 123);
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
            menuprincipal.Location = new Point(137, 506);
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
            actualizarCliente.Location = new Point(427, 506);
            actualizarCliente.Name = "actualizarCliente";
            actualizarCliente.Size = new Size(177, 49);
            actualizarCliente.TabIndex = 50;
            actualizarCliente.Text = "Actualizar";
            actualizarCliente.UseVisualStyleBackColor = true;
            actualizarCliente.Click += actualizarCliente_Click;
            // 
            // selectProductos
            // 
            selectProductos.FormattingEnabled = true;
            selectProductos.Location = new Point(192, 164);
            selectProductos.Name = "selectProductos";
            selectProductos.Size = new Size(378, 28);
            selectProductos.TabIndex = 49;
            selectProductos.Text = "Selecciona un Producto.";
            selectProductos.SelectedIndexChanged += selectProductos_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(18, 158);
            label5.Name = "label5";
            label5.Size = new Size(175, 34);
            label5.TabIndex = 48;
            label5.Text = "Productos:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(852, 93);
            label1.TabIndex = 47;
            label1.Text = "Actualizar Inventario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditarInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 576);
            Controls.Add(label6);
            Controls.Add(precioProducto);
            Controls.Add(label4);
            Controls.Add(cantProducto);
            Controls.Add(label3);
            Controls.Add(descProducto);
            Controls.Add(label2);
            Controls.Add(nombreProducto);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizarCliente);
            Controls.Add(selectProductos);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EditarInventario";
            Text = "EditarInventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox precioProducto;
        private Label label4;
        private TextBox cantProducto;
        private Label label3;
        private TextBox descProducto;
        private Label label2;
        private TextBox nombreProducto;
        private PictureBox pictureBox1;
        private Button menuprincipal;
        private Button actualizarCliente;
        private ComboBox selectProductos;
        private Label label5;
        private Label label1;
    }
}