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
using NLog.Targets;
namespace haku
{
	/// <summary>
	/// 假面之人
	/// </summary>
    public class B_Haku_9:Buff, IP_PlayerTurn, IP_Dead
    {
        public override void Init()
        {
            base.Init();
            this.OnePassive = true;

            this.PlusPerStat.Damage = 30;
            this.PlusPerStat.MaxHP = 100;
            this.PlusStat.def = 30;
        }
        public void Turn()
        {
            BattleSystem.instance.AllyTeam.Add(Skill.TempSkill("S_Haku_1_0", this.BChar, this.BChar.MyTeam), true);
        }
        public void Dead()
        {
            int cnt = 0;
            GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
            foreach (Buff buff in this.BChar.Buffs)
            {
                if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                {
                    cnt = buff.StackNum;
                    break;
                }
            }
            foreach (BattleChar ally in this.BChar.MyTeam.AliveChars)
            {
                if (ally != this.BChar)
                {
                    for (int i = 0; i < cnt; i++)
                    {
                        ally.BuffAdd("B_Haku_14", this.BChar);
                    }
                    List<Buff> buffs = ally.GetBuffs(BattleChar.GETBUFFTYPE.ALLDEBUFF, true, false);
                    if (buffs.Count != 0)
                    {
                        foreach (Buff buff in buffs)
                        {
                            ally.BuffRemove(buff.BuffData.Key);
                        }
                    }
                    ally.Info.HealHP();
                }
            }
        }
    }
}