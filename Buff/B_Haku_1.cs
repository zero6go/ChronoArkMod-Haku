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
	/// 战术指挥
	/// </summary>
    public class B_Haku_1:Buff
    {
        public override void Init()
        {
            base.Init();
            this.PlusStat.hit = 10;
            this.PlusStat.DeadImmune = 50;
            this.PlusStat.HIT_CC = 30f;
            this.PlusStat.HIT_DOT = 30f;
            this.PlusStat.HIT_DEBUFF = 30f;
        }
    }
}