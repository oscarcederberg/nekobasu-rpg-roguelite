using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes
{
    class Entity
    {
        public string Id;
        public string Name;
        public string Nickname;
        public Type Type;
        public List<String> Tags;

        public Attribute Level;
        public Attribute Health;
        public Attribute Mana;
        public Attribute Attack;
        public Attribute Sp_Attack;
        public Attribute Defence;
        public Attribute Sp_Defence;
        public Attribute Agility;
        public Attribute Luck;

        public Entity(string id, string name, string typeid)
        {
            this.Id = id;
            this.Name = name;
            this.Nickname = name;
            Type type;
            if (Program.types.TryGetValue(typeid, out type))
            {
                this.Type = type;
            }
            else
            {
                throw new ArgumentException($"Id doesn't exist", typeid);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null | !(obj.GetType() == typeof(Type)))
            {
                return false;
            }
            else
            {
                Entity e = (Entity)obj;
                return this.Id.Equals(e.Id);
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
