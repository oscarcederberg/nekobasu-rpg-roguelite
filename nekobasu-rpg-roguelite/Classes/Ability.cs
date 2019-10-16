using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes
{
    class Ability
    {
        public string Id;
        public string Name;
        public Type Type;
        public Attribute Strength;

        public Ability(string id, string name, string typeid, int strength)
        {
            this.Id = id;
            this.Name = name;
            Type type;
            if (Program.types.TryGetValue(typeid, out type))
            {
                this.Type = type;
            }
            else
            {
                throw new ArgumentException($"Id doesn't exist", typeid);
            }
            this.Strength = new Attribute(strength);
        }
    }
}
