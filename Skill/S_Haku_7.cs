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
	/// 鼓舞士气
	/// </summary>
    public class S_Haku_7:Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            GDEBuffData data = new GDEBuffData("B_Haku_13");
            foreach (Buff buff in Targets[0].Buffs)
            {
                if (buff.BuffData.Key == data.Key && !buff.DestroyBuff)
                {
                    return;
                }
            }
            int num = Targets[0].GetBuffs(BattleChar.GETBUFFTYPE.BUFF, false, false).Count;
            if (num > 0)
            {
                BattleSystem.instance.AllyTeam.AP += num;

                GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
                foreach (Buff buff in this.BChar.Buffs)
                {
                    if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                    {
                        if (buff.StackNum >= 100)
                        {
                            this.MySkill.Master.MyTeam.Draw(num);
                            break;
                        }
                    }
                }
            }
        }
    }
}