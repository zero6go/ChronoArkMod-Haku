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
    /// 受赞颂者
    /// </summary>
    public class B_Haku_0 : Buff, IP_PlayerTurn
    {
        float Percent = 0.5f;
        public override void Init()
        {
            base.Init();
            this.PlusPerStat.Damage = (int)(0.5 * this.StackNum);
            this.PlusPerStat.Heal = (int)(0.5 * this.StackNum);
            this.PlusStat.def = (int)(0.2 * this.StackNum);
        }
        public override string DescExtended(string desc)
        {
            return base.DescExtended(desc).Replace("&a", ((int)(Percent)).ToString());
        }
        public void Turn()
        {
            bool flag = false;
            foreach (ItemBase item in this.BChar.Info.Equip)
            {
                if (item != null && item.itemkey == "MaskOfTruth")
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
                this.BChar.Damage(this.BChar, (int)Misc.PerToNum((float)this.BChar.GetStat.maxhp, this.StackNum * Percent), false, true, true, 0, false, false, false);
        }
    }
}