namespace OOPTP2.classes
{
    class PokemonCasaniers : Pokemon
    {
        private int nbrPattes;
        private float taille;
        private int heuresDeVisionnage;

        public PokemonCasaniers(string nom, float poids, int nbrPattes, float taille, int heuresDeVisionnage) : base(nom, poids)
        {
            this.taille = taille;
            this.nbrPattes = nbrPattes;
            this.heuresDeVisionnage = heuresDeVisionnage;
        }

        public override float ClacVitesse()
        {
            //formule : vitesse = nombre de pattes *taille * 3
            vitesse = nbrPattes * taille * 3;
            return vitesse;

        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis le pokémon {nom} mon poids est de {poids} kg, ma vitesse est de {ClacVitesse():F2} km/h j'ai {nbrPattes} pattes, ma taille est de {taille}m  je regarde la télé {heuresDeVisionnage}h par jour");
        }
    }
}
