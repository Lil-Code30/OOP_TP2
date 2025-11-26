# Diagramme UML

```mermaid
	classDiagram
		class *Pokemon*{		
			#string nom
			#float poids
			

			*+float CalcVitesse()*;
			*+void Afficher()*;
		}

		class Pokemons{
			-static List~Pokemon~ listPokemon

			+void AfficherTousPokemon() 
			+void AfficherNbrPokemon() 
			+void VitesseMoyen() 
			+void AjoutePokemon(pokemon: Pokemon) 
			+void AfficherNbrPokemonParCategorie() 
		}
		
		class PokemonCasaniers{
			-int nbrPattes
			-float taille
			-int heuresDeVisionage
			+int nbrPokemonCasaniers = 0

			+float CalcVitesse() <<override>>
			+void Afficher() <<override>>
		}

		class PokemonCrosiere{
			-int nbrNageoires
			+int nbrPokemonCrosiere = 0

			+float CalcVitesse() <<override>>
			+void Afficher() <<override>>
		}

		class PokemonDeMers{
			-int nbrNageoires
			+int nbrPokemonDeMers = 0

			+float CalcVitesse() <<override>>
			+void Afficher() <<override>>
		}

		class PokemonSpotifs{
			-int nbrPattes
			-float taille
			-int frequenceCardiaque
			+int nbrPokemonSpotifs = 0 

			+float CalcVitesse() <<override>>
			+void Afficher() <<override>>
		}


		Pokemon <|-- PokemonCasaniers
		Pokemon <|-- PokemonCrosiere
		Pokemon <|-- PokemonDeMers
		Pokemon <|-- PokemonSpotifs
```