# Distributeur automatique de boisson chaude
Features : Pouvoir commander une boisson 

# Enoncé
- Input : Sélectionner le nom de la boisson
- Output : Afficher le prix de vente de la boisson

# IMPLEMENTATION

## Stack Technique

- Language: `C#`
- Framework: `.Net Core`
- Unit test framework: `XUnit`

## Description

Prix coûtant des recettes : calculé en fonction des doses de produits qui constituent la recette
Prix de vente : Prix coûtant des recettes + marge de 30%

Produits :
Produits	Prix
Café	1 €
Sucre	0,1 €
Crème	0,5€
Thé	2 €
Eau	0,2 €
Chocolat	1 €
Lait	0,4 €

| Produits        | Prix           |
| ------------- |:-------------:   |
|Café           | 1  €             |
| Sucre         | 0,1 €            |
| Crème         | 0,5€             |
| Thé           | 2 €              |
| Eau           | 0,2 €            |
| Chocolat      | 1 €              |
| Lait          | 0,4 €            |

Recettes :

| Nom des recettes        | Ingrédients                                                                   |
| -------------           |:-------------:                                                                |
|Expresso                 | 1 dose de café, 1 dose d’eau                                                  |
| Allongé                 | 1 dose de café, 2 doses d’eau                                                 |
| Capuccino               | Capuccino	1 dose de café, 1 dose de chocolat, 1 dose d’eau, 1 dose de crème |
| Chocolat                |3 doses de chocolat, 2 doses de lait, 1 dose d’eau, 1 dose de sucre            |
| The                     | 1 dose de thé, 2 doses d’eau                                                  |
# RUN
Exemple:

<a href="https://imgbb.com/"><img src="https://i.ibb.co/0ytppm0/1.jpg" alt="1" border="0"></a>

**Build**
```shell
donet build
```

**Lancer**
```shell
donet run
```
**Tester**
```shell
donet test
```

