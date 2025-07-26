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
	/// 扇毒
	/// </summary>
    public class B_Haku_2:Buff
    {
        public override void Init()
        {
            base.Init();
            this.PlusPerStat.Damage = -5 * this.StackNum;
        }
    }
}