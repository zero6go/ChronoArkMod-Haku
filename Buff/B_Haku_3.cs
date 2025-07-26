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
	/// 疾风迅雷
	/// </summary>
    public class B_Haku_3:Buff
    {
        public override void Init()
        {
            base.Init();
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
            this.PlusStat.dod = (int)(0.5f * num);
        }
    }
}