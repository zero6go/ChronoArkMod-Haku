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
	/// 雷针
	/// </summary>
    public class B_Haku_7:Buff, IP_Hit
    {
        public override void Init()
        {
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
            int num = 0;
            foreach (Buff buff in this.StackInfo[0].UseState.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    num = buff.StackNum;
                    break;
                }
            }
            this.PlusStat.DMGTaken = (float)(0.3f * num);
        }
        public void Hit(SkillParticle SP, int Dmg, bool Cri)
        {
            if (SP.UseStatus.Info.Ally != this.BChar.Info.Ally && Dmg > 0)
            {
                foreach (BattleChar BattleChar in BattleSystem.instance.EnemyTeam.GetAliveChars())
                {
                    if (BattleChar != this.BChar)
                    {
                        GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_7");
                        foreach (Buff buff in BattleChar.Buffs)
                        {
                            if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                            {
                                BattleChar.Damage(SP.UseStatus.Info.GetBattleChar, Dmg / 2, false);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}