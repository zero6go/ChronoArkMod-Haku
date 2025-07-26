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
	/// 二人的白皇
	/// </summary>
    public class B_Haku_5:Buff, IP_PlayerTurn
    {
        public override void Init()
        {
            base.Init();
            this.PlusPerStat.Damage = 20;
            this.PlusPerStat.Heal = 20;
            this.PlusStat.def = 10;
            this.PlusStat.RES_CC = 25;
            this.PlusStat.RES_DOT = 25;
            this.PlusStat.RES_DEBUFF = 25;
        }

        public void Turn()
        {
            BattleSystem.instance.AllyTeam.Add(Skill.TempSkill("S_Haku_10", this.BChar, this.BChar.MyTeam), true);
        }
    }
}