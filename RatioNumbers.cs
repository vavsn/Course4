using System;
using System.Collections.Generic;
using System.Text;

namespace RationalNumber
{
    class RatioNumbers
    {
        /// <summary>
        /// числитель
        /// </summary>
        private int _numerator;
        /// <summary>
        /// знаменатель
        /// </summary>
        private int _denominator;
        public float Value
        {
            get { return (float)_numerator / (float)_denominator; }
        }

        public RatioNumbers(int num, int den)
        {
            _numerator = num;
            if (den == 0) 
            {
                throw new Exception("Знаменатель не может быть равен 0");
            }
            _denominator = den;
        }
        public static bool operator ==(RatioNumbers r1, RatioNumbers r2)
        {
            return (r1._numerator == r2._numerator & r1._denominator == r2._denominator);
        }

        public static bool operator !=(RatioNumbers r1, RatioNumbers r2)
        {
            return (r1._numerator != r2._numerator | r1._denominator != r2._denominator);
        }

        public static bool operator <(RatioNumbers r1, RatioNumbers r2)
        {
            return (r1.Value < r2.Value);
        }

        public static bool operator >(RatioNumbers r1, RatioNumbers r2)
        {
            return (r1.Value > r2.Value);
        }

        public static bool operator <=(RatioNumbers r1, RatioNumbers r2)
        {
            return (r1.Value <= r2.Value);
        }

        public static bool operator >=(RatioNumbers r1, RatioNumbers r2)
        {
            return (r1.Value >= r2.Value);
        }
        public static RatioNumbers operator +(RatioNumbers r1, RatioNumbers r2)
        {
            int com_denom = r1._denominator * r2._denominator;
            return new RatioNumbers(r1._numerator * r2._denominator + r2._numerator * r1._denominator, com_denom);
        }
        public static RatioNumbers operator -(RatioNumbers r1, RatioNumbers r2)
        {
            int com_denom = r1._denominator * r2._denominator;
            return new RatioNumbers(r1._numerator * r2._denominator - r2._numerator * r1._denominator, com_denom);
        }
        public static RatioNumbers operator *(RatioNumbers r1, RatioNumbers r2)
        {
            return new RatioNumbers(r1._numerator * r2._numerator, r1._denominator * r2._denominator);
        }
        public static RatioNumbers operator /(RatioNumbers r1, RatioNumbers r2)
        {
            return new RatioNumbers(r1._numerator * r2._denominator, r1._denominator * r2._numerator);
        }
        public static RatioNumbers operator %(RatioNumbers r1, RatioNumbers r2)
        {
            RatioNumbers r_loc = new RatioNumbers(r1._numerator * r2._denominator, r1._denominator * r2._numerator);
            if ((int)r_loc._numerator <= (int)r_loc._denominator)
            {
                return r_loc;
            }
            int i = (int)r_loc._numerator / (int)r_loc._denominator;
            return new RatioNumbers(r_loc._numerator - i * r_loc._denominator, r_loc._denominator);
        }
        public static RatioNumbers operator -(RatioNumbers r)
        {
            return new RatioNumbers (-r._numerator, -r._denominator);
        }
        public static RatioNumbers operator ++(RatioNumbers r)
        {
            r._numerator++;
            r._denominator++;
            return (r);
        }
        public static RatioNumbers operator --(RatioNumbers r)
        {
            r._numerator--;
            r._denominator--;
            return (r);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            RatioNumbers ratnum = (RatioNumbers)obj;
            return (this._numerator == ratnum._numerator & 
                this._denominator == ratnum._denominator);
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        public static explicit operator RatioNumbers(float f)
        {
            Char separator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            string sf = f.ToString();
            int l = sf.Substring(sf.IndexOf(separator) + 1).Length;
            int x = 10;
            for(int i=1; i < l; i++)
            {
                x = x * 10;
            }
            return new RatioNumbers((int)(f * x), x);
        }

        public static explicit operator RatioNumbers(int i)
        {
            return new RatioNumbers(i, 1);
        }


        public static explicit operator float(RatioNumbers r)
        {
            return (float)r.Value;
        }

        public static explicit operator int(RatioNumbers r)
        {
            return r._numerator / r._denominator;
        }
    }
}
