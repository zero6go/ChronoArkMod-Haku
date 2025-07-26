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
    /// 神话的开端
    /// </summary>
    public class S_Haku_8:Skill_Extended
    {

        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_11");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    foreach (BattleChar target in Targets)
                    {
                        target.BuffAdd("B_Haku_7", this.BChar);
                    }
                    break;
                }
            }
            GDEBuffData gDEBuffData2 = new GDEBuffData("B_Haku_5");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData2.Key && !buff.DestroyBuff)
                {
                    foreach (BattleChar target in Targets)
                    {
                        List<Buff> buffs = target.GetBuffs(BattleChar.GETBUFFTYPE.BUFF, true, false);
                        if (buffs.Count >= 1)
                        {
                            buffs.Random(this.BChar.GetRandomClass().Main).SelfDestroy(false);
                        }
                    }
                    break;
                }
            }
            BattleSystem.instance.AllyTeam.Add(Skill.TempSkill("S_Haku_10", this.BChar, this.BChar.MyTeam), true);
            foreach (BattleChar BattleChar in BattleSystem.instance.AllyTeam.GetAliveChars())
            {
                if (BattleChar != this.BChar)
                    BattleChar.BuffAdd("B_Haku_8", this.BChar);
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