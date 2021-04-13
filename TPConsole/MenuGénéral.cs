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
            historique.Add(action);
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
                        Historiques("\n>> Tirelire 1");
                        MenuTirelire1();
                        break;

                    case "Tirelire 2":
                        Historiques("\n>> Tirelire 2");
                        MenuTirelire2();
                        break;

                    case "Tirelire 3a":
                        Historiques("\n>> Tirelire 3a");
                        MenuTirelire3(Instances.Tirelire3a, "3a");
                        break;

                    case "Tirelire 3b":
                        Historiques("\n>> Tirelire 3b");
                        MenuTirelire3(Instances.Tirelire3b, "3b");
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

        public static void MenuTirelire1()
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête("1", Tirelire1.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer(montant => Opérations1.Déposer(montant)),
                    () => MenuUtil.Retirer(montant => Opérations1.Retirer(montant)),
                    () => MenuUtil.Vider(() => Opérations1.Vider()));
            }
        }

        public static void MenuTirelire2()
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête("2", Tirelire2.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer(montant => Opérations2.Déposer(montant)),
                    () => MenuUtil.Retirer(montant => Opérations2.Retirer(montant)),
                    () => MenuUtil.Vider(() => Opérations2.Vider()));
            }
        }

        public static void MenuTirelire3(Tirelire3 tirelire, string noTirelire)
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(noTirelire, tirelire.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer(montant => Opérations3.Déposer(tirelire, montant)),
                    () => MenuUtil.Retirer(montant => Opérations3.Retirer(tirelire, montant)),
                    () => MenuUtil.Vider(() => Opérations3.Vider(tirelire)));
            }
        }
    }
}
