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
	/// 传颂之物
	/// </summary>
    public class B_Haku_6:Buff, IP_PlayerTurn
    {
        public void Turn()
        {
            foreach (Skill skill in BattleSystem.instance.AllyTeam.Skills)
            {
                skill.APChange -= 1;
            }
        }
    }
}