
using System;

using cstjean.info.fg.consoleplus;

namespace TPConsole
{
    public class Program
    {
        public static void Main()
        {
            ConsolePlus.Title = "AH - TP Banque";
            ConsolePlus.IndentationGénérale = 1;
            Persistance.Charger();
            AppDomain.CurrentDomain.ProcessExit += ExitHandler;
            MenuGénéral.Afficher();
        }

        private static void ExitHandler(object? sender, EventArgs e)
        {
            Persistance.Sauvegarder();
        }
    }
}
