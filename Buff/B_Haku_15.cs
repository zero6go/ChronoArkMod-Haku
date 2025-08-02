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
	/// 受假面之人的保护
	/// </summary>
    public class B_Haku_15:Buff, IP_TargetedAlly
    {
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (base.Usestate_L != null)
            {
                if (base.Usestate_L.IsDead)
                {
                    base.SelfDestroy(false);
                    return;
                }
            }
        }
        public override string DescExtended()
        {
            return base.DescExtended().Replace("&a", base.Usestate_L.Info.Name);
        }
        public IEnumerator Targeted(BattleChar Attacker, List<BattleChar> SaveTargets, Skill skill)
        {
            for (int j = 0; j < SaveTargets.Count; j++)
            {
                if (SaveTargets[j] == this.BChar)
                {
                    SaveTargets[j] = base.Usestate_L;
                    EffectView.TextOutSimple(this.BChar, this.BuffData.Name);
                    return null;
                }
            }
            return null;
        }
    }
}