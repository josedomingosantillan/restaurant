namespace Restaurant
{
    partial class EditarVenta
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
            subtotalVenta = new TextBox();
            label4 = new Label();
            precioVenta = new TextBox();
            label3 = new Label();
            cantidadVenta = new TextBox();
            label2 = new Label();
            productoVenta = new TextBox();
            pictureBox1 = new PictureBox();
            menuprincipal = new Button();
            actualizarCliente = new Button();
            selectVentas = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            label7 = new Label();
            descuentoVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 424);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 60;
            label6.Text = "Subtotal:";
            // 
            // subtotalVenta
            // 
            subtotalVenta.Location = new Point(207, 418);
            subtotalVenta.Name = "subtotalVenta";
            subtotalVenta.Size = new Size(365, 27);
            subtotalVenta.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 357);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 58;
            label4.Text = "Precio:";
            // 
            // precioVenta
            // 
            precioVenta.Location = new Point(139, 351);
            precioVenta.Name = "precioVenta";
            precioVenta.Size = new Size(433, 27);
            precioVenta.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 288);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 56;
            label3.Text = "Cantidad:";
            // 
            // cantidadVenta
            // 
            cantidadVenta.Location = new Point(139, 282);
            cantidadVenta.Name = "cantidadVenta";
            cantidadVenta.Size = new Size(433, 27);
            cantidadVenta.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 217);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 54;
            label2.Text = "Producto:";
            // 
            // productoVenta
            // 
            productoVenta.Location = new Point(139, 211);
            productoVenta.Name = "productoVenta";
            productoVenta.Size = new Size(433, 27);
            productoVenta.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(636, 142);
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
            menuprincipal.Location = new Point(136, 550);
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
            actualizarCliente.Location = new Point(426, 550);
            actualizarCliente.Name = "actualizarCliente";
            actualizarCliente.Size = new Size(177, 49);
            actualizarCliente.TabIndex = 50;
            actualizarCliente.Text = "Actualizar";
            actualizarCliente.UseVisualStyleBackColor = true;
            actualizarCliente.Click += actualizarCliente_Click;
            // 
            // selectVentas
            // 
            selectVentas.FormattingEnabled = true;
            selectVentas.Location = new Point(152, 148);
            selectVentas.Name = "selectVentas";
            selectVentas.Size = new Size(420, 28);
            selectVentas.TabIndex = 49;
            selectVentas.Text = "Selecciona una Venta.";
            selectVentas.SelectedIndexChanged += selectVentas_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(20, 142);
            label5.Name = "label5";
            label5.Size = new Size(126, 34);
            label5.TabIndex = 48;
            label5.Text = "Ventas:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 8);
            label1.Name = "label1";
            label1.Size = new Size(729, 93);
            label1.TabIndex = 47;
            label1.Text = "Actualizar Ventas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 487);
            label7.Name = "label7";
            label7.Size = new Size(111, 21);
            label7.TabIndex = 62;
            label7.Text = "Descuento:";
            // 
            // descuentoVenta
            // 
            descuentoVenta.Location = new Point(207, 481);
            descuentoVenta.Name = "descuentoVenta";
            descuentoVenta.Size = new Size(365, 27);
            descuentoVenta.TabIndex = 61;
            // 
            // EditarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 621);
            Controls.Add(label7);
            Controls.Add(descuentoVenta);
            Controls.Add(label6);
            Controls.Add(subtotalVenta);
            Controls.Add(label4);
            Controls.Add(precioVenta);
            Controls.Add(label3);
            Controls.Add(cantidadVenta);
            Controls.Add(label2);
            Controls.Add(productoVenta);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizarCliente);
            Controls.Add(selectVentas);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EditarVenta";
            Text = "EditarVenta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox subtotalVenta;
        private Label label4;
        private TextBox precioVenta;
        private Label label3;
        private TextBox cantidadVenta;
        private Label label2;
        private TextBox productoVenta;
        private PictureBox pictureBox1;
        private Button menuprincipal;
        private Button actualizarCliente;
        private ComboBox selectVentas;
        private Label label5;
        private Label label1;
        private Label label7;
        private TextBox descuentoVenta;
    }
}