using System.Runtime.InteropServices;
namespace UI  
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            GestorMiembros GM = new GestorMiembros();
            GM.Show();
            this.Hide();
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            GestorClases GC = new GestorClases();
            GC.Show();
            this.Hide();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            InscripcionClases IC = new InscripcionClases();
            IC.Show();
            this.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb_ventanaNormal.Visible = false;
        }

        private void btnInscripcion_Click_1(object sender, EventArgs e)
        {
            InscripcionClases IC = new InscripcionClases();
            IC.Show();
            this.Hide();
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

        //Botones de los paneles de arriba
        private void pb_CerrarVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
            pb_ventanaNormal.Visible = true;
        }

        private void pb_guardarVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb_ventanaNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox3.Visible = true;
            pb_ventanaNormal.Visible = false;
        }
    }
}
