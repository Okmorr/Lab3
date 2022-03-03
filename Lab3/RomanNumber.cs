namespace Lab2
{
    public class RomanNumber : ICloneable, IComparable
    {
        private ushort numm = 0;

        public RomanNumber(ushort n)
        {
            numm = n;
        }
        public static RomanNumber operator +(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null)
                return new RomanNumber((ushort)(n1.numm + n2.numm));
            else
                throw new RomanNumberException("Error: ошибка сложения");
        }
        public static RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n1.numm > n2.numm)
                return new RomanNumber((ushort)(n1.numm - n2.numm));
            else
                throw new RomanNumberException("Error: ошибка вычитания");
        }
        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n1.numm * n2.numm <= 99999)
                return new RomanNumber((ushort)(n1.numm * n2.numm));
            else
                throw new RomanNumberException("Error: ошибка умножения");
        }
        public static RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)
        {
            if (n1 != null && n2 != null && n2.numm != 0 && n1.numm % n2.numm == 0)
                return new RomanNumber((ushort)(n1.numm / n2.numm));
            else
                throw new RomanNumberException("Error: ошибка деления");
        }


        public override string ToString()
        {
            string str = "";
            ushort num = numm;
            ushort[] arr1 = new ushort[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] arr2 = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

            for (int i = 12; i >= 0; --i)
            {
                if (num / arr1[i] != 0)
                {
                    for (int j = 0; j < num / arr1[i]; ++j)
                        str += arr2[i];
                    num %= arr1[i];
                }
            }
            return str;
        }


        public object Clone()
        {
            return new RomanNumber(numm);
        }
        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber rNumber)
                return numm.CompareTo(rNumber.numm);
            else
                throw new RomanNumberException("Error: ошибка сравнения ");
        }
    }
}