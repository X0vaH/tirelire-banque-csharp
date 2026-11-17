# 🐷 Tirelire & Banque — Programmation orientée objet en C#

Série de travaux pratiques en **C# / .NET** qui fait évoluer une simple **tirelire** jusqu'à un **compte bancaire**, étape par étape, pour mettre en pratique les principes de la programmation orientée objet. Le tout est piloté par une **application console à menus** avec **sauvegarde JSON**, et validé par une suite de **100 tests unitaires MSTest** (tous réussis).

> Projet réalisé au cégep (hiver 2021), cours de programmation orientée objet.

---

## ✨ Ce que montre le projet

Chaque tirelire ajoute une notion par rapport à la précédente :

| Étape | Classe | Notion travaillée |
| --- | --- | --- |
| 1 | `Tirelire1` + `Opérations1` | classe **statique** et propriété statique |
| 2 | `Tirelire2` | méthodes statiques avec **validation** (`Déposer`, `Retirer`, `Vider`) |
| 3–4 | `Tirelire3`, `Tirelire4` + `Opérations3/4` | passage aux **instances** (plusieurs tirelires indépendantes) |
| 5 | `Tirelire5 : ActifDeBase` | **classe abstraite** de base |
| 6 | `Tirelire6` | **méthodes d'instance** (encapsulation du comportement) |
| 7 | `Tirelire7 : Tirelire6` | **héritage** et initialisation |
| 9 | `Tirelire9` | version finale de la tirelire |
| Banque | `Compte1 : Tirelire9` | **compte bancaire** (numéro, titulaire), constructeur de copie, `Equals` / `GetHashCode` / `ToString`, **exceptions** (`ArgumentOutOfRangeException`) |

Règles communes : on ne peut déposer qu'un montant positif, ni retirer plus que le solde ; `Vider()` retourne le montant retiré et remet le solde à zéro.

### Application console (`TPConsole`)

- **Menu général** pour choisir une tirelire, puis un sous-menu **Déposer / Retirer / Vider**.
- **Historique** des actions de la session.
- **Persistance** : l'état de toutes les tirelires est sauvegardé dans `program-data.json` à la fermeture et rechargé au démarrage.
- Option **Reset** (avec confirmation) et option **Planter** pour démontrer la gestion d'erreur globale.

## 🗂️ Structure

```
TirelireLib/        Classes Tirelire1 → Tirelire9, ActifDeBase, Opérations*
TirelirePlusLib/    Bibliothèque d'extensions (ébauche)
BanqueLib/          Compte1 (compte bancaire)
TPConsole/          Application console : menus, historique, persistance JSON
Tests/              Tests unitaires MSTest (100 tests)
```

## 🧰 Stack technique

- C# 9 / .NET 5
- MSTest
- `System.Text.Json`
- [`cstjean.info.fg.consoleplus`](https://www.nuget.org/packages/cstjean.info.fg.consoleplus) (utilitaires console, NuGet)

---

## 🚀 Installation et lancement

### Prérequis

- [SDK .NET](https://dotnet.microsoft.com/download) 5 ou plus récent
- Si seul un runtime plus récent que .NET 5 est installé (ex. .NET 8), définir `DOTNET_ROLL_FORWARD=Major` avant de lancer :
  - PowerShell : `$env:DOTNET_ROLL_FORWARD="Major"`
  - Bash : `export DOTNET_ROLL_FORWARD=Major`

### Lancer l'application console

```bash
git clone https://github.com/X0vaH/tirelire-banque-csharp.git
cd tirelire-banque-csharp
dotnet run --project TPConsole
```

Naviguer avec les choix du menu ; quitter avec **Quitter** pour sauvegarder l'état.

### Lancer les tests

```bash
dotnet test
```

Résultat attendu : `Réussi! - échec : 0, réussite : 100`.

Vous pouvez aussi ouvrir `2A6 Banque 2021.sln` dans **Visual Studio** et utiliser l'**Explorateur de tests**.

## 👤 Auteur

**Alex Héroux** ([@X0vaH](https://github.com/X0vaH))
