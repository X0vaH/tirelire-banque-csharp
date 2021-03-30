using System;
using System.Diagnostics;

using cstjean.info.fg.consoleplus;

using static TirelireLib.Tirelire1;

namespace TPConsole
{
    public static class MenuTirelire1
    {
        public static void Afficher()
        {
            do
            {
                ConsolePlus.Clear();
                AfficherEntête();
            } while (TraiterMenuEtContinuer());
        }

        private static void AfficherEntête()
        {
            ConsolePlus.WriteLine();
            ConsolePlus.WriteLine(ConsoleColor.Magenta, "AH - Tirelire 1");
            ConsolePlus.WriteLine(ConsoleColor.Magenta, "===============");
            ConsolePlus.WriteLine();
            ConsolePlus.Afficher("Actif", $"{MontantTotal:C}");
            ConsolePlus.WriteLine();
        }

        private static bool TraiterMenuEtContinuer()
        {
            if (ConsolePlus.LireChoix(out string? choix, '0',
                    "Quitter", "Déposer", "Retirer", "Vider"))
            {
                ConsolePlus.WriteLine();
                switch (choix)
                {
                    case "Déposer":
                        Déposer();
                        break;

                    case "Retirer":
                        Retirer();
                        break;

                    case "Vider":
                        Vider();
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

        private static void Déposer()
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (Opérations1.Déposer(montant))
                {
                    ConsolePlus.MessageOkBloquant("Dépôt réussi");
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

        private static void Retirer()
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (Opérations1.Retirer(montant))
                {
                    ConsolePlus.MessageOkBloquant("Retrait réussi");
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

        private static void Vider()
        {
            ConsolePlus.MessageOkBloquant("La tirelire a été vidée. Montant récupéré: {0},00 $", Opérations1.Vider());
            MontantTotal = 0;
        }

    }
}
