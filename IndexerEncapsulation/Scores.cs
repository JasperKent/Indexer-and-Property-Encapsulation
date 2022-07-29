namespace IndexerEncapsulation
{
    public class Scores
    {
        private readonly int _minScore;
        private readonly int _maxScore;

        private int[] _scores;

        public Scores(int count, int minScore, int maxScore)
        {
            _scores = new int[count];
            _minScore = minScore;
            _maxScore = maxScore;
        }

        public int MaxScore => _scores.Max();

        public int this[int idx]
        {
            get
            {
                if (idx < 0 || idx >= _scores.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return _scores[idx];
            }

            set
            {
                if (idx < 0 || idx >= _scores.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                if (value < _minScore || value > _maxScore)
                    throw new ArgumentOutOfRangeException(nameof(value),"Score is out of range");

                _scores[idx] = value;
            }
        }
    }
}
