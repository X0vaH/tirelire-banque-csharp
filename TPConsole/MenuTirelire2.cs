
using cstjean.info.fg.consoleplus;

using TirelireLib;

namespace TPConsole
{
    public static class MenuTirelire2
    {
        public static void Afficher()
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
    }
}
