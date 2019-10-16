using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes
{
    class Entity
    {
        public string Id;
        public string Name;

        public Attribute Level;
        public Attribute Health;
        public Attribute Mana;
        public Attribute Attack;
        public Attribute Sp_Attack;
        public Attribute Defence;
        public Attribute Sp_Defence;
        public Attribute Agility;
        public Attribute Luck;

        public Entity(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
