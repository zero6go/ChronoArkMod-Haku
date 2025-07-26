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
using DG.Tweening.Core.Easing;
namespace haku
{
	/// <summary>
	/// 天地豪掌
	/// </summary>
    public class S_Haku_1_0:Skill_Extended
    {
        private int Damage
        {
            get
            {
                if (BattleSystem.instance == null)
                {
                    return 0;
                }
                return 0 + this.BChar.GetBuffs(BattleChar.GETBUFFTYPE.BUFF, false, false).Count * (int)(this.BChar.GetStat.atk * 0.3f);
            }
        }
        public override string DescExtended(string desc)
        {
            return base.DescExtended(desc).Replace("&a", ((int)(this.BChar.GetStat.atk * 0.3f)).ToString());
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
            this.SkillBasePlusPreview.Target_BaseDMG = this.Damage;
        }

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
            bool flag = true;
            foreach (ItemBase item in this.BChar.Info.Equip)
            {
                if (item != null && item.itemkey == "MaskOfTruth")
                {
                    flag = false;
                    break;
                }
            }
            if (flag) 
                this.BChar.Damage(this.BChar, (int)Misc.PerToNum((float)this.BChar.GetStat.maxhp, 30f), false, true, true, 0, false, false, false);
            base.SkillUseSingle(SkillD, Targets);
            this.SkillBasePlus.Target_BaseDMG = this.Damage;
        }
    }
}