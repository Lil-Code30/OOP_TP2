namespace OOPTP2.classes
{
    abstract class  Pokemon
    {
        protected string nom;
        protected float poids;
        protected float vitesse;
        
        public Pokemon(string nom, float poids)
        {
            this.nom = nom;
            this.poids = poids;
            vitesse = CalcVitesse();
        }

        public string Nom
        {
                       get { return nom; }
        }

        public float Poids
        {
            get { return poids; }
        }

        public float Vitesse
        {
            get { return vitesse; }
        }

        abstract public float CalcVitesse();
        abstract public void Afficher();
    }
}
