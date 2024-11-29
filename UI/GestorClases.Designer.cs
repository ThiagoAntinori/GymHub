namespace UI
{
    partial class GestorClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorClases));
            label1 = new Label();
            cmbDia = new ComboBox();
            txtDescripcion = new TextBox();
            txtHorario = new TextBox();
            btnAgregar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            cmbDiaModificar = new ComboBox();
            label5 = new Label();
            txtEntrenadorModificar = new TextBox();
            btnModificar = new Button();
            txtIdModificar = new TextBox();
            label7 = new Label();
            btnEliminar = new Button();
            txtIdEliminar = new TextBox();
            label12 = new Label();
            dgvClases = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtEntrenador = new TextBox();
            txtCapacidadMaxima = new TextBox();
            label16 = new Label();
            txtHorarioModificar = new TextBox();
            label17 = new Label();
            txtCapacidadMaximaModificar = new TextBox();
            label18 = new Label();
            label19 = new Label();
            pb_inscripcion = new PictureBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            pictureBox1 = new PictureBox();
            pb_miembros = new PictureBox();
            pb_home = new PictureBox();
            panel1 = new Panel();
            p_ventana = new Panel();
            pb_ventanaNormal4 = new PictureBox();
            pb_maximizar = new PictureBox();
            pb_minimizarVentana4 = new PictureBox();
            pb_ventanaNormal = new PictureBox();
            pb_guardarVentana = new PictureBox();
            pb_CerrarVentana = new PictureBox();
            pb_cerrarVentana4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_inscripcion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_home).BeginInit();
            panel1.SuspendLayout();
            p_ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_minimizarVentana4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_CerrarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrarVentana4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(152, 187);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 14;
            label1.Text = "DIA DE CLASE:";
            // 
            // cmbDia
            // 
            cmbDia.FormattingEnabled = true;
            cmbDia.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cmbDia.Location = new Point(250, 187);
            cmbDia.Name = "cmbDia";
            cmbDia.Size = new Size(200, 23);
            cmbDia.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(250, 93);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(250, 157);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(200, 23);
            txtHorario.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumBlue;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(250, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(200, 31);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(175, 157);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "HORARIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(147, 94);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPCIÓN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 127);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "ENTRENADOR:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(152, 416);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 15;
            label6.Text = "DIA DE CLASE:";
            // 
            // cmbDiaModificar
            // 
            cmbDiaModificar.FormattingEnabled = true;
            cmbDiaModificar.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cmbDiaModificar.Location = new Point(250, 416);
            cmbDiaModificar.Name = "cmbDiaModificar";
            cmbDiaModificar.Size = new Size(200, 23);
            cmbDiaModificar.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(150, 390);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 25;
            label5.Text = "ENTRENADOR:";
            // 
            // txtEntrenadorModificar
            // 
            txtEntrenadorModificar.Location = new Point(250, 387);
            txtEntrenadorModificar.Name = "txtEntrenadorModificar";
            txtEntrenadorModificar.Size = new Size(200, 23);
            txtEntrenadorModificar.TabIndex = 24;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.MediumBlue;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Impact", 12F);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(250, 503);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(200, 31);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(250, 358);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(200, 23);
            txtIdModificar.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Impact", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(143, 361);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 13;
            label7.Text = "ID DE LA CLASE:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MediumBlue;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Impact", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(736, 463);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 30);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(554, 467);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(176, 23);
            txtIdEliminar.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Impact", 12F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(469, 469);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 25;
            label12.Text = "ID DE CLASE:";
            // 
            // dgvClases
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvClases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClases.BackgroundColor = SystemColors.Info;
            dgvClases.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MediumBlue;
            dataGridViewCellStyle2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClases.ColumnHeadersHeight = 28;
            dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClases.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClases.EnableHeadersVisualStyles = false;
            dgvClases.Location = new Point(471, 83);
            dgvClases.Name = "dgvClases";
            dgvClases.RowHeadersVisible = false;
            dgvClases.Size = new Size(693, 322);
            dgvClases.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label8.ForeColor = Color.White;
            label8.Location = new Point(135, 35);
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
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(287, 35);
            label9.Name = "label9";
            label9.Size = new Size(108, 45);
            label9.TabIndex = 32;
            label9.Text = "CLASE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label10.ForeColor = Color.MediumBlue;
            label10.Location = new Point(287, 300);
            label10.Name = "label10";
            label10.Size = new Size(108, 45);
            label10.TabIndex = 34;
            label10.Text = "CLASE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Impact", 27.75F, FontStyle.Italic | FontStyle.Underline);
            label11.ForeColor = Color.White;
            label11.Location = new Point(105, 300);
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
            label13.ForeColor = Color.MediumBlue;
            label13.Location = new Point(583, 416);
            label13.Name = "label13";
            label13.Size = new Size(80, 34);
            label13.TabIndex = 36;
            label13.Text = "CLASE";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Impact", 20.25F, FontStyle.Italic | FontStyle.Underline);
            label14.ForeColor = Color.White;
            label14.Location = new Point(469, 416);
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
            label15.Location = new Point(469, 35);
            label15.Name = "label15";
            label15.Size = new Size(255, 45);
            label15.TabIndex = 37;
            label15.Text = "LISTA DE CLASES";
            // 
            // txtEntrenador
            // 
            txtEntrenador.Location = new Point(250, 124);
            txtEntrenador.Name = "txtEntrenador";
            txtEntrenador.Size = new Size(200, 23);
            txtEntrenador.TabIndex = 38;
            // 
            // txtCapacidadMaxima
            // 
            txtCapacidadMaxima.Location = new Point(250, 216);
            txtCapacidadMaxima.Name = "txtCapacidadMaxima";
            txtCapacidadMaxima.Size = new Size(200, 23);
            txtCapacidadMaxima.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(111, 216);
            label16.Name = "label16";
            label16.Size = new Size(133, 20);
            label16.TabIndex = 39;
            label16.Text = "CAPACIDAD MÁXIMA:";
            // 
            // txtHorarioModificar
            // 
            txtHorarioModificar.Location = new Point(250, 445);
            txtHorarioModificar.Name = "txtHorarioModificar";
            txtHorarioModificar.Size = new Size(200, 23);
            txtHorarioModificar.TabIndex = 42;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(175, 445);
            label17.Name = "label17";
            label17.Size = new Size(69, 20);
            label17.TabIndex = 41;
            label17.Text = "HORARIO:";
            // 
            // txtCapacidadMaximaModificar
            // 
            txtCapacidadMaximaModificar.Location = new Point(250, 474);
            txtCapacidadMaximaModificar.Name = "txtCapacidadMaximaModificar";
            txtCapacidadMaximaModificar.Size = new Size(200, 23);
            txtCapacidadMaximaModificar.TabIndex = 44;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.White;
            label18.Location = new Point(111, 474);
            label18.Name = "label18";
            label18.Size = new Size(133, 20);
            label18.TabIndex = 43;
            label18.Text = "CAPACIDAD MÁXIMA:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.MediumBlue;
            label19.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.White;
            label19.Location = new Point(0, 397);
            label19.Name = "label19";
            label19.Size = new Size(94, 20);
            label19.TabIndex = 52;
            label19.Text = "INSCRIPCION";
            // 
            // pb_inscripcion
            // 
            pb_inscripcion.BackColor = Color.MediumBlue;
            pb_inscripcion.Cursor = Cursors.Hand;
            pb_inscripcion.Image = Properties.Resources.Inscripciones1;
            pb_inscripcion.Location = new Point(12, 335);
            pb_inscripcion.Name = "pb_inscripcion";
            pb_inscripcion.Size = new Size(70, 70);
            pb_inscripcion.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_inscripcion.TabIndex = 50;
            pb_inscripcion.TabStop = false;
            pb_inscripcion.Click += pb_inscripcion_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.MediumBlue;
            label20.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(20, 299);
            label20.Name = "label20";
            label20.Size = new Size(54, 20);
            label20.TabIndex = 51;
            label20.Text = "CLASES";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.MediumBlue;
            label21.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(7, 200);
            label21.Name = "label21";
            label21.Size = new Size(78, 20);
            label21.TabIndex = 46;
            label21.Text = "MIEMBROS";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.MediumBlue;
            label22.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(20, 101);
            label22.Name = "label22";
            label22.Size = new Size(51, 20);
            label22.TabIndex = 47;
            label22.Text = "INICIO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MediumBlue;
            pictureBox1.Image = Properties.Resources.Clases;
            pictureBox1.Location = new Point(11, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pb_miembros
            // 
            pb_miembros.BackColor = Color.MediumBlue;
            pb_miembros.Cursor = Cursors.Hand;
            pb_miembros.Image = Properties.Resources.Miembros;
            pb_miembros.Location = new Point(10, 138);
            pb_miembros.Name = "pb_miembros";
            pb_miembros.Size = new Size(70, 70);
            pb_miembros.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_miembros.TabIndex = 49;
            pb_miembros.TabStop = false;
            pb_miembros.Click += pb_miembros_Click;
            // 
            // pb_home
            // 
            pb_home.BackColor = Color.MediumBlue;
            pb_home.BackgroundImage = Properties.Resources.Home;
            pb_home.Cursor = Cursors.Hand;
            pb_home.Image = Properties.Resources.Home;
            pb_home.Location = new Point(10, 40);
            pb_home.Name = "pb_home";
            pb_home.Size = new Size(70, 70);
            pb_home.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_home.TabIndex = 45;
            pb_home.TabStop = false;
            pb_home.Click += pb_home_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label22);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(pb_inscripcion);
            panel1.Controls.Add(pb_home);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(pb_miembros);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(96, 550);
            panel1.TabIndex = 53;
            // 
            // p_ventana
            // 
            p_ventana.BackColor = Color.White;
            p_ventana.Controls.Add(pb_ventanaNormal4);
            p_ventana.Controls.Add(pb_maximizar);
            p_ventana.Controls.Add(pb_minimizarVentana4);
            p_ventana.Controls.Add(pb_ventanaNormal);
            p_ventana.Controls.Add(pb_guardarVentana);
            p_ventana.Controls.Add(pb_CerrarVentana);
            p_ventana.Controls.Add(pb_cerrarVentana4);
            p_ventana.Dock = DockStyle.Top;
            p_ventana.Location = new Point(96, 0);
            p_ventana.Name = "p_ventana";
            p_ventana.Size = new Size(1080, 26);
            p_ventana.TabIndex = 56;
            p_ventana.MouseDown += MoverPanel;
            // 
            // pb_ventanaNormal4
            // 
            pb_ventanaNormal4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_ventanaNormal4.BackColor = Color.White;
            pb_ventanaNormal4.Cursor = Cursors.Hand;
            pb_ventanaNormal4.Image = Properties.Resources.Achicar1;
            pb_ventanaNormal4.Location = new Point(1000, -4);
            pb_ventanaNormal4.Name = "pb_ventanaNormal4";
            pb_ventanaNormal4.Size = new Size(45, 33);
            pb_ventanaNormal4.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ventanaNormal4.TabIndex = 62;
            pb_ventanaNormal4.TabStop = false;
            pb_ventanaNormal4.Click += pb_ventanaNormal4_Click;
            // 
            // pb_maximizar
            // 
            pb_maximizar.BackColor = Color.White;
            pb_maximizar.Cursor = Cursors.Hand;
            pb_maximizar.Image = Properties.Resources.Maximizar;
            pb_maximizar.Location = new Point(1008, -2);
            pb_maximizar.Name = "pb_maximizar";
            pb_maximizar.Size = new Size(29, 29);
            pb_maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            pb_maximizar.TabIndex = 63;
            pb_maximizar.TabStop = false;
            pb_maximizar.Click += pb_maximizar_Click;
            // 
            // pb_minimizarVentana4
            // 
            pb_minimizarVentana4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_minimizarVentana4.BackColor = Color.White;
            pb_minimizarVentana4.Cursor = Cursors.Hand;
            pb_minimizarVentana4.Image = Properties.Resources.Minimizar;
            pb_minimizarVentana4.Location = new Point(965, -2);
            pb_minimizarVentana4.Name = "pb_minimizarVentana4";
            pb_minimizarVentana4.Size = new Size(37, 28);
            pb_minimizarVentana4.SizeMode = PictureBoxSizeMode.Zoom;
            pb_minimizarVentana4.TabIndex = 61;
            pb_minimizarVentana4.TabStop = false;
            pb_minimizarVentana4.Click += pb_minimizarVentana4_Click;
            // 
            // pb_ventanaNormal
            // 
            pb_ventanaNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_ventanaNormal.BackColor = Color.White;
            pb_ventanaNormal.Cursor = Cursors.Hand;
            pb_ventanaNormal.Image = Properties.Resources.Achicar1;
            pb_ventanaNormal.Location = new Point(1490, -4);
            pb_ventanaNormal.Name = "pb_ventanaNormal";
            pb_ventanaNormal.Size = new Size(45, 33);
            pb_ventanaNormal.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ventanaNormal.TabIndex = 59;
            pb_ventanaNormal.TabStop = false;
            // 
            // pb_guardarVentana
            // 
            pb_guardarVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_guardarVentana.BackColor = Color.White;
            pb_guardarVentana.Cursor = Cursors.Hand;
            pb_guardarVentana.Image = Properties.Resources.Minimizar;
            pb_guardarVentana.Location = new Point(1459, -2);
            pb_guardarVentana.Name = "pb_guardarVentana";
            pb_guardarVentana.Size = new Size(37, 28);
            pb_guardarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            pb_guardarVentana.TabIndex = 58;
            pb_guardarVentana.TabStop = false;
            // 
            // pb_CerrarVentana
            // 
            pb_CerrarVentana.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_CerrarVentana.BackColor = Color.White;
            pb_CerrarVentana.Cursor = Cursors.Hand;
            pb_CerrarVentana.Image = Properties.Resources.CerrarVentana;
            pb_CerrarVentana.Location = new Point(1539, 3);
            pb_CerrarVentana.Name = "pb_CerrarVentana";
            pb_CerrarVentana.Size = new Size(20, 21);
            pb_CerrarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            pb_CerrarVentana.TabIndex = 56;
            pb_CerrarVentana.TabStop = false;
            // 
            // pb_cerrarVentana4
            // 
            pb_cerrarVentana4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_cerrarVentana4.BackColor = Color.White;
            pb_cerrarVentana4.Cursor = Cursors.Hand;
            pb_cerrarVentana4.Image = Properties.Resources.CerrarVentana;
            pb_cerrarVentana4.Location = new Point(1048, 3);
            pb_cerrarVentana4.Name = "pb_cerrarVentana4";
            pb_cerrarVentana4.Size = new Size(20, 21);
            pb_cerrarVentana4.SizeMode = PictureBoxSizeMode.Zoom;
            pb_cerrarVentana4.TabIndex = 60;
            pb_cerrarVentana4.TabStop = false;
            pb_cerrarVentana4.Click += pb_cerrarVentana4_Click;
            // 
            // GestorClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.Fondo;
            ClientSize = new Size(1176, 550);
            Controls.Add(p_ventana);
            Controls.Add(txtCapacidadMaximaModificar);
            Controls.Add(label18);
            Controls.Add(txtHorarioModificar);
            Controls.Add(label17);
            Controls.Add(txtCapacidadMaxima);
            Controls.Add(label16);
            Controls.Add(txtEntrenador);
            Controls.Add(label15);
            Controls.Add(btnEliminar);
            Controls.Add(label13);
            Controls.Add(txtIdEliminar);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(cmbDiaModificar);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtEntrenadorModificar);
            Controls.Add(btnModificar);
            Controls.Add(dgvClases);
            Controls.Add(txtIdModificar);
            Controls.Add(cmbDia);
            Controls.Add(label7);
            Controls.Add(txtDescripcion);
            Controls.Add(txtHorario);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestorClases";
            Text = "Gestion de Gimnasio";
            WindowState = FormWindowState.Maximized;
            Load += GestorClases_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_inscripcion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_miembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_home).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            p_ventana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_minimizarVentana4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ventanaNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_guardarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_CerrarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_cerrarVentana4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtHorario;
        private Button btnAgregar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbDia;
        private Label label5;
        private TextBox txtEntrenadorModificar;
        private Button btnModificar;
        private TextBox txtIdModificar;
        private Label label7;
        private Label label6;
        private ComboBox cmbDiaModificar;
        private Button btnEliminar;
        private TextBox txtIdEliminar;
        private Label label12;
        private DataGridView dgvClases;
        protected TextBox txtDescripcion;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        protected TextBox txtEntrenador;
        protected TextBox txtCapacidadMaxima;
        private Label label16;
        private TextBox txtHorarioModificar;
        private Label label17;
        private TextBox txtCapacidadMaximaModificar;
        private Label label18;
        private Label label19;
        private PictureBox pb_inscripcion;
        private Label label20;
        private Label label21;
        private Label label22;
        private PictureBox pictureBox1;
        private PictureBox pb_miembros;
        private PictureBox pb_home;
        private Panel panel1;
        private Panel p_ventana;
        private PictureBox pb_ventanaNormal;
        private PictureBox pb_guardarVentana;
        private PictureBox pb_CerrarVentana;
        private PictureBox pb_ventanaNormal4;
        private PictureBox pb_minimizarVentana4;
        private PictureBox pb_cerrarVentana4;
        private PictureBox pb_maximizar;
    }
}