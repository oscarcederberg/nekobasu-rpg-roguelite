using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes
{
    class Attribute
    {
        private int min = 0;
        private int max = 14;
        private int _value;

        public int Value { get { return _value; } set { _value = Math.Min(max, Math.Max(min, value)); } }

        public Attribute(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            switch (this.Value)
            {
                default:
                    return this.Value.ToString();
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                case 14:
                    return "Ace";
            }
        }
    }
}
