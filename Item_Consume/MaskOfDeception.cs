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
	/// 虚伪的假面
	/// </summary>
    public class MaskOfDeception:UseitemBase
    {
        private Character Haku;
        public override bool Use(Character CharInfo)
        {
            if (this.MyItem.StackCount > 50 && CharInfo.Incapacitated)
            {
                this.MyItem.StackCount -= 49;
                this.Effect(CharInfo);
                this.PassiveEffect(CharInfo);
                return true;
            }
            return false;
        }
        public override void Effect(Character CharInfo)
        {
            CharInfo.Incapacitated = false;
            if (CharInfo.Hp <= 0)
            {
                CharInfo.Hp = 0;
            }
            CharInfo.HealHP((int)Misc.PerToNum((float)CharInfo.get_stat.maxhp, 50f), true);
        }
    }
}