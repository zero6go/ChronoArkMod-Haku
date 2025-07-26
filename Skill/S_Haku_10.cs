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
	/// 根源之力
	/// </summary>
    public class S_Haku_10:Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            base.SkillUseSingle(SkillD, Targets);

            foreach (BattleChar target in Targets)
            {
                if (target.HP < target.Recovery)
                {
                    int num = target.Recovery - target.HP;
                    target.Heal(this.BChar, (float)num, false, false, null);
                }
                List<Buff> buffs = target.GetBuffs(BattleChar.GETBUFFTYPE.ALLDEBUFF, true, false);
                if (buffs.Count != 0)
                {
                    foreach (Buff buff in buffs)
                    {
                        target.BuffRemove(buff.BuffData.Key);
                    }
                }
            }
        }
        public override bool Terms()
        {
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    return buff.StackNum >= 100;
                }
            }
            return false;
        }
    }
}