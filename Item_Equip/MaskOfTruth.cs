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
	/// 白皇的假面
	/// 天命桎梏
	/// </summary>
    public class MaskOfTruth:EquipBase, IP_BattleStart_Ones
    {
        public void BattleStart(BattleSystem Ins)
        {
            BattleSystem.instance.AllyTeam.Add(Skill.TempSkill("S_Haku_8", this.BChar, this.BChar.MyTeam), true);
        }

        public override void Init()
        {
            base.Init();
            this.PlusStat.def = 10f;
            this.PlusPerStat.MaxHP = 20;
        }
    }
}