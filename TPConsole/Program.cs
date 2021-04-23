
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
            try
            {
                MenuGénéral.Afficher();
            }
            catch (InvalidOperationException ex)
            {
                // Normalement il faudrait catcher Exception ici. 
                // Mais on se limite à InvalidOperationException pour faciliter le débogage.
                ConsolePlus.MessageErreurBloquant(
                    "Désolé, une erreur inattendue s'est produite."
                    + "\nLe programme doit malheureusement fermer."
                    + $"\n{ex.GetType().Name} : {ex.Message}");
            }

        }

        private static void ExitHandler(object? sender, EventArgs e)
        {
            Persistance.Sauvegarder();
        }
    }
}
