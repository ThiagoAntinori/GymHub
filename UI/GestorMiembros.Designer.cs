namespace UI
{
    partial class GestorMiembros
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorMiembros));
            label1 = new Label();
            cb_membresia = new ComboBox();
            dtp_nacimiento = new DateTimePicker();
            txt_nombreApellido = new TextBox();
            txt_correo = new TextBox();
            btn_Agregar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            cb_modMembresia = new ComboBox();
            label5 = new Label();
            txt_modCorreo = new TextBox();
            btn_Modificar = new Button();
            txt_modId = new TextBox();
            label7 = new Label();
            btn_Eliminar = new Button();
            txt_elimId = new TextBox();
            label12 = new Label();
            dgv_miembros = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel1 = new Panel();
            Boton_Salir = new Label();
            label19 = new Label();
            pictureBox2 = new PictureBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            pb_miembros = new PictureBox();
            pb_home = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_miembros).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_home).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(165, 169);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 14;
            label1.Text = "MEMBRESIA:";
            // 
            // cb_membresia
            // 
            cb_membresia.FormattingEnabled = true;
            cb_membresia.Location = new Point(251, 168);
            cb_membresia.Name = "cb_membresia";
            cb_membresia.Size = new Size(200, 23);
            cb_membresia.TabIndex = 13;
            // 
            // dtp_nacimiento
            // 
            dtp_nacimiento.Location = new Point(251, 107);
            dtp_nacimiento.Name = "dtp_nacimiento";
            dtp_nacimiento.Size = new Size(200, 23);
            dtp_nacimiento.TabIndex = 12;
            // 
            // txt_nombreApellido
            // 
            txt_nombreApellido.Location = new Point(251, 74);
            txt_nombreApellido.Name = "txt_nombreApellido";
            txt_nombreApellido.Size = new Size(200, 23);
            txt_nombreApellido.TabIndex = 9;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(251, 138);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(200, 23);
            txt_correo.TabIndex = 7;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(255, 128, 0);
            btn_Agregar.FlatStyle = FlatStyle.Popup;
            btn_Agregar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = Color.White;
            btn_Agregar.Location = new Point(251, 208);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(200, 31);
            btn_Agregar.TabIndex = 6;
            btn_Agregar.Text = "AGREGAR";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            btn_Agregar.MouseEnter += Mouse_Enter_PB;
            btn_Agregar.MouseLeave += Mouse_Leave_PB;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(98, 139);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 3;
            label4.Text = "CORREO ELECTRONICO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(114, 75);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE Y APELLIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 108);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "NACIMIENTO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(164, 396);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 15;
            label6.Text = "MEMBRESIA:";
            // 
            // cb_modMembresia
            // 
            cb_modMembresia.FormattingEnabled = true;
            cb_modMembresia.Location = new Point(251, 396);
            cb_modMembresia.Name = "cb_modMembresia";
            cb_modMembresia.Size = new Size(200, 23);
            cb_modMembresia.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(98, 360);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 25;
            label5.Text = "CORREO ELECTRONICO:";
            // 
            // txt_modCorreo
            // 
            txt_modCorreo.Location = new Point(251, 360);
            txt_modCorreo.Name = "txt_modCorreo";
            txt_modCorreo.Size = new Size(200, 23);
            txt_modCorreo.TabIndex = 24;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.FromArgb(255, 128, 0);
            btn_Modificar.FlatStyle = FlatStyle.Popup;
            btn_Modificar.Font = new Font("Impact", 12F);
            btn_Modificar.ForeColor = Color.White;
            btn_Modificar.Location = new Point(251, 437);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(200, 31);
            btn_Modificar.TabIndex = 23;
            btn_Modificar.Text = "MODIFICAR";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            btn_Modificar.MouseEnter += Mouse_Enter_PB;
            btn_Modificar.MouseLeave += Mouse_Leave_PB;
            // 
            // txt_modId
            // 
            txt_modId.Location = new Point(251, 326);
            txt_modId.Name = "txt_modId";
            txt_modId.Size = new Size(200, 23);
            txt_modId.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(136, 326);
            label7.Name = "label7";
            label7.Size = new Size(115, 20);
            label7.TabIndex = 13;
            label7.Text = "ID DEL MIEMBRO:";
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(255, 128, 0);
            btn_Eliminar.FlatStyle = FlatStyle.Popup;
            btn_Eliminar.Font = new Font("Impact", 12F);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.Location = new Point(780, 438);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(117, 30);
            btn_Eliminar.TabIndex = 27;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            btn_Eliminar.MouseEnter += Mouse_Enter_PB;
            btn_Eliminar.MouseLeave += Mouse_Leave_PB;
            // 
            // txt_elimId
            // 
            txt_elimId.Location = new Point(555, 448);
            txt_elimId.Name = "txt_elimId";
            txt_elimId.Size = new Size(176, 23);
            txt_elimId.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Impact", 12F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(470, 450);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 25;
            label12.Text = "ID Miembro:";
            // 
            // dgv_miembros
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgv_miembros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_miembros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_miembros.BackgroundColor = SystemColors.Info;
            dgv_miembros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_miembros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_miembros.ColumnHeadersHeight = 28;
            dgv_miembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_miembros.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_miembros.EnableHeadersVisualStyles = false;
            dgv_miembros.Location = new Point(472, 64);
            dgv_miembros.Name = "dgv_miembros";
            dgv_miembros.RowHeadersVisible = false;
            dgv_miembros.Size = new Size(650, 322);
            dgv_miembros.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label8.ForeColor = Color.White;
            label8.Location = new Point(136, 16);
            label8.Name = "label8";
            label8.Size = new Size(153, 45);
            label8.TabIndex = 31;
            label8.Text = "AGREGAR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(287, 16);
            label9.Name = "label9";
            label9.Size = new Size(160, 45);
            label9.TabIndex = 32;
            label9.Text = "MIEMBRO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(288, 268);
            label10.Name = "label10";
            label10.Size = new Size(160, 45);
            label10.TabIndex = 34;
            label10.Text = "MIEMBRO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label11.ForeColor = Color.White;
            label11.Location = new Point(106, 268);
            label11.Name = "label11";
            label11.Size = new Size(183, 45);
            label11.TabIndex = 33;
            label11.Text = "MODIFICAR";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Impact", 20.25F, FontStyle.Italic | FontStyle.Underline);
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(584, 397);
            label13.Name = "label13";
            label13.Size = new Size(117, 34);
            label13.TabIndex = 36;
            label13.Text = "MIEMBRO";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Impact", 20.25F, FontStyle.Italic | FontStyle.Underline);
            label14.ForeColor = Color.White;
            label14.Location = new Point(470, 397);
            label14.Name = "label14";
            label14.Size = new Size(115, 34);
            label14.TabIndex = 35;
            label14.Text = "ELIMINAR";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Impact", 27.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(470, 16);
            label15.Name = "label15";
            label15.Size = new Size(307, 45);
            label15.TabIndex = 37;
            label15.Text = "LISTA DE MIEMBROS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(Boton_Salir);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pb_miembros);
            panel1.Controls.Add(pb_home);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(92, 494);
            panel1.TabIndex = 38;
            // 
            // Boton_Salir
            // 
            Boton_Salir.AutoSize = true;
            Boton_Salir.BackColor = Color.Transparent;
            Boton_Salir.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Boton_Salir.ForeColor = Color.White;
            Boton_Salir.Location = new Point(6, 434);
            Boton_Salir.Name = "Boton_Salir";
            Boton_Salir.Size = new Size(79, 36);
            Boton_Salir.TabIndex = 42;
            Boton_Salir.Text = "SALIR";
            Boton_Salir.Click += Boton_Salir_Click;
            Boton_Salir.MouseEnter += Mouse_Enter_PB;
            Boton_Salir.MouseLeave += Mouse_Leave_PB;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(0, 360);
            label19.Name = "label19";
            label19.Size = new Size(94, 20);
            label19.TabIndex = 41;
            label19.Text = "INSCRIPCION";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Inscripciones1;
            pictureBox2.Location = new Point(12, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseEnter += Mouse_Enter_PB;
            pictureBox2.MouseLeave += Mouse_Leave_PB;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(20, 262);
            label18.Name = "label18";
            label18.Size = new Size(54, 20);
            label18.TabIndex = 40;
            label18.Text = "CLASES";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(7, 163);
            label17.Name = "label17";
            label17.Size = new Size(78, 20);
            label17.TabIndex = 39;
            label17.Text = "MIEMBROS";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(20, 64);
            label16.Name = "label16";
            label16.Size = new Size(51, 20);
            label16.TabIndex = 39;
            label16.Text = "INICIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Clases;
            pictureBox1.Location = new Point(11, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += Mouse_Enter_PB;
            pictureBox1.MouseLeave += Mouse_Leave_PB;
            // 
            // pb_miembros
            // 
            pb_miembros.Image = Properties.Resources.Miembros;
            pb_miembros.Location = new Point(10, 101);
            pb_miembros.Name = "pb_miembros";
            pb_miembros.Size = new Size(70, 70);
            pb_miembros.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_miembros.TabIndex = 39;
            pb_miembros.TabStop = false;
            pb_miembros.Click += pb_miembros_Click;
            pb_miembros.MouseEnter += Mouse_Enter_PB;
            pb_miembros.MouseLeave += Mouse_Leave_PB;
            // 
            // pb_home
            // 
            pb_home.Image = Properties.Resources.Home;
            pb_home.Location = new Point(10, 3);
            pb_home.Name = "pb_home";
            pb_home.Size = new Size(70, 70);
            pb_home.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_home.TabIndex = 0;
            pb_home.TabStop = false;
            pb_home.Click += pb_home_Click;
            pb_home.MouseEnter += Mouse_Enter_PB;
            pb_home.MouseLeave += Mouse_Leave_PB;
            // 
            // GestorMiembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1142, 494);
            Controls.Add(panel1);
            Controls.Add(label15);
            Controls.Add(btn_Eliminar);
            Controls.Add(label13);
            Controls.Add(txt_elimId);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(cb_modMembresia);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txt_modCorreo);
            Controls.Add(btn_Modificar);
            Controls.Add(dgv_miembros);
            Controls.Add(txt_modId);
            Controls.Add(cb_membresia);
            Controls.Add(label7);
            Controls.Add(dtp_nacimiento);
            Controls.Add(txt_nombreApellido);
            Controls.Add(txt_correo);
            Controls.Add(btn_Agregar);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestorMiembros";
            Text = "Gestion de Gimnasio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_miembros).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_home).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_correo;
        private Button btn_Agregar;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtp_nacimiento;
        private Label label1;
        private ComboBox cb_membresia;
        private Label label5;
        private TextBox txt_modCorreo;
        private Button btn_Modificar;
        private TextBox txt_modId;
        private Label label7;
        private Label label6;
        private ComboBox cb_modMembresia;
        private Button btn_Eliminar;
        private TextBox txt_elimId;
        private Label label12;
        private DataGridView dgv_miembros;
        protected TextBox txt_nombreApellido;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panel1;
        private PictureBox pb_home;
        private PictureBox pictureBox1;
        private PictureBox pb_miembros;
        private Label label18;
        private Label label17;
        private Label label16;
        private PictureBox pictureBox2;
        private Label label19;
        private Label Boton_Salir;
    }
}