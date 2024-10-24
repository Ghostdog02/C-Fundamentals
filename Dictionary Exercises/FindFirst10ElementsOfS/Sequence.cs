namespace FindFirst10ElementsOfS
{
    public class Sequence : List<int>, IComparable<Sequence>
    {
        //private List<int> sequence = new List<int>();
        
        public int CompareTo(Sequence? other)
        {
            if (other == null)
            {
                return -1;
            }

            if (Count != other.Count)
            {
                return other.Count.CompareTo(Count);
            }

            // Handle equal count lists
            for (int i = 0; i < Count; i++)
            {
                var compareResult = other[i].CompareTo(this[i]);
                if (compareResult != 0)
                {
                    return compareResult;
                }
            }

            // The sequences are equal
            return 0;
        }
    }
}
