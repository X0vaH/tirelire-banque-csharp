
using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuTirelire1
    {
        public static void Afficher()
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
    }
}
