namespace OOPTP2.classes
{
    abstract class  Pokemon
    {
        protected string nom;
        protected float poids;
        
        public Pokemon(string nom, float poids)
        {
            this.nom = nom;
            this.poids = poids;
        }

        public string Nom
        {
              get { return nom; }
        }

        public float Poids
        {
            get { return poids; }
        }


        abstract public float CalcVitesse();
        abstract public void Afficher();
    }
}
