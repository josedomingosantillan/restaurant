namespace Restaurant
{
    partial class EditarComandas
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
            label4 = new Label();
            observacionesComanda = new TextBox();
            label3 = new Label();
            estadoComanda = new TextBox();
            label2 = new Label();
            totaComanda = new TextBox();
            pictureBox1 = new PictureBox();
            menuprincipal = new Button();
            actualizarCliente = new Button();
            selectComandas = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 373);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 56;
            label4.Text = "Observaciones:";
            // 
            // observacionesComanda
            // 
            observacionesComanda.Location = new Point(173, 367);
            observacionesComanda.Name = "observacionesComanda";
            observacionesComanda.Size = new Size(396, 27);
            observacionesComanda.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 304);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 54;
            label3.Text = "Estado:";
            // 
            // estadoComanda
            // 
            estadoComanda.Location = new Point(136, 298);
            estadoComanda.Name = "estadoComanda";
            estadoComanda.Size = new Size(433, 27);
            estadoComanda.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 233);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 52;
            label2.Text = "Total:";
            // 
            // totaComanda
            // 
            totaComanda.Location = new Point(136, 227);
            totaComanda.Name = "totaComanda";
            totaComanda.Size = new Size(433, 27);
            totaComanda.TabIndex = 51;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(667, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // menuprincipal
            // 
            menuprincipal.BackColor = Color.Gold;
            menuprincipal.Font = new Font("Arial Rounded MT Bold", 16.2F);
            menuprincipal.ForeColor = Color.White;
            menuprincipal.Location = new Point(137, 453);
            menuprincipal.Name = "menuprincipal";
            menuprincipal.Size = new Size(242, 49);
            menuprincipal.TabIndex = 49;
            menuprincipal.Text = "Regresar";
            menuprincipal.UseVisualStyleBackColor = false;
            menuprincipal.Click += menuprincipal_Click;
            // 
            // actualizarCliente
            // 
            actualizarCliente.Font = new Font("Arial Rounded MT Bold", 16.2F);
            actualizarCliente.Location = new Point(427, 453);
            actualizarCliente.Name = "actualizarCliente";
            actualizarCliente.Size = new Size(177, 49);
            actualizarCliente.TabIndex = 48;
            actualizarCliente.Text = "Actualizar";
            actualizarCliente.UseVisualStyleBackColor = true;
            actualizarCliente.Click += actualizarCliente_Click;
            // 
            // selectComandas
            // 
            selectComandas.FormattingEnabled = true;
            selectComandas.Location = new Point(195, 164);
            selectComandas.Name = "selectComandas";
            selectComandas.Size = new Size(374, 28);
            selectComandas.TabIndex = 47;
            selectComandas.Text = "Selecciona una Comanda.";
            selectComandas.SelectedIndexChanged += selectComandas_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F);
            label5.Location = new Point(17, 158);
            label5.Name = "label5";
            label5.Size = new Size(180, 34);
            label5.TabIndex = 46;
            label5.Text = "Comandas:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(874, 93);
            label1.TabIndex = 45;
            label1.Text = "Actualizar Comandas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditarComandas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 542);
            Controls.Add(label4);
            Controls.Add(observacionesComanda);
            Controls.Add(label3);
            Controls.Add(estadoComanda);
            Controls.Add(label2);
            Controls.Add(totaComanda);
            Controls.Add(pictureBox1);
            Controls.Add(menuprincipal);
            Controls.Add(actualizarCliente);
            Controls.Add(selectComandas);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EditarComandas";
            Text = "EditarComandas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox observacionesComanda;
        private Label label3;
        private TextBox estadoComanda;
        private Label label2;
        private TextBox totaComanda;
        private PictureBox pictureBox1;
        private Button menuprincipal;
        private Button actualizarCliente;
        private ComboBox selectComandas;
        private Label label5;
        private Label label1;
    }
}