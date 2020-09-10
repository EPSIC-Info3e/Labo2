namespace Epsic.Info3e.Labo2.Step3
{
    public class DocumentNameCreator
    {
        private string _prefix;
        private Counter _counter;

        public DocumentNameCreator(Counter counter, string prefix)
        {
            _prefix = prefix;
            _counter = counter;
        }

        public string GetNewDocumentName()
        {
            return _prefix + _counter.GetAndIncrement();
        }
    }
}