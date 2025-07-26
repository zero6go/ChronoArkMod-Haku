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
	/// 攻刃之型
	/// 每次释放哈克拥有的技能时，此技能的费用减少1点。
	/// </summary>
    public class S_Haku_6:Skill_Extended, IP_SkillUse_Team
    {
        public override void Init()
        {
            base.Init();
            this.UseNum = 0;
        }

        public override void FixedUpdate()
        {
            this.APChange = -this.UseNum;
        }

        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            this.UseNum = 0;
            BattleSystem.instance.AllyTeam.Add(Skill.TempSkill("S_Haku_6_0", this.BChar, this.BChar.MyTeam), true);

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
        }

        public void SkillUseTeam(Skill skill)
        {
            if (skill.Master == this.BChar)
            {
                this.UseNum++;
            }
        }

        public int UseNum;
    }
}