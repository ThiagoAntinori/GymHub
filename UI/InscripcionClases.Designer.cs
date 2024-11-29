namespace UI
{
    partial class InscripcionClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionClases));
            label1 = new Label();
            cmbClaseInscribir = new ComboBox();
            dtpVencimiento = new DateTimePicker();
            btnAgregar = new Button();
            label3 = new Label();
            label2 = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtIdMiembroEliminar = new TextBox();
            label12 = new Label();
            dgvInscripciones = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            cmbMiembroInscribir = new ComboBox();
            cmbMiembroExtender = new ComboBox();
            label4 = new Label();
            cmbClaseExtender = new ComboBox();
            dtpVencimientoExtender = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtIdClaseEliminar = new TextBox();
            label7 = new Label();
            label16 = new Label();
            cmbMiembroFiltrar = new ComboBox();
            label17 = new Label();
            cmbClaseFiltrar = new ComboBox();
            label18 = new Label();
            btnFiltrarPorMiembro = new Button();
            btnFiltrarPorClase = new Button();
            panel1 = new Panel();
            label19 = new Label();
            pictureBox2 = new PictureBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            pictureBox1 = new PictureBox();
            pb_miembros = new PictureBox();
            pb_home = new PictureBox();
            p_ventana = new Panel();
            pb_guardarVentana2 = new PictureBox();
            pb_minimzarVentana2 = new PictureBox();
            pb_ventanaNormal = new PictureBox();
            pb_maximizarVentana2 = new PictureBox();
            pb_guardarVentana = new PictureBox();
            pb_cerrarVentana2 = new PictureBox();
            pb_CerrarVentana = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_home).BeginInit();
            p_ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_minimzarVentana2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_maximizarVentana2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrarVentana2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CerrarVentana).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 136);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 14;
            label1.Text = "CLASE:";
            // 
            // cmbClaseInscribir
            // 
            cmbClaseInscribir.FormattingEnabled = true;
            cmbClaseInscribir.Location = new Point(290, 138);
            cmbClaseInscribir.Name = "cmbClaseInscribir";
            cmbClaseInscribir.Size = new Size(200, 23);
            cmbClaseInscribir.TabIndex = 13;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(290, 167);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(200, 23);
            dtpVencimiento.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.ForestGreen;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(290, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(200, 31);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(147, 168);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "FECHA VENCIMIENTO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(211, 110);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "MIEMBRO:";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.ForestGreen;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Impact", 12F);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(290, 432);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(200, 31);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.ForestGreen;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Impact", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(658, 547);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 30);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdMiembroEliminar
            // 
            txtIdMiembroEliminar.Location = new Point(658, 478);
            txtIdMiembroEliminar.Name = "txtIdMiembroEliminar";
            txtIdMiembroEliminar.Size = new Size(200, 23);
            txtIdMiembroEliminar.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Impact", 12F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(573, 480);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 25;
            label12.Text = "ID Miembro:";
            // 
            // dgvInscripciones
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvInscripciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInscripciones.BackgroundColor = SystemColors.Info;
            dgvInscripciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.ForestGreen;
            dataGridViewCellStyle2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInscripciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInscripciones.ColumnHeadersHeight = 28;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInscripciones.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInscripciones.EnableHeadersVisualStyles = false;
            dgvInscripciones.Location = new Point(515, 90);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowHeadersVisible = false;
            dgvInscripciones.Size = new Size(650, 322);
            dgvInscripciones.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label8.ForeColor = Color.White;
            label8.Location = new Point(135, 39);
            label8.Name = "label8";
            label8.Size = new Size(172, 45);
            label8.TabIndex = 31;
            label8.Text = "INSCRIBIR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(304, 39);
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
            label10.ForeColor = Color.ForestGreen;
            label10.Location = new Point(279, 266);
            label10.Name = "label10";
            label10.Size = new Size(211, 45);
            label10.TabIndex = 34;
            label10.Text = "INSCRIPCIÓN";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label11.ForeColor = Color.White;
            label11.Location = new Point(125, 266);
            label11.Name = "label11";
            label11.Size = new Size(159, 45);
            label11.TabIndex = 33;
            label11.Text = "EXTENDER";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Impact", 20.25F, FontStyle.Italic | FontStyle.Underline);
            label13.ForeColor = Color.ForestGreen;
            label13.Location = new Point(629, 424);
            label13.Name = "label13";
            label13.Size = new Size(157, 34);
            label13.TabIndex = 36;
            label13.Text = "INSCRIPCIÓN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Impact", 20.25F, FontStyle.Italic | FontStyle.Underline);
            label14.ForeColor = Color.White;
            label14.Location = new Point(515, 424);
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
            label15.Location = new Point(539, 41);
            label15.Name = "label15";
            label15.Size = new Size(426, 45);
            label15.TabIndex = 37;
            label15.Text = "PLANILLA DE INSCRIPCIONES";
            // 
            // cmbMiembroInscribir
            // 
            cmbMiembroInscribir.FormattingEnabled = true;
            cmbMiembroInscribir.Location = new Point(290, 109);
            cmbMiembroInscribir.Name = "cmbMiembroInscribir";
            cmbMiembroInscribir.Size = new Size(200, 23);
            cmbMiembroInscribir.TabIndex = 38;
            // 
            // cmbMiembroExtender
            // 
            cmbMiembroExtender.FormattingEnabled = true;
            cmbMiembroExtender.Location = new Point(290, 333);
            cmbMiembroExtender.Name = "cmbMiembroExtender";
            cmbMiembroExtender.Size = new Size(200, 23);
            cmbMiembroExtender.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(235, 360);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 43;
            label4.Text = "CLASE:";
            // 
            // cmbClaseExtender
            // 
            cmbClaseExtender.FormattingEnabled = true;
            cmbClaseExtender.Location = new Point(290, 362);
            cmbClaseExtender.Name = "cmbClaseExtender";
            cmbClaseExtender.Size = new Size(200, 23);
            cmbClaseExtender.TabIndex = 42;
            // 
            // dtpVencimientoExtender
            // 
            dtpVencimientoExtender.Location = new Point(290, 391);
            dtpVencimientoExtender.Name = "dtpVencimientoExtender";
            dtpVencimientoExtender.Size = new Size(200, 23);
            dtpVencimientoExtender.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(211, 334);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 39;
            label5.Text = "MIEMBRO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(147, 392);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 40;
            label6.Text = "FECHA VENCIMIENTO:";
            // 
            // txtIdClaseEliminar
            // 
            txtIdClaseEliminar.Location = new Point(658, 507);
            txtIdClaseEliminar.Name = "txtIdClaseEliminar";
            txtIdClaseEliminar.Size = new Size(200, 23);
            txtIdClaseEliminar.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(587, 510);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 45;
            label7.Text = "ID Clase:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Impact", 20.25F, FontStyle.Italic | FontStyle.Underline);
            label16.ForeColor = Color.White;
            label16.Location = new Point(886, 424);
            label16.Name = "label16";
            label16.Size = new Size(152, 34);
            label16.TabIndex = 47;
            label16.Text = "FILTRAR POR:";
            // 
            // cmbMiembroFiltrar
            // 
            cmbMiembroFiltrar.FormattingEnabled = true;
            cmbMiembroFiltrar.Location = new Point(965, 477);
            cmbMiembroFiltrar.Name = "cmbMiembroFiltrar";
            cmbMiembroFiltrar.Size = new Size(200, 23);
            cmbMiembroFiltrar.TabIndex = 51;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(910, 572);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 50;
            label17.Text = "CLASE:";
            // 
            // cmbClaseFiltrar
            // 
            cmbClaseFiltrar.FormattingEnabled = true;
            cmbClaseFiltrar.Location = new Point(965, 572);
            cmbClaseFiltrar.Name = "cmbClaseFiltrar";
            cmbClaseFiltrar.Size = new Size(200, 23);
            cmbClaseFiltrar.TabIndex = 49;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(886, 475);
            label18.Name = "label18";
            label18.Size = new Size(73, 20);
            label18.TabIndex = 48;
            label18.Text = "MIEMBRO:";
            // 
            // btnFiltrarPorMiembro
            // 
            btnFiltrarPorMiembro.BackColor = Color.ForestGreen;
            btnFiltrarPorMiembro.FlatStyle = FlatStyle.Popup;
            btnFiltrarPorMiembro.Font = new Font("Impact", 12F);
            btnFiltrarPorMiembro.ForeColor = Color.White;
            btnFiltrarPorMiembro.Location = new Point(965, 506);
            btnFiltrarPorMiembro.Name = "btnFiltrarPorMiembro";
            btnFiltrarPorMiembro.Size = new Size(200, 31);
            btnFiltrarPorMiembro.TabIndex = 52;
            btnFiltrarPorMiembro.Text = "FILTRAR";
            btnFiltrarPorMiembro.UseVisualStyleBackColor = false;
            btnFiltrarPorMiembro.Click += btnFiltrarPorMiembro_Click;
            // 
            // btnFiltrarPorClase
            // 
            btnFiltrarPorClase.BackColor = Color.ForestGreen;
            btnFiltrarPorClase.FlatStyle = FlatStyle.Popup;
            btnFiltrarPorClase.Font = new Font("Impact", 12F);
            btnFiltrarPorClase.ForeColor = Color.White;
            btnFiltrarPorClase.Location = new Point(965, 601);
            btnFiltrarPorClase.Name = "btnFiltrarPorClase";
            btnFiltrarPorClase.Size = new Size(200, 31);
            btnFiltrarPorClase.TabIndex = 53;
            btnFiltrarPorClase.Text = "FILTRAR";
            btnFiltrarPorClase.UseVisualStyleBackColor = false;
            btnFiltrarPorClase.Click += btnFiltrarPorClase_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label19);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pb_miembros);
            panel1.Controls.Add(pb_home);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(92, 643);
            panel1.TabIndex = 54;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(1, 388);
            label19.Name = "label19";
            label19.Size = new Size(94, 20);
            label19.TabIndex = 41;
            label19.Text = "INSCRIPCION";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Inscripciones1;
            pictureBox2.Location = new Point(13, 326);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 40;
            pictureBox2.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(21, 290);
            label20.Name = "label20";
            label20.Size = new Size(54, 20);
            label20.TabIndex = 40;
            label20.Text = "CLASES";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(8, 191);
            label21.Name = "label21";
            label21.Size = new Size(78, 20);
            label21.TabIndex = 39;
            label21.Text = "MIEMBROS";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(21, 92);
            label22.Name = "label22";
            label22.Size = new Size(51, 20);
            label22.TabIndex = 39;
            label22.Text = "INICIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Clases;
            pictureBox1.Location = new Point(12, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pb_miembros
            // 
            pb_miembros.Cursor = Cursors.Hand;
            pb_miembros.Image = Properties.Resources.Miembros;
            pb_miembros.Location = new Point(11, 129);
            pb_miembros.Name = "pb_miembros";
            pb_miembros.Size = new Size(70, 70);
            pb_miembros.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_miembros.TabIndex = 39;
            pb_miembros.TabStop = false;
            pb_miembros.Click += pb_miembros_Click;
            // 
            // pb_home
            // 
            pb_home.Cursor = Cursors.Hand;
            pb_home.Image = Properties.Resources.Home;
            pb_home.Location = new Point(11, 31);
            pb_home.Name = "pb_home";
            pb_home.Size = new Size(70, 70);
            pb_home.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_home.TabIndex = 0;
            pb_home.TabStop = false;
            pb_home.Click += pb_home_Click;
            // 
            // p_ventana
            // 
            p_ventana.BackColor = Color.White;
            p_ventana.Controls.Add(pb_guardarVentana2);
            p_ventana.Controls.Add(pb_minimzarVentana2);
            p_ventana.Controls.Add(pb_ventanaNormal);
            p_ventana.Controls.Add(pb_maximizarVentana2);
            p_ventana.Controls.Add(pb_guardarVentana);
            p_ventana.Controls.Add(pb_cerrarVentana2);
            p_ventana.Controls.Add(pb_CerrarVentana);
            p_ventana.Dock = DockStyle.Top;
            p_ventana.Location = new Point(92, 0);
            p_ventana.Name = "p_ventana";
            p_ventana.Size = new Size(1085, 26);
            p_ventana.TabIndex = 56;
            p_ventana.MouseDown += MoverPanel;
            // 
            // pb_guardarVentana2
            // 
            pb_guardarVentana2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_guardarVentana2.BackColor = Color.White;
            pb_guardarVentana2.Cursor = Cursors.Hand;
            pb_guardarVentana2.Image = Properties.Resources.Achicar1;
            pb_guardarVentana2.Location = new Point(1014, -5);
            pb_guardarVentana2.Name = "pb_guardarVentana2";
            pb_guardarVentana2.Size = new Size(45, 33);
            pb_guardarVentana2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_guardarVentana2.TabIndex = 63;
            pb_guardarVentana2.TabStop = false;
            pb_guardarVentana2.Click += pb_guardarVentana2_Click;
            // 
            // pb_minimzarVentana2
            // 
            pb_minimzarVentana2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_minimzarVentana2.BackColor = Color.White;
            pb_minimzarVentana2.Cursor = Cursors.Hand;
            pb_minimzarVentana2.Image = Properties.Resources.Minimizar;
            pb_minimzarVentana2.Location = new Point(987, -2);
            pb_minimzarVentana2.Name = "pb_minimzarVentana2";
            pb_minimzarVentana2.Size = new Size(37, 28);
            pb_minimzarVentana2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_minimzarVentana2.TabIndex = 62;
            pb_minimzarVentana2.TabStop = false;
            pb_minimzarVentana2.Click += pb_minimzarVentana2_Click;
            // 
            // pb_ventanaNormal
            // 
            pb_ventanaNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_ventanaNormal.BackColor = Color.White;
            pb_ventanaNormal.Cursor = Cursors.Hand;
            pb_ventanaNormal.Image = Properties.Resources.Achicar1;
            pb_ventanaNormal.Location = new Point(1500, -4);
            pb_ventanaNormal.Name = "pb_ventanaNormal";
            pb_ventanaNormal.Size = new Size(45, 33);
            pb_ventanaNormal.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ventanaNormal.TabIndex = 59;
            pb_ventanaNormal.TabStop = false;
            // 
            // pb_maximizarVentana2
            // 
            pb_maximizarVentana2.BackColor = Color.White;
            pb_maximizarVentana2.Cursor = Cursors.Hand;
            pb_maximizarVentana2.Image = Properties.Resources.Maximizar;
            pb_maximizarVentana2.Location = new Point(1020, -3);
            pb_maximizarVentana2.Name = "pb_maximizarVentana2";
            pb_maximizarVentana2.Size = new Size(29, 29);
            pb_maximizarVentana2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_maximizarVentana2.TabIndex = 61;
            pb_maximizarVentana2.TabStop = false;
            pb_maximizarVentana2.Click += pb_maximizarVentana2_Click;
            // 
            // pb_guardarVentana
            // 
            pb_guardarVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_guardarVentana.BackColor = Color.White;
            pb_guardarVentana.Cursor = Cursors.Hand;
            pb_guardarVentana.Image = Properties.Resources.Minimizar;
            pb_guardarVentana.Location = new Point(1475, -2);
            pb_guardarVentana.Name = "pb_guardarVentana";
            pb_guardarVentana.Size = new Size(37, 28);
            pb_guardarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            pb_guardarVentana.TabIndex = 58;
            pb_guardarVentana.TabStop = false;
            // 
            // pb_cerrarVentana2
            // 
            pb_cerrarVentana2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_cerrarVentana2.BackColor = Color.White;
            pb_cerrarVentana2.Cursor = Cursors.Hand;
            pb_cerrarVentana2.Image = Properties.Resources.CerrarVentana;
            pb_cerrarVentana2.Location = new Point(1056, 3);
            pb_cerrarVentana2.Name = "pb_cerrarVentana2";
            pb_cerrarVentana2.Size = new Size(20, 21);
            pb_cerrarVentana2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_cerrarVentana2.TabIndex = 60;
            pb_cerrarVentana2.TabStop = false;
            pb_cerrarVentana2.Click += pb_cerrarVentana2_Click;
            // 
            // pb_CerrarVentana
            // 
            pb_CerrarVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_CerrarVentana.BackColor = Color.White;
            pb_CerrarVentana.Cursor = Cursors.Hand;
            pb_CerrarVentana.Image = Properties.Resources.CerrarVentana;
            pb_CerrarVentana.Location = new Point(1544, 3);
            pb_CerrarVentana.Name = "pb_CerrarVentana";
            pb_CerrarVentana.Size = new Size(20, 21);
            pb_CerrarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            pb_CerrarVentana.TabIndex = 56;
            pb_CerrarVentana.TabStop = false;
            // 
            // InscripcionClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1177, 643);
            Controls.Add(p_ventana);
            Controls.Add(btnFiltrarPorClase);
            Controls.Add(btnFiltrarPorMiembro);
            Controls.Add(cmbMiembroFiltrar);
            Controls.Add(label17);
            Controls.Add(cmbClaseFiltrar);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(txtIdClaseEliminar);
            Controls.Add(label7);
            Controls.Add(cmbMiembroExtender);
            Controls.Add(label4);
            Controls.Add(cmbClaseExtender);
            Controls.Add(dtpVencimientoExtender);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(cmbMiembroInscribir);
            Controls.Add(label15);
            Controls.Add(btnEliminar);
            Controls.Add(label13);
            Controls.Add(txtIdMiembroEliminar);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(dgvInscripciones);
            Controls.Add(cmbClaseInscribir);
            Controls.Add(dtpVencimiento);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InscripcionClases";
            Text = "Gestion de Gimnasio";
            Load += InscripcionClases_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_home).EndInit();
            p_ventana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_minimzarVentana2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_maximizarVentana2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrarVentana2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CerrarVentana).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregar;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpVencimiento;
        private Label label1;
        private ComboBox cmbClaseInscribir;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtIdMiembroEliminar;
        private Label label12;
        private DataGridView dgvInscripciones;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private ComboBox cmbMiembroInscribir;
        private ComboBox cmbMiembroExtender;
        private Label label4;
        private ComboBox cmbClaseExtender;
        private DateTimePicker dtpVencimientoExtender;
        private Label label5;
        private Label label6;
        private TextBox txtIdClaseEliminar;
        private Label label7;
        private Label label16;
        private ComboBox cmbMiembroFiltrar;
        private Label label17;
        private ComboBox cmbClaseFiltrar;
        private Label label18;
        private Button btnFiltrarPorMiembro;
        private Button btnFiltrarPorClase;
        private Panel panel1;
        private Label label19;
        private PictureBox pictureBox2;
        private Label label20;
        private Label label21;
        private Label label22;
        private PictureBox pictureBox1;
        private PictureBox pb_miembros;
        private PictureBox pb_home;
        private Panel p_ventana;
        private PictureBox pb_ventanaNormal;
        private PictureBox pb_guardarVentana;
        private PictureBox pb_CerrarVentana;
        private PictureBox pb_minimzarVentana2;
        private PictureBox pb_maximizarVentana2;
        private PictureBox pb_cerrarVentana2;
        private PictureBox pb_guardarVentana2;
    }
}