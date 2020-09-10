namespace Epsic.Info3e.Labo2.Step2
{
    public class Cow : Animal
    {
        public Cow(string name_) : base(name_)
        {

        }

        public override string Eat() => "Je mange du foin.";

        public new string GetName() => $"Holy {Name}";
    }
}