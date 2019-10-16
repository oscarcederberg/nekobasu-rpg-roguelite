using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes
{
    class Entity
    {
        public string Id;
        public string Name;
        public Type Type;

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
    }
}
