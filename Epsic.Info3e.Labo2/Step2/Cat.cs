namespace Epsic.Info3e.Labo2.Step2
{
    public class Cat : Animal
    {
        public Cat(string name_) : base(name_) 
        {

        }

        public override string Eat() => "Je mange des croquettes.";
    }
}