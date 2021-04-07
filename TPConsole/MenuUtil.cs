
using System;

using cstjean.info.fg.consoleplus;

namespace TPConsole
{
    public static class MenuUtil
    {
        public static void AfficherEntête(int arg1, decimal arg2)
        {
            ConsolePlus.WriteLine();
            ConsolePlus.WriteLine(ConsoleColor.Magenta, "AH - Tirelire " + arg1 + "");
            ConsolePlus.WriteLine(ConsoleColor.Magenta, "===============");
            ConsolePlus.WriteLine();
            ConsolePlus.WriteLine("Historique: " + MenuGénéral.GénérerHistorique() + " ");
            ConsolePlus.WriteLine();
            ConsolePlus.Afficher("Actif", $"{arg2:C}");
            ConsolePlus.WriteLine();
        }

        public static bool TraiterMenuEtContinuer(Action déposer, Action retirer, Action vider)
        {
            if (ConsolePlus.LireChoix(out string? choix, '0',
                    "Quitter", "Déposer", "Retirer", "Vider"))
            {
                ConsolePlus.WriteLine();
                switch (choix)
                {
                    case "Déposer":
                        déposer();
                        break;

                    case "Retirer":
                        retirer();
                        break;

                    case "Vider":
                        vider();
                        break;

                    case "Quitter":
                        return false;

                    default:
                        Debug.Fail($"Cas non traité: {choix}");
                        break;
                }

            }
            return true;
        }
    }
}
