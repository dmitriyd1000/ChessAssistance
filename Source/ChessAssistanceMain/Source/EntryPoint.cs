using ChessAssistanceMain.Source.View;

namespace ChessAssistanceMain.Source
{
    public static class EntryPoint
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}