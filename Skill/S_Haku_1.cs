using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using GameDataEditor;
using I2.Loc;
using DarkTonic.MasterAudio;
using ChronoArkMod;
using ChronoArkMod.Plugin;
using ChronoArkMod.Template;
using Debug = UnityEngine.Debug;
namespace haku
{
    /// <summary>
    /// 假面之人
    /// </summary>
    public class S_Haku_1:Skill_Extended
    {
        public Item_Consume MaskOfDeception
        {
            get
            {
                if (this._MaskOfDeception == null && PartyInventory.InvenM.ReturnItem("MaskOfDeception") != null)
                {
                    this._MaskOfDeception = (PartyInventory.InvenM.ReturnItem("MaskOfDeception") as Item_Consume);
                }
                return this._MaskOfDeception;
            }
        }
        private Item_Consume _MaskOfDeception;
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            for (int i = 0; i < 10; i++)
            {
                if (MaskOfDeception != null)
                {
                    this.BChar.BuffAdd("B_Haku_0", BChar);
                }
            }
            BattleSystem.instance.AllyTeam.Add(Skill.TempSkill("S_Haku_1_0", this.BChar, this.BChar.MyTeam), true);
            foreach (BattleChar BattleChar in BattleSystem.instance.AllyTeam.GetAliveChars())
            {
                if (BattleChar != this.BChar)
                    BattleChar.BuffAdd("B_Haku_15", this.BChar);
            }
        }
        
        public override bool Terms()
        {
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    return buff.StackNum >= 25;
                }
            }
            return false;
        }
    }
}