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

        }

        private void btnInscripcion_Click_1(object sender, EventArgs e)
        {
            InscripcionClases IC = new InscripcionClases();
            IC.Show();
            this.Hide();
        }
    }
}
