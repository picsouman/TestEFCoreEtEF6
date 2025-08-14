# Solution .NET Multi-Target

Test architecture en couches pour supporter à la fois Entity Framework 6 (.NET Framework) et Entity Framework Core (.NET 8) dans une même application.

## Architecture de la Solution

### Vue d'ensemble des projets

| Projet | Framework | Description |
|--------|-----------|-------------|
| **Entities** | .NET Standard 2.0 | Modèles de données et entités |
| **InterfaceRepos** | .NET Standard 2.0 | Interfaces des repositories |
| **BusinessLogic** | .NET Standard 2.0 | Logique métier de l'application |
| **RepoEF6** | .NET Framework 4.8 | Implémentation des repositories avec Entity Framework 6 |
| **RepoEFCore** | .NET 8.0 | Implémentation des repositories avec Entity Framework Core |
| **WebHost** | .NET 8.0 | Application web hôte |

## Dépendances entre Projets

```
WebHost (.NET 8.0)
├── BusinessLogic
├── Entities  
├── InterfaceRepos
├── RepoEF6
└── RepoEFCore

BusinessLogic (.NET Standard 2.0)
└── InterfaceRepos

InterfaceRepos (.NET Standard 2.0)
└── Entities

RepoEF6 (.NET Framework 4.8)
├── Entities
└── InterfaceRepos

RepoEFCore (.NET 8.0)
├── Entities
└── InterfaceRepos

Entities (.NET Standard 2.0)
└── (aucune dépendance)
```
