
using System;
using System.Diagnostics;

using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuUtil
    {
        public static void AfficherEntête(string arg1, decimal arg2)
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

        public static void Déposer(Func<decimal, bool> déposerDsTirelire)
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (déposerDsTirelire(montant))
                {
                    ConsolePlus.MessageOkBloquant("Dépôt réussi");
                    MenuGénéral.Historiques("> Déposer " + montant + "");
                }
                else
                {
                    ConsolePlus.MessageErreurBloquant("Échec du dépôt");
                }
            }
            else
            {
                ConsolePlus.Poursuivre();
            }
        }

        public static void Déposer9(Func<decimal, bool> déposerDsTirelire)
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (Math.Round(montant, 2) != montant)
                {
                    ConsolePlus.MessageErreurBloquant($"Impossible de déposer des fractions de cents.\n" +
                        "Le montant est trop précis.");
                }
                else if (déposerDsTirelire(montant))
                {
                    ConsolePlus.MessageOkBloquant("Dépôt réussi");
                    MenuGénéral.Historiques("> Déposer " + montant + "");
                }
                else if (montant < 0)
                {
                    ConsolePlus.MessageErreurBloquant($"Impossible de déposer {montant:C}.\n" +
                        "Le montant doit être positif.");
                }
            }
            else
            {
                ConsolePlus.Poursuivre();
            }
        }

        public static void Retirer9(Func<decimal, bool> retirerDsTirelire, Tirelire9 tirelire)
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (Math.Round(montant, 2) != montant)
                {
                    ConsolePlus.MessageErreurBloquant($"Impossible de retirer des fractions de cents.\n" +
                        "Le montant est trop précis.");
                }
                else if (retirerDsTirelire(montant))
                {
                    ConsolePlus.MessageOkBloquant("Retrait réussi");
                    MenuGénéral.Historiques("> Retirer " + montant + "");
                }
                else if (montant <= 0)
                {
                    ConsolePlus.MessageErreurBloquant($"Impossible de retirer {montant:C}.\n" +
                        "Le montant doit être positif.");
                }
                else if (montant > tirelire.MontantTotal)
                {
                    ConsolePlus.MessageErreurBloquant($"Impossible de retirer {montant:C}.\n" +
                        "Actif insuffisant.");
                }
            }
            else
            {
                ConsolePlus.Poursuivre();
            }
        }

        public static void Retirer(Func<decimal, bool> retirerDsTirelire)
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (retirerDsTirelire(montant))
                {
                    ConsolePlus.MessageOkBloquant("Retrait réussi");
                    MenuGénéral.Historiques("> Retirer " + montant + "");
                }
                else
                {
                    ConsolePlus.MessageErreurBloquant("Échec du retrait");
                }
            }
            else
            {
                ConsolePlus.Poursuivre();
            }
        }

        public static void Vider(Func<decimal> viderDsTirelire)
        {
            var montant = viderDsTirelire();

            MenuGénéral.Historiques("> Vider " + montant + "");
            ConsolePlus.MessageOkBloquant($"La tirelire a été vidée. Montant récupéré: {montant:C}", viderDsTirelire());
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
