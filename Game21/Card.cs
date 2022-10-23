using System;
using System.Collections.Generic;
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

        public string GetDesc() { return "...."; }//(Description)
    }
}
