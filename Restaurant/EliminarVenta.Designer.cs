namespace Restaurant
{
    partial class EliminarVenta
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
            pictureBox1 = new PictureBox();
            menuprincipal = new Button();
            actualizaruser = new Button();
            selectVentas = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(618, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(126, 324);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 60;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // actualizaruser
            // 
            actualizaruser.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizaruser.Location = new Point(416, 324);
            actualizaruser.Name = "actualizaruser";
            actualizaruser.Size = new Size(177, 49);
            actualizaruser.TabIndex = 59;
            actualizaruser.Text = "Eliminar";
            actualizaruser.UseVisualStyleBackColor = true;
            actualizaruser.Click += actualizaruser_Click;
            // 
            // selectVentas
            // 
            selectVentas.FormattingEnabled = true;
            selectVentas.Location = new Point(173, 203);
            selectVentas.Name = "selectVentas";
            selectVentas.Size = new Size(397, 28);
            selectVentas.TabIndex = 58;
            selectVentas.Text = "Selecciona una Venta.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(41, 197);
            label5.Name = "label5";
            label5.Size = new Size(126, 34);
            label5.TabIndex = 57;
            label5.Text = "Ventas:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(608, 93);
            label1.TabIndex = 56;
            label1.Text = "Eliminar Venta";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EliminarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 455);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizaruser);
            Controls.Add(selectVentas);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EliminarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarVenta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button menuprincipal;
        private Button actualizaruser;
        private ComboBox selectVentas;
        private Label label5;
        private Label label1;
    }
}