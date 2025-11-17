namespace OOPTP2.classes
{
    class PokemonSpotifs : Pokemon
    {
        private int nbrPattes;
        private float taille;
        private int frequenceCardiaque;

        public PokemonSpotifs(string nom, float poids,int nbrPattes, float taille, int frequenceCardiaque) : base(nom, poids)
        {
            this.taille = taille;
            this.nbrPattes = nbrPattes;
            this.frequenceCardiaque = frequenceCardiaque;
        }

        public override float CalcVitesse()
        {
            //formule : vitesse = nombre de pattes *taille * 3
            vitesse = nbrPattes * taille * 3;
            return vitesse;
            
        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis le pokémon {nom} mon poids est de {poids} kg, ma vitesse est de {CalcVitesse():F2} km/h j'ai {nbrPattes} pattes, ma taille est de {taille}m ma fréquence cardiaque est de {frequenceCardiaque} pulsations à la minute");
        }

    }
}
