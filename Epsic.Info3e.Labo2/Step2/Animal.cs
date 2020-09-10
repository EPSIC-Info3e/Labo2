namespace Epsic.Info3e.Labo2.Step2
{
    public abstract class Animal
    {
        protected string Name;

        public Animal(string name_) => Name = name_;

        public abstract string Eat();

        public virtual string GetName() => Name;
    }
}