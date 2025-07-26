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
	/// 鸣神奔雷
	/// </summary>
    public class S_Haku_2:Skill_Extended
    {
        //private int Damage
        //{
        //    get
        //    {
        //        if (BattleSystem.instance == null)
        //        {
        //            return 0;
        //        }
        //        int num = this.BChar.GetBuffs(BattleChar.GETBUFFTYPE.BUFF, false, false).Count;
        //        return num * (int)(this.BChar.GetStat.atk * 0.1f);
        //    }
        //}

        //public override string DescExtended(string desc)
        //{
        //    return base.DescExtended(desc).Replace("&a", ((int)(this.BChar.GetStat.atk * 0.1f)).ToString());
        //}

        //public override void FixedUpdate()
        //{
        //    base.FixedUpdate();
        //    this.SkillBasePlusPreview.Target_BaseDMG = this.Damage;
        //}

        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
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
    }
}