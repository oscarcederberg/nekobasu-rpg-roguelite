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

        public override string ToString()
        {
            return this.Name;
        }
    }
}
