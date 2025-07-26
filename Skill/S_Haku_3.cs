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
	/// 斗扇烈斩
	/// </summary>
    public class S_Haku_3:Skill_Extended
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

            bool flag = false;
            foreach (ItemBase item in this.BChar.Info.Equip)
            {
                if (item != null && item.itemkey == "IronFan")
                {
                    flag = true;
                    break;
                }
            }
            if (!flag) return;
            int num = this.BChar.GetBuffs(BattleChar.GETBUFFTYPE.BUFF, false, false).Count;
            if (num > 3) num = 3;
            for (int i = 0; i < num; i++)
            {
                BattleSystem.DelayInputAfter(this.Effect());
            }
        }
        public IEnumerator Effect()
        {
            yield return new WaitForSeconds(0.1f);
            Skill skill = Skill.TempSkill("S_Haku_3", this.BChar, this.BChar.MyTeam);
            Skill_Extended extended = new Skill_Extended();
            skill.ExtendedAdd(extended);
            skill.isExcept = true;
            skill.FreeUse = true;
            skill.PlusHit = true;
            this.BChar.ParticleOut(this.MySkill, skill, this.BChar.BattleInfo.EnemyList.Random(this.BChar.GetRandomClass().Main));
            yield break;
        }
    }
}