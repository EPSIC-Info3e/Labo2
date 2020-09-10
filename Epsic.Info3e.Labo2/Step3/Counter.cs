namespace Epsic.Info3e.Labo2.Step3
{
    public class Counter
    {
        private int _count = 0;
        private int _increment;
        
        public Counter(int increment)
        {
            _increment = increment;
        }

        public int GetAndIncrement()
        {
            _count += _increment;
            return _count;
        }
    }
}