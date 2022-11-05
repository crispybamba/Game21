using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game21
{
    internal class Card
    {
        public enum Shape
        {
            SPADE,
            DIAMOND,
            HEART,
            CLUB
        }
        private int value;
        private Shape shape;
        public Card(Shape shape, int value)
        {
            this.shape = shape;
            this.value = value;
        }
        public Shape GetShape() { return shape; }
        public int GetValue() { return value; }

        public string GetDesc()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The value: "+ value.ToString());
            sb.Append("\n");
            sb.Append("The Shape is: " + shape.ToString());
            return sb.ToString();
        }//need to check (this is the same as function ToString())...
        //to check picture cards... king..

        public bool IsAce()
        {
            //ace might be 1 and might be 14
            if (value == 1 || value == 11) 
                return true;
            return false;
        }

        public bool IsPictureCard()
        {
            //jack is 11, queen is 12, king is 13
            if (value <= 11 && value >= 13)
                return true;
            return false;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The value: " + value.ToString());
            sb.Append("\n");
            sb.Append("The Shape is: " + shape.ToString());
            return sb.ToString();
        }
    }
}
