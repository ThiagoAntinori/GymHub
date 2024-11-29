using BLL;
using Entity;
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
    public partial class GestorMiembros : Form
    {
        public GestorMiembros()
        {
            InitializeComponent();
        }

        MembresiaBusiness membresiasBusiness = new MembresiaBusiness();
        MiembroBusiness miembroBusiness = new MiembroBusiness();
        public List<Miembro> listaBorrador = new List<Miembro>();

        public void textBox_SoloLetras(object sender, KeyPressEventArgs e)
        {
            //para que solo puedan tipear letras en textbox correspondientes
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void textBox_SoloNumeros(object sender, KeyPressEventArgs e)
        {
            //para que solo puedan tipear numeros en textbox correspondientes
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Suscripcion a los eventos de SoloNumeros y letras para los txt
            pb_ventanaNormal3.Visible = false;
            txt_elimId.KeyPress += new KeyPressEventHandler(textBox_SoloNumeros);
            txt_modId.KeyPress += new KeyPressEventHandler(textBox_SoloNumeros);
            txt_nombreApellido.KeyPress += new KeyPressEventHandler(textBox_SoloLetras);
            actualizarElementos();
        }
        private void actualizarElementos()
        {
            actualizarCombo(cb_membresia);
            actualizarCombo(cb_modMembresia);
            actualizarDGV();
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txt_correo.Text = string.Empty;
            txt_nombreApellido.Text = string.Empty;
            txt_elimId.Text = string.Empty;
            txt_modId.Text = string.Empty;
            txt_modCorreo.Text = string.Empty;
        }
        private void actualizarDGV()
        {
            try
            {
                dgv_miembros.DataSource = null;
                dgv_miembros.DataSource = miembroBusiness.GetMiembrosBusiness();
                dgv_miembros.Columns["Membresia"].Visible = false;
                dgv_miembros.Columns["MembresiaDescripcion"].HeaderText = "MEMBRESIA";
                dgv_miembros.Columns["IdMiembro"].HeaderText = "ID";
                dgv_miembros.Columns["NombreYApellido"].HeaderText = "NOMBRE Y APELLIDO";
                dgv_miembros.Columns["CorreoElectronico"].HeaderText = "CORREO ELECTRONICO";
                dgv_miembros.Columns["FechaNacimiento"].HeaderText = "FECHA DE NACIMIENTO";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void actualizarCombo(ComboBox combo)
        {
            try
            {
                combo.DataSource = null;
                combo.DataSource = membresiasBusiness.ObtenerMembresias();
                combo.DisplayMember = "Descripcion";
                combo.ValueMember = "IdMembresia";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Miembro nuevoMiembro = new Miembro
                {
                    NombreYApellido = txt_nombreApellido.Text,
                    FechaNacimiento = Convert.ToDateTime(dtp_nacimiento.Text),
                    CorreoElectronico = txt_correo.Text,
                    Membresia = new Membresia
                    {
                        IdMembresia = Convert.ToInt32(cb_membresia.SelectedValue),
                    }
                };
                miembroBusiness.CargarMiembroBusiness(nuevoMiembro);
                actualizarElementos();
                MessageBox.Show("Miembro cargado correctamente");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cargarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                Miembro nuevoMiembro = new Miembro
                {
                    NombreYApellido = txt_nombreApellido.Text,
                    FechaNacimiento = Convert.ToDateTime(dtp_nacimiento.Text),
                    CorreoElectronico = txt_correo.Text,
                    Membresia = new Membresia
                    {
                        IdMembresia = Convert.ToInt32(cb_membresia.SelectedValue),
                    }
                };
                listaBorrador.Add(nuevoMiembro);
                actualizarElementos();
                MessageBox.Show($"Se agregó al borrador. Cantidad en espera: {listaBorrador.Count}");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaBorrador.Count <= 0)
                {
                    throw new Exception("No hay miembros en espera");
                }
                miembroBusiness.CargarMultiplesMiembros(listaBorrador);
                actualizarElementos();
                MessageBox.Show("Se cargaron correctamente");
            }
            catch (Exception ex)
            {
                listaBorrador.Clear();
                MessageBox.Show(ex.Message + ". Se descartaron el resto de los miembros del borrador.");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($" Desea eliminar el miembro {txt_elimId.Text}?", "Atenci n", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txt_elimId.Text);
                    miembroBusiness.EliminarMiembroBusiness(id);
                    actualizarElementos();
                    MessageBox.Show("Se elimin  el miembro");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese los datos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Miembro modificarMiembro = new Miembro
                {
                    IdMiembro = Convert.ToInt32(txt_modId.Text),
                    CorreoElectronico = txt_modCorreo.Text,
                    Membresia = new Membresia
                    {
                        IdMembresia = Convert.ToInt32(cb_modMembresia.SelectedValue),
                    }

                };
                miembroBusiness.ModificarMiembroBusiness(modificarMiembro);
                actualizarElementos();
                MessageBox.Show("Se modific  la aplicacion");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un ID para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Botones Paneles Laterales
        private void pb_home_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();
            form.Show();
            this.Close();
        }

        private void pb_miembros_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GestorClases GC = new GestorClases();
            GC.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InscripcionClases inscripcion = new InscripcionClases();
            inscripcion.Show();
            this.Close();
        }

        //Mover Panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverPanel(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Botones Panel de Arriba
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_minimizarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_ventanaNormal3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = true;
            pb_ventanaNormal3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox5.Visible = false;
            pb_ventanaNormal3.Visible = true;
        }

       
    }

}
