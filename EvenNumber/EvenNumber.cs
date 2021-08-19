using System;
namespace EvenNumber
{
    public class EvenNumber
    {
        private int evenNo;

        public EvenNumber()
        {
            evenNo = 0;
        }

        private bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool SetEvenNumber(int n)
        {
            if (IsEven(n))
            {
                evenNo = n;
                return true;
            }
            return false;
        }

        public int GetValue()
        {
            return evenNo;
        }
    }
}
