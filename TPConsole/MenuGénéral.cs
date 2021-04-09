using System;
using System.Collections.Generic;
using System.Diagnostics;

using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuGénéral
    {
        private static List<string> historique = new List<string>();

        public static void Afficher()
        {
            do
            {
                ConsolePlus.Clear();
                AfficherEntête();
            } while (TraiterMenuEtContinuer());
        }

        public static void Historiques(string action)
        {
            historique.Add("> " + action + " ");
        }

        public static string GénérerHistorique()
        {
            return string.Join(" ", historique);
        }

        private static void AfficherEntête()
        {
            ConsolePlus.WriteLine();
            ConsolePlus.WriteLine(ConsoleColor.Magenta, "AH - Menu général");
            ConsolePlus.WriteLine(ConsoleColor.Magenta, "===============");
            ConsolePlus.WriteLine();
            ConsolePlus.WriteLine("Historique: " + GénérerHistorique() + " ");
            ConsolePlus.WriteLine();
            ConsolePlus.Afficher("Tirelire 1", $"{Tirelire1.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 2", $"{Tirelire2.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 3a", $"{Instances.Tirelire3a.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 3b", $"{Instances.Tirelire3b.MontantTotal:C}");

            ConsolePlus.WriteLine();
        }

        private static bool TraiterMenuEtContinuer()
        {
            if (ConsolePlus.LireChoix(out string? choix, 'A',
                    "Quitter", "Reset", "Tirelire 1", "Tirelire 2", "Tirelire 3a", "Tirelire 3b"))
            {
                ConsolePlus.WriteLine();
                switch (choix)
                {
                    case "Tirelire 1":
                        Historiques("Tirelire 1");
                        MenuTirelire1.Afficher();
                        break;

                    case "Tirelire 2":
                        Historiques("Tirelire 2");
                        MenuTirelire2.Afficher();
                        break;

                    case "Tirelire 3a":
                        Historiques("Tirelire 3a");
                        MenuTirelire3a.Afficher(Instances.Tirelire3a, "3a");
                        break;

                    case "Tirelire 3b":
                        Historiques("Tirelire 3a");
                        MenuTirelire3b.Afficher(Instances.Tirelire3b, "3b");
                        break;

                    case "Reset":
                        Reset();
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
        private static void Reset()
        {
            Console.WriteLine();
            if (ConsolePlus.LireBooléen("Voulez-vous vraiment (o/n)", out bool daccord))
            {
                if (daccord)
                {
                    Tirelire1.MontantTotal = 0;
                    Tirelire2.MontantTotal = 0;
                    Instances.Tirelire3a.MontantTotal = 0;
                    Instances.Tirelire3b.MontantTotal = 0;
                    historique.Clear();
                }
            }
        }
    }
}
