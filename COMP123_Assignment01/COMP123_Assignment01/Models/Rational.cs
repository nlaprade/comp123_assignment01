using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment01.Models
{
    public class Rational
    {
        public int denominator;
        public int numerator;

        public int Denominator
        {
            get { return this.denominator; }
            private set { this.denominator = value; }
        }
        public int Numerator
        {
            get { return this.numerator; }
            private set { this.numerator = value; }
        }
        public Rational(int numerator = 0, int denominator = 1)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override string ToString()
        {
            return $"{this.numerator}/{this.denominator}";
        }
        public void IncreaseBy(Rational other)
        {
            if (this.denominator == other.denominator)
            {
                this.numerator += other.numerator;
            }
            else
            {
                numerator = (this.numerator * other.denominator) + (this.denominator * other.numerator);
                denominator = (this.denominator * other.denominator);
            }
        }
        public void DecreaseBy(Rational other)
        {
            if (this.denominator == other.denominator)
            {
                this.numerator -= other.numerator;
            }
            else
            {
                numerator = (this.numerator * other.denominator) - (this.denominator * other.numerator);
                denominator = (this.denominator * other.denominator);
            }
        }
    }
}
