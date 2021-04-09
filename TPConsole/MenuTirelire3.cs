
using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuTirelire3
    {
        public static void Afficher(Tirelire3 tirelire, string noTirelire)
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
