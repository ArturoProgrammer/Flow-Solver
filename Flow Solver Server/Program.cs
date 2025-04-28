namespace Flow_Solver_Server
{
    internal static class Program
    {

        private static Mutex? _mutex = null;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string mutexName = "Global\\{D3D4A7E9-1A28-41DF-883D-5DF1B1BA6FE2}";
            bool isNewInstance = false;

            _mutex = new Mutex(true, mutexName, out isNewInstance);

            if (isNewInstance)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new main_windows());
            } else
            {
                MessageBox.Show("Ya hay una instancia de Flow Solver Server ejecutandose", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _mutex.ReleaseMutex();
            _mutex.Dispose();
        }
    }
}