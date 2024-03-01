using SqlDataBase;
using System;
using System.Windows.Forms;

namespace RequestSystem;

internal static class Program
{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        DataBase.Name = "RequestSystem";


        Application.ThreadException += Application_ThreadException;
        Application.Run(new Forms.EnterForm());
    }

    private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
        MessageBox.Show(e.Exception.Message);
    }
}
