using System;
using System.Collections.Generic;
using System.Diagnostics;

using cstjean.info.fg.consoleplus;

using TirelireLib;

using static TPConsole.Instances;

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
            ConsolePlus.Afficher("Tirelire 3a", $"{MesInstances.Tirelire3a.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 3b", $"{MesInstances.Tirelire3b.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 4a", $"{MesInstances.Tirelire4a.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 5a", $"{MesInstances.Tirelire5a.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 6a", $"{MesInstances.Tirelire6a.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 6p", $"{MesInstances.Tirelire6p.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 7a", $"{MesInstances.Tirelire7a.MontantTotal:C}");
            ConsolePlus.Afficher("Tirelire 9a", $"{MesInstances.Tirelire9a.MontantTotal:C}");
            ConsolePlus.WriteLine();
        }

        private static bool TraiterMenuEtContinuer()
        {
            if (ConsolePlus.LireChoix(out string? choix, 'A',
                    "Quitter", "Reset", "Planter", "Tirelire 1", "Tirelire 2", "Tirelire 3a"
                    , "Tirelire 3b", "Tirelire 4a", "Tirelire 5a", "Tirelire 6a", "Tirelire 6p", "Tirelire 7a", "Tirelire 9a"))
            {
                ConsolePlus.WriteLine();
                switch (choix)
                {
                    case "Planter":
                        throw new InvalidOperationException("AH dit Boom!");

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
                        MenuTirelire3(MesInstances.Tirelire3a, "3a");
                        break;

                    case "Tirelire 3b":
                        Historiques("\n>> Tirelire 3b");
                        MenuTirelire3(MesInstances.Tirelire3b, "3b");
                        break;

                    case "Tirelire 4a":
                        Historiques("\n>> Tirelire 4a");
                        MenuTirelire4(MesInstances.Tirelire4a, "4a");
                        break;

                    case "Tirelire 5a":
                        Historiques("\n>> Tirelire 5a");
                        MenuTirelire5(MesInstances.Tirelire5a, "5a");
                        break;

                    case "Tirelire 6a":
                        Historiques("\n>> Tirelire 6a");
                        MenuTirelire6(MesInstances.Tirelire6a, "6a");
                        break;

                    case "Tirelire 6p":
                        Historiques("\n>> Tirelire 6p");
                        MenuTirelire6(MesInstances.Tirelire6p, "6p");
                        break;

                    case "Tirelire 7a":
                        Historiques("\n>> Tirelire 7a");
                        MenuTirelire7(MesInstances.Tirelire7a, "7a");
                        break;

                    case "Tirelire 9a":
                        Historiques("\n>> Tirelire 9a");
                        MenuTirelire9(MesInstances.Tirelire9a, "9a");
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
                    MesInstances.Tirelire3a.MontantTotal = 0;
                    MesInstances.Tirelire3b.MontantTotal = 0;
                    MesInstances.Tirelire4a.MontantTotal = 0;
                    MesInstances.Tirelire5a.MontantTotal = 0;
                    MesInstances.Tirelire6a.MontantTotal = 0;
                    MesInstances.Tirelire6p.MontantTotal = 0;
                    MesInstances.Tirelire7a.MontantTotal = 0;
                    MesInstances.Tirelire9a.MontantTotal = 0;
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

        private static void MenuTirelire4(Tirelire4 tirelire, string noTirelire)
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(noTirelire, tirelire.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer(montant => Déposer(tirelire, montant)),
                    () => MenuUtil.Retirer(montant => Retirer(tirelire, montant)),
                    () => MenuUtil.Vider(() => Vider(tirelire)));
            }
        }

        private static void MenuTirelire5(Tirelire5 tirelire, string noTirelire)
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(noTirelire, tirelire.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer(montant => Tirelire5.Déposer(tirelire, montant)),
                    () => MenuUtil.Retirer(montant => Tirelire5.Retirer(tirelire, montant)),
                    () => MenuUtil.Vider(() => Tirelire5.Vider(tirelire)));
            }
        }

        private static void MenuTirelire6(Tirelire6 tirelire, string noTirelire)
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(noTirelire, tirelire.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer(montant => tirelire.Déposer(montant)),
                    () => MenuUtil.Retirer(montant => tirelire.Retirer(montant)),
                    () => MenuUtil.Vider(() => tirelire.Vider()));
            }
        }

        private static void MenuTirelire7(Tirelire7 tirelire, string noTirelire)
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(noTirelire, tirelire.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer(montant => tirelire.Déposer(montant)),
                    () => MenuUtil.Retirer(montant => tirelire.Retirer(montant)),
                    () => MenuUtil.Vider(() => tirelire.Vider()));
            }
        }

        private static void MenuTirelire9(Tirelire9 tirelire, string noTirelire)
        {
            var continuer = true;
            while (continuer)
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(noTirelire, tirelire.MontantTotal);
                continuer = MenuUtil.TraiterMenuEtContinuer(
                    () => MenuUtil.Déposer9(montant => tirelire.Déposer(montant)),
                    () => MenuUtil.Retirer9(montant => tirelire.Retirer(montant), tirelire),
                    () => MenuUtil.Vider(() => tirelire.Vider()));
            }
        }

        public static bool Déposer(this Tirelire4 tirelire, decimal montant)
        {
            if (montant > 0)
            {
                tirelire.MontantTotal += montant;
                return true;
            }

            return false;
        }
        public static bool Retirer(this Tirelire4 tirelire, decimal montant)
        {
            if (montant > 0 && montant <= tirelire.MontantTotal)
            {
                tirelire.MontantTotal -= montant;
                return true;
            }

            return false;
        }
        public static decimal Vider(this Tirelire4 tirelire)
        {
            decimal argentTotal = tirelire.MontantTotal;
            tirelire.MontantTotal = 0;
            return argentTotal;
        }
    }

}
