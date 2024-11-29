namespace UI
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            label1 = new Label();
            btnMiembros = new Button();
            btnClases = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            pb_miembros = new PictureBox();
            pictureBox2 = new PictureBox();
            btnInscripcion = new Button();
            p_ventana = new Panel();
            pb_ventanaNormal = new PictureBox();
            pb_guardarVentana = new PictureBox();
            pictureBox3 = new PictureBox();
            pb_CerrarVentana = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            p_ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CerrarVentana).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 50F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 45);
            label1.Name = "label1";
            label1.Size = new Size(343, 82);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // btnMiembros
            // 
            btnMiembros.BackColor = Color.FromArgb(255, 128, 0);
            btnMiembros.FlatStyle = FlatStyle.Popup;
            btnMiembros.Font = new Font("Impact", 12F);
            btnMiembros.ForeColor = Color.White;
            btnMiembros.Location = new Point(50, 318);
            btnMiembros.Name = "btnMiembros";
            btnMiembros.Size = new Size(169, 39);
            btnMiembros.TabIndex = 1;
            btnMiembros.Text = "GESTIONAR MIEMBROS";
            btnMiembros.UseVisualStyleBackColor = false;
            btnMiembros.Click += btnMiembros_Click;
            // 
            // btnClases
            // 
            btnClases.BackColor = Color.MediumBlue;
            btnClases.FlatStyle = FlatStyle.Popup;
            btnClases.Font = new Font("Impact", 12F);
            btnClases.ForeColor = Color.White;
            btnClases.Location = new Point(273, 318);
            btnClases.Name = "btnClases";
            btnClases.Size = new Size(169, 39);
            btnClases.TabIndex = 2;
            btnClases.Text = "GESTIONAR CLASES";
            btnClases.UseVisualStyleBackColor = false;
            btnClases.Click += btnClases_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(260, 360);
            label2.Name = "label2";
            label2.Size = new Size(205, 100);
            label2.TabIndex = 4;
            label2.Text = "Gestion sobre las diferentes \r\nclases ofrecidas con detalles \r\ncomo horarios, \r\ncapacidad máxima y \r\nentrenadores a cargo.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Clases;
            pictureBox1.Location = new Point(273, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(479, 360);
            label3.Name = "label3";
            label3.Size = new Size(176, 40);
            label3.TabIndex = 50;
            label3.Text = "Clases que los miembros \r\npueden inscribirse\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 360);
            label4.Name = "label4";
            label4.Size = new Size(226, 100);
            label4.TabIndex = 51;
            label4.Text = "Gestion sobre nuevos miembros, \r\npodras agregar, \r\nmodificar y \r\neliminar miembros existentes.\r\n ";
            // 
            // pb_miembros
            // 
            pb_miembros.BackColor = Color.Transparent;
            pb_miembros.Image = Properties.Resources.Miembros;
            pb_miembros.Location = new Point(50, 141);
            pb_miembros.Name = "pb_miembros";
            pb_miembros.Size = new Size(169, 169);
            pb_miembros.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_miembros.TabIndex = 52;
            pb_miembros.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Inscripciones1;
            pictureBox2.Location = new Point(479, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(169, 169);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = Color.ForestGreen;
            btnInscripcion.FlatStyle = FlatStyle.Popup;
            btnInscripcion.Font = new Font("Impact", 12F);
            btnInscripcion.ForeColor = Color.White;
            btnInscripcion.Location = new Point(479, 318);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(169, 39);
            btnInscripcion.TabIndex = 54;
            btnInscripcion.Text = "INSCRIPCIÓN A CLASES";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click_1;
            // 
            // p_ventana
            // 
            p_ventana.BackColor = Color.White;
            p_ventana.Controls.Add(pb_ventanaNormal);
            p_ventana.Controls.Add(pb_guardarVentana);
            p_ventana.Controls.Add(pictureBox3);
            p_ventana.Controls.Add(pb_CerrarVentana);
            p_ventana.Dock = DockStyle.Top;
            p_ventana.Location = new Point(0, 0);
            p_ventana.Name = "p_ventana";
            p_ventana.Size = new Size(683, 26);
            p_ventana.TabIndex = 55;
            p_ventana.MouseDown += MoverPanel;
            // 
            // pb_ventanaNormal
            // 
            pb_ventanaNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_ventanaNormal.BackColor = Color.White;
            pb_ventanaNormal.Cursor = Cursors.Hand;
            pb_ventanaNormal.Image = Properties.Resources.Achicar1;
            pb_ventanaNormal.Location = new Point(609, -4);
            pb_ventanaNormal.Name = "pb_ventanaNormal";
            pb_ventanaNormal.Size = new Size(45, 33);
            pb_ventanaNormal.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ventanaNormal.TabIndex = 59;
            pb_ventanaNormal.TabStop = false;
            pb_ventanaNormal.Click += pb_ventanaNormal_Click;
            // 
            // pb_guardarVentana
            // 
            pb_guardarVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_guardarVentana.BackColor = Color.White;
            pb_guardarVentana.Cursor = Cursors.Hand;
            pb_guardarVentana.Image = Properties.Resources.Minimizar;
            pb_guardarVentana.Location = new Point(579, -2);
            pb_guardarVentana.Name = "pb_guardarVentana";
            pb_guardarVentana.Size = new Size(37, 28);
            pb_guardarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            pb_guardarVentana.TabIndex = 58;
            pb_guardarVentana.TabStop = false;
            pb_guardarVentana.Click += pb_guardarVentana_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.Maximizar;
            pictureBox3.Location = new Point(617, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pb_CerrarVentana
            // 
            pb_CerrarVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_CerrarVentana.BackColor = Color.White;
            pb_CerrarVentana.Cursor = Cursors.Hand;
            pb_CerrarVentana.Image = Properties.Resources.CerrarVentana;
            pb_CerrarVentana.Location = new Point(659, 3);
            pb_CerrarVentana.Name = "pb_CerrarVentana";
            pb_CerrarVentana.Size = new Size(20, 21);
            pb_CerrarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            pb_CerrarVentana.TabIndex = 56;
            pb_CerrarVentana.TabStop = false;
            pb_CerrarVentana.Click += pb_CerrarVentana_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(683, 480);
            Controls.Add(p_ventana);
            Controls.Add(btnInscripcion);
            Controls.Add(pictureBox2);
            Controls.Add(pb_miembros);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnClases);
            Controls.Add(btnMiembros);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "Gestion de Gimnasio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            p_ventana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CerrarVentana).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMiembros;
        private Button btnClases;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private PictureBox pb_miembros;
        private PictureBox pictureBox2;
        private Button btnInscripcion;
        private Panel p_ventana;
        private PictureBox pb_CerrarVentana;
        private PictureBox pictureBox3;
        private PictureBox pb_guardarVentana;
        private PictureBox pb_ventanaNormal;
    }
}
