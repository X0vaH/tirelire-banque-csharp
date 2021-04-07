using System;
using System.Diagnostics;

using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuTirelire2
    {
        public static void Afficher()
        {
            do
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(2, Tirelire2.MontantTotal);
            } while (MenuUtil.TraiterMenuEtContinuer(Déposer, Retirer, Vider));
        }

        private static void Déposer()
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (Tirelire2.Déposer(montant))
                {
                    ConsolePlus.MessageOkBloquant("Dépôt réussi");
                    MenuGénéral.Historiques("Déposer " + montant + "");
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
                if (Tirelire2.Retirer(montant))
                {
                    ConsolePlus.MessageOkBloquant("Retrait réussi");
                    MenuGénéral.Historiques("Retirer " + montant + "");
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
            MenuGénéral.Historiques("Vider " + Tirelire2.MontantTotal + "");
            ConsolePlus.MessageOkBloquant($"La tirelire a été vidée. Montant récupéré: {Tirelire2.MontantTotal:C}", Tirelire2.Vider());
            Tirelire2.MontantTotal = 0;
        }

    }
}
