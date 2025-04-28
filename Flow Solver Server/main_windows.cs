namespace Flow_Solver_Server
{
    public partial class main_windows : Form
    {
        public main_windows()
        {
            Properties.Settings oDef = Properties.Settings.Default;
            ServerCredentialsBox.Show();

            // Inicializamos la ventana
            InitializeComponent();
        }

        private void main_windows_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
