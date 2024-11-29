using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class InscripcionClases : Form
    {
        public InscripcionClases()
        {
            InitializeComponent();
        }

        InscripcionBusiness ClaseMiembroBusiness = new InscripcionBusiness();
        ClaseBusiness ClaseBusiness = new ClaseBusiness();
        MiembroBusiness MiembroBusiness = new MiembroBusiness();

        private void InscripcionClases_Load(object sender, EventArgs e)
        {
            actualizarVista();
        }

        private void actualizarDgv(List<Inscripcion> listaClaseMiembros)
        {
            try
            {
                dgvInscripciones.DataSource = null;
                dgvInscripciones.DataSource = listaClaseMiembros;
                dgvInscripciones.Columns["Clase"].Visible = false;
                dgvInscripciones.Columns["Miembro"].Visible = false;
                dgvInscripciones.Columns["DescripcionClase"].HeaderText = "Clase";
                dgvInscripciones.Columns["NombreMiembro"].HeaderText = "Miembro";
                dgvInscripciones.Columns["FechaVencimiento"].HeaderText = "Fecha de vencimiento";
                dgvInscripciones.Columns["FechaInscripcion"].HeaderText = "Fecha de inscripción";
            }
            catch (Exception ex) { throw; }
        }

        private void actualizarComboMiembro(ComboBox cmb)
        {
            try
            {
                cmb.DataSource = null;
                cmb.DataSource = MiembroBusiness.GetMiembrosBusiness();
                cmb.ValueMember = "IdMiembro";
                cmb.DisplayMember = "NombreYApellido";
            }
            catch (Exception ex) { throw; }
        }

        private void actualizarComboClase(ComboBox cmb)
        {
            try
            {
                cmb.DataSource = null;
                cmb.DataSource = ClaseBusiness.GetAllClases();
                cmb.ValueMember = "IdClase";
                cmb.DisplayMember = "Descripcion";
            }
            catch (Exception ex) { throw; }
        }

        private void limpiarCampos()
        {
            cmbMiembroInscribir.SelectedIndex = -1;
            cmbMiembroExtender.SelectedIndex = -1;
            cmbMiembroFiltrar.SelectedIndex = -1;
            cmbClaseInscribir.SelectedIndex = -1;
            cmbClaseExtender.SelectedIndex = -1;
            cmbClaseFiltrar.SelectedIndex = -1;
            txtIdMiembroEliminar.Text = string.Empty;
            txtIdClaseEliminar.Text = string.Empty;
        }

        private void actualizarVista()
        {
            actualizarDgv(ClaseMiembroBusiness.GetAll());
            actualizarComboClase(cmbClaseInscribir);
            actualizarComboClase(cmbClaseExtender);
            actualizarComboClase(cmbClaseFiltrar);
            actualizarComboMiembro(cmbMiembroInscribir);
            actualizarComboMiembro(cmbMiembroExtender);
            actualizarComboMiembro(cmbMiembroFiltrar);
            limpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Inscripcion claseMiembro = new Inscripcion
                {
                    Clase = ClaseBusiness.GetById(Convert.ToInt32(cmbClaseInscribir.SelectedValue)),
                    Miembro = MiembroBusiness.BuscarMiembroPorId(Convert.ToInt32(cmbMiembroInscribir.SelectedValue)),
                    FechaVencimiento = dtpVencimiento.Value
                };
                ClaseMiembroBusiness.CargarInscripcion(claseMiembro);
                actualizarVista();
                MessageBox.Show($"Se inscribió al miembro {claseMiembro.Miembro.NombreYApellido} a la clase {claseMiembro.Clase.Descripcion}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseMiembroBusiness.ModificarFechaVencimiento(Convert.ToInt32(cmbClaseExtender.SelectedValue), Convert.ToInt32(cmbMiembroExtender.SelectedValue), dtpVencimientoExtender.Value);
                actualizarVista();
                MessageBox.Show("Se extendió la fecha de vencimiento");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"¿Desea eliminar la inscripción del miembro {txtIdMiembroEliminar.Text} a la clase {txtIdClaseEliminar.Text}?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClaseMiembroBusiness.EliminarInscripcion(Convert.ToInt32(txtIdClaseEliminar.Text), Convert.ToInt32(txtIdMiembroEliminar.Text));
                    actualizarVista();
                    MessageBox.Show("Se eliminó la inscripción correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrarPorMiembro_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMiembroFiltrar.SelectedIndex < 0)
                {
                    throw new Exception("Seleccione un miembro para filtrar");
                }
                int idMiembro = Convert.ToInt32(cmbMiembroFiltrar.SelectedValue);
                actualizarDgv(ClaseMiembroBusiness.GetAll().Where(cm => cm.Miembro.IdMiembro == idMiembro).ToList());
                cmbMiembroFiltrar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnFiltrarPorClase_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClaseFiltrar.SelectedIndex < 0)
                {
                    throw new Exception("Seleccione una clase para filtrar");
                }
                int idClase = Convert.ToInt32(cmbClaseFiltrar.SelectedValue);
                actualizarDgv(ClaseMiembroBusiness.GetAll().Where(cm => cm.Clase.IdClase == idClase).ToList());
                cmbClaseFiltrar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Mouse_Enter_PB(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Mouse_Leave_PB(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pb_home_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Close();
        }

        private void pb_miembros_Click(object sender, EventArgs e)
        {
            GestorMiembros form = new GestorMiembros();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestorClases form = new GestorClases();
            form.Show();
            this.Close();
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
