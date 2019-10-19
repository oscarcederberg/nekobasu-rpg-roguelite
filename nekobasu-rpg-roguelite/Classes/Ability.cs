using System;
using System.Collections.Generic;
using System.Text;

using nekobasu_rpg_roguelite.Classes.AbilityActions;


namespace nekobasu_rpg_roguelite.Classes
{
    class Ability
    {
        public string Id;
        public string Name;
        public Type Type;
        public Attribute Strength;
        public List<AbilityAction> AbilityActions;

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
                throw new ArgumentException("Null or non-existent type id", typeid);
            }
            this.Strength = new Attribute(strength);
        }

        public override bool Equals(object obj)
        {
            if(obj == null | !(obj.GetType() == typeof(Ability)))
            {
                return false;
            }
            else
            {
                Ability a = (Ability)obj;
                return this.Id.Equals(a.Id);
            }
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
