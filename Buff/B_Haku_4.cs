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
	/// 一刀两断
	/// </summary>
    public class B_Haku_4:Buff
    {
        public override void Init()
        {
            this.PlusStat.def = -15f;
            this.PlusStat.RES_CC = -30;
            this.PlusStat.RES_DOT = -30;
            this.PlusStat.RES_DEBUFF = -30;
        }
    }
}