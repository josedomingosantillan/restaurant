namespace Restaurant
{
    partial class EliminarClientes
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
            selectUsuarios = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            actualizaruser = new Button();
            menuprincipal = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // selectUsuarios
            // 
            selectUsuarios.FormattingEnabled = true;
            selectUsuarios.Location = new Point(191, 164);
            selectUsuarios.Name = "selectUsuarios";
            selectUsuarios.Size = new Size(397, 28);
            selectUsuarios.TabIndex = 29;
            selectUsuarios.Text = "Selecciona un Cliente.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(36, 158);
            label5.Name = "label5";
            label5.Size = new Size(143, 34);
            label5.TabIndex = 28;
            label5.Text = "Clientes:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(699, 93);
            label1.TabIndex = 27;
            label1.Text = "Eliminar Clientes";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // actualizaruser
            // 
            actualizaruser.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizaruser.Location = new Point(411, 259);
            actualizaruser.Name = "actualizaruser";
            actualizaruser.Size = new Size(177, 49);
            actualizaruser.TabIndex = 30;
            actualizaruser.Text = "Eliminar";
            actualizaruser.UseVisualStyleBackColor = true;
            actualizaruser.Click += actualizaruser_Click;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(121, 259);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 31;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(604, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // EliminarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 463);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizaruser);
            Controls.Add(selectUsuarios);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EliminarClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarClientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectUsuarios;
        private Label label5;
        private Label label1;
        private Button actualizaruser;
        private Button menuprincipal;
        private PictureBox pictureBox1;
    }
}