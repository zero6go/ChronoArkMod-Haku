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
	/// 铁扇
	/// 一把带有毒刃的铁扇。
	/// </summary>
    public class IronFan:EquipBase
    {
        public override void Init()
        {
            base.Init();
            this.PlusStat.atk = 3;
            this.PlusStat.cri = 10;
        }
    }
}