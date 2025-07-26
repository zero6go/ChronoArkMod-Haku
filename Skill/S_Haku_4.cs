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
	/// 起死回生
	/// </summary>
    public class S_Haku_4:Skill_Extended
    {
        public override void Init()
        {
            base.Init();
        }

        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            if (Targets[0].HP < Targets[0].Recovery)
            {
                int num = Targets[0].Recovery - Targets[0].HP;
                Targets[0].Heal(this.BChar, (float)num, false, false, null);
            }

            base.SkillUseSingle(SkillD, Targets);

            bool flag = false;
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    if (buff.StackNum >= 50) flag = true;
                    break;
                }
            }
            List<Buff> buffs = Targets[0].GetBuffs(BattleChar.GETBUFFTYPE.ALLDEBUFF, true, false);
            if (flag)
            {
                if (buffs.Count != 0)
                {
                    foreach (Buff buff in buffs)
                    {
                        Targets[0].BuffRemove(buff.BuffData.Key);
                    }
                }
            }
        }
    }
}