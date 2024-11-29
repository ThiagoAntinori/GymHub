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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 50F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 9);
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
            btnMiembros.Location = new Point(51, 282);
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
            btnClases.Location = new Point(274, 282);
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
            label2.Location = new Point(261, 324);
            label2.Name = "label2";
            label2.Size = new Size(205, 100);
            label2.TabIndex = 4;
            label2.Text = "Gestion sobre las diferentes \r\nclases ofrecidas con detalles \r\ncomo horarios, \r\ncapacidad máxima y \r\nentrenadores a cargo.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Clases;
            pictureBox1.Location = new Point(274, 105);
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
            label3.Location = new Point(480, 324);
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
            label4.Location = new Point(25, 324);
            label4.Name = "label4";
            label4.Size = new Size(226, 100);
            label4.TabIndex = 51;
            label4.Text = "Gestion sobre nuevos miembros, \r\npodras agregar, \r\nmodificar y \r\neliminar miembros existentes.\r\n ";
            // 
            // pb_miembros
            // 
            pb_miembros.BackColor = Color.Transparent;
            pb_miembros.Image = Properties.Resources.Miembros;
            pb_miembros.Location = new Point(51, 105);
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
            pictureBox2.Location = new Point(480, 105);
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
            btnInscripcion.Location = new Point(480, 282);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(169, 39);
            btnInscripcion.TabIndex = 54;
            btnInscripcion.Text = "INSCRIPCIÓN A CLASES";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click_1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(683, 442);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "Gestion de Gimnasio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
    }
}
