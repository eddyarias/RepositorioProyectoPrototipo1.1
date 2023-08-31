using ProyectoPrototipo_1._0;

namespace ProyectoPrototipo_1._1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Login());
        }
    }
}