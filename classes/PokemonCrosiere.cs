namespace OOPTP2.classes
{
    class PokemonCrosiere : Pokemon
    {
        private int nbrNageoires;

        public PokemonCrosiere(string nom, float poids, int nbrNageoires) : base(nom, poids)
        {

            this.nbrNageoires = nbrNageoires;
        }

        public override float CalcVitesse()
        {
            //formule : ((poids / 25) * nombre de nageoires) / 2
            return  ((poids / 25) * nbrNageoires) / 2;

        }

        public override void Afficher()
        {
            Console.WriteLine($"Je suis le pokémon {nom} mon poids est de {poids} kg, ma vitesse est de {CalcVitesse():F2} km/h j'ai {nbrNageoires} nageoires.");
        }
    }
}
