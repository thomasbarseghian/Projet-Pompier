# Gestion de caserne de pompiers

<img width="1366" height="725" alt="Capture d’écran (19)" src="https://github.com/user-attachments/assets/3a451b13-a899-41ae-bfa6-871397708f2d" />

Gestion de Casernes de Pompiers, a été développé en 5 semaines dans le cadre d’un projet tutoré par un groupe de 3 étudiants.
L’application est réalisée en C# (.NET Framework) avec une base de données SQLite. Elle permet une gestion complète des casernes de pompiers, incluant la supervision des missions, du matériel, des engins, et du personnel. Plusieurs casernes peuvent être créées, consultées et gérées, avec des liaisons entre elles pour une coordination efficace. 

## Technologies Utilisées
- **C# .NET** - Windows Forms
- **SQLite** - Base de données relationnelle
- **iTextSharp** - Génération de rapports PDF
- **Git** - Gestion collaborative de version

## Installation et Utilisation
1. **Cloner le repository** :
   ```bash
   git clone https://github.com/AbdullahPro2/Gestion-de-caserne-de-pompiers.git
   ```

2. **Ouvrir la solution** dans Visual Studio

3. **Configurer la base de données** :
   - Vérifier la connexion SQLite dans `Connexion.cs`
   - Les relations entre tables sont gérées automatiquement

4. **Compiler et exécuter** :
   - Le formulaire principal `mainLayout` charge dynamiquement les UserControls
   - Utiliser les identifiants admin pour accéder aux fonctionnalités étendues
     (login : vrichard, mdp : mdpVero)

## Architecture
- **Mode déconnecté** : `MesDatas.cs` pour les opérations batch
- **Mode connecté** : `Connexion.cs` pour les opérations temps réel
- **UserControls modulaires** : Chargement dynamique dans `pnlMainLayout`
- **Classes utilitaires** : `GenerateurPdf`, `HabilitationItem`

## Fonctionnalités
- **Gestion des ressources humaines** : Consultation profils pompiers, habilitations, grades, affectations
- **Tableau de bord missions** : Visualisation, clôture et génération PDF
- **Création de nouvelles missions**
- **Gestion des engins** : Liaison données véhicules-caserne
- **Statistiques**
- **Système d'authentification** : admin

**Architecture technique :**
- Dualité **mode connecté/déconnecté** avec classes `Connexion.cs` et `MesDatas.cs`
- Navigation via **UserControls** dynamiques dans un `mainLayout`
- Génération PDF avec **iTextSharp**
- Base **SQLite** avec relations complexes
