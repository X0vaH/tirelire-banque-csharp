
using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuTirelire3b
    {
        private static Tirelire3 tirelireActive = null!;

        public static void Afficher(Tirelire3 tirelire, string noTirelire)
        {
            tirelireActive = tirelire;
            do
            {
                ConsolePlus.Clear();
                MenuUtil.AfficherEntête(noTirelire, Instances.Tirelire3b.MontantTotal);
            } while (MenuUtil.TraiterMenuEtContinuer(Déposer, Retirer, Vider));
        }

        private static void Déposer()
        {
            if (ConsolePlus.LireDécimal("Montant", out decimal montant))
            {
                if (Opérations3.Déposer(tirelireActive, montant))
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
                if (Opérations3.Retirer(tirelireActive, montant))
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
            var montant = Opérations3.Vider(tirelireActive);

            MenuGénéral.Historiques("Vider " + montant + "");
            ConsolePlus.MessageOkBloquant($"La tirelire a été vidée. Montant récupéré: {montant:C}", Opérations3.Vider(tirelireActive));
            Instances.Tirelire3b.MontantTotal = 0;
        }

    }
}
