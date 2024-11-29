using BLL;
using DAL;
using Entity;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class GestorClases : Form
    {

        public GestorClases()
        {
            InitializeComponent();
        }
        private ClaseBusiness ClaseBusiness = new ClaseBusiness();

        private void textBox_SoloLetras(object sender, KeyPressEventArgs e)
        {
            //para que solo puedan tipear letras en textbox correspondientes
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_SoloNumeros(object sender, KeyPressEventArgs e)
        {
            //para que solo puedan tipear numeros en textbox correspondientes
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void GestorClases_Load(object sender, EventArgs e)
        {
            try
            {
                txtIdEliminar.KeyPress += new KeyPressEventHandler(textBox_SoloNumeros);
                txtIdModificar.KeyPress += new KeyPressEventHandler(textBox_SoloNumeros);
                txtEntrenador.KeyPress += new KeyPressEventHandler(textBox_SoloLetras);
                txtDescripcion.KeyPress += new KeyPressEventHandler(textBox_SoloLetras);
                txtEntrenadorModificar.KeyPress += new KeyPressEventHandler(textBox_SoloLetras);
                pb_ventanaNormal4.Visible = false;
                actualizarVista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarDataGridView()
        {
            try
            {
                dgvClases.DataSource = null;
                dgvClases.DataSource = ClaseBusiness.GetAllClases();
                dgvClases.Columns["idClase"].HeaderText = "ID";
                dgvClases.Columns["Descripcion"].HeaderText = "DESCRIPCION";
                dgvClases.Columns["DiadeClase"].HeaderText = "DIA DE CLASE";
                dgvClases.Columns["Horario"].HeaderText = "HORARIO";
                dgvClases.Columns["EntrenadorACargo"].HeaderText = "ENTRENADOR A CARGO";
                dgvClases.Columns["CapacidadMaxima"].HeaderText = "CAPACIDAD MAXIMA";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void limpiarCampos()
        {
            limpiarTextBox(txtDescripcion);
            limpiarTextBox(txtEntrenador);
            limpiarTextBox(txtHorario);
            limpiarTextBox(txtCapacidadMaxima);
            limpiarTextBox(txtIdModificar);
            limpiarTextBox(txtEntrenadorModificar);
            limpiarTextBox(txtCapacidadMaximaModificar);
            limpiarTextBox(txtHorarioModificar);
            cmbDia.Text = string.Empty;
            cmbDiaModificar.Text = string.Empty;
            limpiarTextBox(txtIdEliminar);
        }

        private void limpiarTextBox(TextBox txt)
        {
            txt.Text = string.Empty;
        }

        private void actualizarVista()
        {
            try
            {
                actualizarDataGridView();
                limpiarCampos();
            }
            catch (Exception ex) { throw; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clase nuevaClase = new Clase
                {
                    Descripcion = txtDescripcion.Text,
                    EntrenadorACargo = txtEntrenador.Text,
                    Diadeclase = cmbDia.Text,
                    Horario = txtHorario.Text,
                    CapacidadMaxima = Convert.ToInt32(txtCapacidadMaxima.Text)
                };
                ClaseBusiness.CargarNuevaClase(nuevaClase);
                actualizarVista();
                MessageBox.Show("Se cargó la clase correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Clase claseAModificar = new Clase
                {
                    IdClase = Convert.ToInt32(txtIdModificar.Text),
                    Descripcion = ClaseBusiness.GetById(Convert.ToInt32(txtIdModificar.Text)).Descripcion,
                    EntrenadorACargo = txtEntrenadorModificar.Text,
                    Horario = txtHorarioModificar.Text,
                    Diadeclase = cmbDiaModificar.Text,
                    CapacidadMaxima = Convert.ToInt32(txtCapacidadMaximaModificar.Text)
                };
                ClaseBusiness.ModificarClase(claseAModificar);
                actualizarVista();
                MessageBox.Show("Se modificó la clase correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"¿Desea eliminar la clase con ID: {txtIdEliminar.Text}? \n Se eliminarán todas las inscripciones a la misma.", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClaseBusiness.EliminarClase(Convert.ToInt32(txtIdEliminar.Text));
                    actualizarVista();
                    MessageBox.Show("Se eliminó la clase correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botones Panel Lateral
        private void pb_miembros_Click(object sender, EventArgs e)
        {
            GestorMiembros GM = new GestorMiembros();
            GM.Show();
            this.Close();
        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pb_inscripcion_Click(object sender, EventArgs e)
        {
            InscripcionClases inscripcion = new InscripcionClases();
            inscripcion.Show();
            this.Close();
        }

        //Mover Panel de arriba
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverPanel(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pb_cerrarVentana4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_minimizarVentana4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_maximizar.Visible = false;
            pb_ventanaNormal4.Visible = true;
        }

        private void pb_ventanaNormal4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pb_maximizar.Visible = true;
            pb_ventanaNormal4.Visible = false;
        }
    }
}
