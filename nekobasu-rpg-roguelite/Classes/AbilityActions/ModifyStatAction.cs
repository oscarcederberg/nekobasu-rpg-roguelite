using System;
using System.Collections.Generic;
using System.Text;

namespace nekobasu_rpg_roguelite.Classes.AbilityActions
{
    public enum StatToModify
    {
        HEALTH,
        MANA,
        MONEY
    }

    public class ModifyStatAction : AbilityAction
    {
        public TargetGroup TargetGroup;
        public int TargetAmount;
        public StatToModify StatToModify;
        public Expression ModifyBy;
        public Expression Chance;

        public ModifyStatAction(TargetGroup targetGroup, int targetAmount,
            StatToModify statToModify, Expression modifyBy, Expression chance)
        {
            this.TargetGroup = targetGroup;
            this.TargetAmount = targetAmount;
            this.StatToModify = statToModify;
            this.ModifyBy = modifyBy;
            this.Chance = chance;
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
