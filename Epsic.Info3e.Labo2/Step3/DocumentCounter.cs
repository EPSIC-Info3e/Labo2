namespace Epsic.Info3e.Labo2.Step3
{
    public abstract class DocumentCounter
    {
        private int _count = 0;
        private int _increment;
        
        public DocumentCounter(int increment)
        {
            _increment = increment;
        }

        protected int GetAndIncrement()
        {
            _count += _increment;
            return _count;
        }
        
        public abstract string GetNewDocumentName();
    }
}