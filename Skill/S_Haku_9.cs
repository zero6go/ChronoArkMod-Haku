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
	/// 传颂之物
	/// </summary>
    public class S_Haku_9:Skill_Extended
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
            GDEBuffData data = new GDEBuffData("B_Haku_0");
            foreach (Buff buff in Targets[0].Buffs)
            {
                if (buff.BuffData.Key == data.Key && !buff.DestroyBuff)
                {
                    if (buff.StackNum >= 100)
                    {
                        BattleSystem.instance.AllyTeam.AP += 3;
                    }
                    break;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (MaskOfDeception != null)
                {
                    this.BChar.BuffAdd("B_Haku_0", BChar);
                }
            }
            this.MySkill.Master.MyTeam.Draw(2);
        }
    }
}