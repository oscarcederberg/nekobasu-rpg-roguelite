using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes
{
    class Type
    {
        public string Id;
        public string Name;
        public Dictionary<string, float> Matchups;

        public Type(string id, string name, Dictionary<string, float> matchups)
        {
            this.Id = id;
            this.Name = name;
            this.Matchups = matchups;
        }

        public override bool Equals(object obj)
        {
            if(obj == null | !(obj.GetType() == typeof(Type)))
            {
                return false;
            }
            else
            {
                Type t = (Type)obj;
                return this.Id.Equals(t.Id);
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
