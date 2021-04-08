
using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuTirelire1
    {
        public static void Afficher()
        {
            do
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête("1", Tirelire1.MontantTotal);
            } while (MenuUtil.TraiterMenuEtContinuer(Déposer, Retirer, Vider));
        }
        private static void Déposer()
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (Opérations1.Déposer(montant))
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
                if (Opérations1.Retirer(montant))
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
            MenuGénéral.Historiques("Vider " + Tirelire1.MontantTotal + "");
            ConsolePlus.MessageOkBloquant($"La tirelire a été vidée. Montant récupéré: {Tirelire1.MontantTotal:C}", Opérations1.Vider());
            Tirelire1.MontantTotal = 0;
        }

    }
}
