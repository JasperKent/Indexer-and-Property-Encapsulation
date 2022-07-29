namespace IndexerEncapsulation
{
    public class Panel
    {
        private readonly int _minScore;
        private readonly int _maxScore;

        private Panelist[] _members;

        public Panel(int count, int minScore, int maxScore)
        {
            _minScore = minScore;
            _maxScore = maxScore;
            _members = new Panelist[count];
        }

        public int MaxScore => _members.Max(m => m.Score);

        public Panelist this[int idx]
        {
            get
            {
                if (idx < 0 || idx >= _members.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return _members[idx];
            }

            set
            {
                if (idx < 0 || idx >= _members.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                if (value.Score < _minScore || value.Score > _maxScore)
                    throw new ArgumentOutOfRangeException(nameof(value.Score), "Score is out of range");

                _members[idx] = value;
            }

        }
    }
}
