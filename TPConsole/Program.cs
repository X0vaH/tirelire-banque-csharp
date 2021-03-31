
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
            MenuTirelire1.Afficher();
            Persistance.Sauvegarder();
        }
    }
}
