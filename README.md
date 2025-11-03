# 🎓 INF11107 - Programmation orientée objet I
## Travail Pratique #2 — Automne 2025

### 🗓️ Informations générales
- **Date de remise :** avant **16h00 le 2 décembre**
- **Travail en groupe de 4 étudiants** — *les mêmes groupes que pour le projet*

---

## 🧩 Question 1 — (5 points)

Soit le **diagramme de classes détaillé suivant :**

### 1️⃣ Correction du diagramme
> Proposez une **correction à chaque erreur** présente dans le diagramme.

### 2️⃣ Nombre d’attributs et de méthodes

| Classe | Nombre d’attributs | Nombre de méthodes |
|:-------|:------------------:|:------------------:|
| A      |                    |                    |
| B      |                    |                    |
| C      |                    |                    |

### 3️⃣ Constructeurs
> Proposez un **constructeur** pour chaque classe.

### 4️⃣ Déclaration des méthodes
> Donnez la **déclaration de chaque méthode** du diagramme.

### 5️⃣ Instructions du `Main` à corriger ou barrer

```csharp
A obja = new A(10, 11, 12, 13);
B objb = new B(1, 2, 3, 4);
C objc = new C(6, 7, 8, 9);
```

### 6️⃣ Instructions à corriger ou à exécuter

Pour chaque instruction ci-dessous :
- Indiquez son affichage attendu, **ou barrez-la** si elle est erronée.

```csharp
Console.Write(objc.Somme(10));
Console.Write(objb.Moyenne(4));
Console.Write(objb.Multiplication(objc));
Console.Write(objc.Multiplication(objc.a3));
Console.Write(objb.Multiplication(objc.a3));
Console.Write(objc.Moyenne(4));
Console.Write(objb.a2 + " " + objc.a2);
Console.Write(objb.a3 + " " + objc.a3);
```

---

## 🐉 Question 2 — (10 points)

Les **Pokémons** sont des animaux passionnés par la programmation orientée objet, et notamment par le **polymorphisme**.

Il existe **quatre grandes catégories** de Pokémons :

---

### 🏃‍♂️ Pokémons sportifs
- **Attributs :** nom, poids (kg), nombre de pattes, taille (m), fréquence cardiaque (pulsations/min)
- **Vitesse :**
  ```
  vitesse = nombreDePattes * taille * 3
  ```

### 🏠 Pokémons casaniers
- **Attributs :** nom, poids (kg), nombre de pattes, taille (m), heures de télévision par jour
- **Vitesse :**
  ```
  vitesse = nombreDePattes * taille * 3
  ```

### 🌊 Pokémons des mers
- **Attributs :** nom, poids (kg), nombre de nageoires
- **Vitesse :**
  ```
  vitesse = (poids / 25) * nombreDeNageoires
  ```

### 🚢 Pokémons de croisière
- **Attributs :** nom, poids (kg), nombre de nageoires
- **Vitesse :**
  ```
  vitesse = ((poids / 25) * nombreDeNageoires) / 2
  ```

---

### 🖥️ Affichage des Pokémons

Chaque Pokémon doit pouvoir être **affiché** sous forme de phrase descriptive :

- **Pokémon sportif :**
  > "Je suis le pokémon Pikachu, mon poids est de 18 kg, ma vitesse est de 5,1 km/h, j'ai 2 pattes, ma taille est de 0,85 m, ma fréquence cardiaque est de 120 pulsations à la minute."

- **Pokémon casanier :**
  > "Je suis le pokémon Salameche, mon poids est de 12 kg, ma vitesse est de 3,9 km/h, j'ai 2 pattes, ma taille est de 0,65 m, je regarde la télé 8 h par jour."

- **Pokémon des mers :**
  > "Je suis le pokémon Rondoudou, mon poids est de 45 kg, ma vitesse est de 3,6 km/h, j'ai 2 nageoires."

- **Pokémon de croisière :**
  > "Je suis le pokémon Bulbizarre, mon poids est de 15 kg, ma vitesse est de 0,9 km/h, j'ai 3 nageoires."

---

### 🔧 À réaliser

#### 1️⃣
> Réaliser un **diagramme de classes** représentant la hiérarchie des Pokémons.

#### 2️⃣
> **Programmer ces classes en C#.**

#### 3️⃣
> Définir une **classe `Pokemons`** contenant une **liste privée** pouvant stocker des Pokémons de toutes catégories.

Cette classe doit inclure :
- Un **constructeur**
- Une méthode `AjouterPokemon()`
- Une méthode `AfficherTousLesPokemons()`
- Une méthode `AfficherNombreParCategorie()`
- Une méthode `CalculerVitesseMoyenne()`

#### 4️⃣
> Créer **deux Pokémons de chaque type.**

#### 5️⃣
> Afficher **tous les Pokémons créés.**

#### 6️⃣
> Afficher :
- Le **nombre de Pokémons par catégorie**
- Le **nombre total** de Pokémons créés

#### 7️⃣
> Afficher la **vitesse moyenne** des Pokémons créés.

---
