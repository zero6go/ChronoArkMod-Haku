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
	/// 战术指挥
	/// </summary>
    public class S_Haku_0:Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            bool flag = false;
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    if (buff.StackNum >= 100) flag = true;
                    break;
                }
            }

            bool flag2 = false;
            foreach (ItemBase item in this.BChar.Info.Equip)
            {
                if (item != null && item.itemkey == "MaskOfTruth")
                {
                    flag2 = true;
                    break;
                }
            }

            foreach (Skill skill in BattleSystem.instance.AllyTeam.Skills)
            {
                if (skill != this.MySkill)
                {
                    skill.APChange -= 1;
                    if (flag && flag2) skill.APChange -= 1;
                }
            }
        }
    }
}