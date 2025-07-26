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
	/// 疾风迅雷
	/// </summary>
    public class S_Haku_5:Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            this.MySkill.Master.MyTeam.Draw(1);
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    if (buff.StackNum >= 50)
                    {
                        this.MySkill.Master.MyTeam.Draw(1);
                        break;
                    }
                }
            }
        }
    }
}