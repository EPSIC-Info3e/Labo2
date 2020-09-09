namespace Epsic.Info3e.Labo2.Step3
{
    public class DocumentNameCreator : DocumentCounter
    {
        private string _prefix;
        
        public DocumentNameCreator(int increment, string prefix) : base(increment)
        {
            _prefix = prefix;
        }

        public override string GetNewDocumentName()
        {
            return _prefix + GetAndIncrement();
        }
    }
}