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
    public class B_Haku_10:Buff, IP_SkillUse_User
    {
        public override void Init()
        {
            this.PlusStat.cri = 15;
            this.PlusStat.PlusCriDmg = 30;
            this.PlusStat.PlusCriHeal = 30;
        }
        public void SkillUse(Skill SkillD, List<BattleChar> Targets)
        {
            BattleChar Haku = null;
            foreach (BattleChar BattleChar in BattleSystem.instance.AllyTeam.GetAliveChars())
            {
                if (BattleChar.Info.KeyData == "Haku")
                {
                    Haku = BattleChar;
                    break;
                }
            }
            if (Haku && Haku != this.BChar)
            {
                BattleSystem.DelayInputAfter(this.Effect(Haku));
            }
        }
        public IEnumerator Effect(BattleChar Haku)
        {
            yield return new WaitForSeconds(0.1f);
            Skill skill = Skill.TempSkill("S_Haku_3", Haku, Haku.MyTeam);
            Skill_Extended extended = new Skill_Extended();
            skill.ExtendedAdd(extended);
            skill.isExcept = true;
            skill.FreeUse = true;
            skill.PlusHit = true;
            Haku.ParticleOut(skill, this.BChar.BattleInfo.EnemyList.Random(this.BChar.GetRandomClass().Main));
            yield break;
        }
    }
}