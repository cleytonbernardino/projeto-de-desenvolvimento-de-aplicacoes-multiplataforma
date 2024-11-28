namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DotNetEnv.Env.Load();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            frmLogin loginForm = new frmLogin();
            Application.Run(loginForm);
            if (loginForm.IsLogged)
            {
                Application.Run(new frmMenu());
            }
        }
    }
}