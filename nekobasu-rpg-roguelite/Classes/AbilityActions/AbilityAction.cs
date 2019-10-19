using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes.AbilityActions
{
    public enum TargetGroup
    {
        NONE,
        SELF,
        ALLY,
        ENEMY,
        OTHER,
        ANY,
        RANDOM_ALLY,
        RANDOM_ENEMY,
        RANDOM_OTHER,
        RANDOM_ANY,
        ALL
    }

    // All AbilityActions derive from this class.
    public abstract class AbilityAction
    {
        public abstract void Execute();
    }
}
