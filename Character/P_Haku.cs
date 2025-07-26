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
	/// 哈克
	/// Passive:
	/// </summary>
    public class P_Haku:Passive_Char, IP_SkillUse_Team, IP_LevelUp, IP_BattleStart_Ones, IP_BattleEnd, IP_Dead
    {
        public Item_Consume MaskOfDeception
        {
            get
            {
                if (this._MaskOfDeception == null && PartyInventory.InvenM.ReturnItem("MaskOfDeception") != null)
                {
                    this._MaskOfDeception = (PartyInventory.InvenM.ReturnItem("MaskOfDeception") as Item_Consume);
                }
                return this._MaskOfDeception;
            }
        }
        private Item_Consume _MaskOfDeception;
        private int LV = 1;
        public override void Init()
        {
            base.Init();
            this.OnePassive = true;
        }
        public override void FixedUpdate()
        {
            LV = this.BChar.Info.LV;
        }
        public void SkillUseTeam(Skill skill)
        {
            this.Mask(skill);
        }
        public void Mask(Skill skill)
        {
            if (skill.Master == this.BChar)
            {
                if (MaskOfDeception != null)
                {
                    this.BChar.BuffAdd("B_Haku_0", BChar);
                }
            }
        }
        public void BattleStart(BattleSystem Ins)
        {
            if (MaskOfDeception != null)
            {
                bool flag = false;
                GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
                foreach (Buff buff in this.BChar.Buffs)
                {
                    if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    for (int i = 0; i < MaskOfDeception.StackCount; i++)
                        this.BChar.BuffAdd("B_Haku_0", BChar);
                }
            }
        }
        public void BattleEnd()
        {
            if (MaskOfDeception != null)
            {
                int cnt = -1;
                GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
                foreach (Buff buff in this.BChar.Buffs)
                {
                    if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                    {
                        cnt = buff.StackNum;
                    }
                }
                if (cnt != -1)
                {
                    MaskOfDeception.StackCount = cnt;
                }
            }
        }
        public void Dead()
        {
            if (MaskOfDeception != null)
            {
                int cnt = -1;
                GDEBuffData gDEBuffData = new GDEBuffData("B_Haku_0");
                foreach (Buff buff in this.BChar.Buffs)
                {
                    if (buff.BuffData.Key == gDEBuffData.Key && !buff.DestroyBuff)
                    {
                        cnt = buff.StackNum;
                    }
                }
                if (cnt != -1)
                {
                    MaskOfDeception.StackCount = cnt;
                }
            }
        }
        public void LevelUp()
        {
            LV++;
            if (LV == 2)
                FieldSystem.DelayInput(this.RewardMaskOfDeception());
            if (LV == 3)
                FieldSystem.DelayInput(this.RewardFan());
            if (LV == 6)
                FieldSystem.DelayInput(this.RewardMask());
        }
        public IEnumerator RewardMaskOfDeception()
        {
            InventoryManager.Reward(ItemBase.GetItem("MaskOfDeception"));
            yield return null;
            yield break;
        }
        public IEnumerator RewardFan()
        {
            InventoryManager.Reward(ItemBase.GetItem("IronFan"));
            yield return null;
            yield break;
        }
        public IEnumerator RewardMask()
        {
            InventoryManager.Reward(ItemBase.GetItem("MaskOfTruth"));
            yield return null;
            yield break;
        }
    }
}