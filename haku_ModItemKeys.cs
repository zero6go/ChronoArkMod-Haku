using ChronoArkMod;
namespace haku
{
    public static class ModItemKeys
    {
		/// <summary>
		/// 虚伪的假面
		/// 与假面的融合度，每层会使哈克在回合开始时受到最大生命值0.3%的伤害，如果哈克装备了某个特殊装备则不会受到此负面效果。
		/// </summary>
        public static string Buff_B_Haku_0 = "B_Haku_0";
		/// <summary>
		/// 战术指挥
		/// </summary>
        public static string Buff_B_Haku_1 = "B_Haku_1";
		/// <summary>
		/// 根源之力
		/// 使用技能后哈克将会对所有敌人使用扇子进行一次追加攻击。(仅队友生效)
		/// </summary>
        public static string Buff_B_Haku_10 = "B_Haku_10";
		/// <summary>
		/// 吾乃鸣神
		/// 哈克的专属攻击技能将会给目标施加雷针效果。（多次释放的技能仅有第一次会施加雷针）
		/// </summary>
        public static string Buff_B_Haku_11 = "B_Haku_11";
		/// <summary>
		/// 攻刃之型
		/// 受到攻击时将对敌人释放白燕乱舞。
		/// </summary>
        public static string Buff_B_Haku_12 = "B_Haku_12";
		/// <summary>
		/// 鼓舞士气
		/// 对此角色使用鼓舞士气将不会产生任何效果。
		/// </summary>
        public static string Buff_B_Haku_13 = "B_Haku_13";
		/// <summary>
		/// 传颂的轮回
		/// </summary>
        public static string Buff_B_Haku_14 = "B_Haku_14";
		/// <summary>
		/// 扇毒
		/// </summary>
        public static string Buff_B_Haku_2 = "B_Haku_2";
		/// <summary>
		/// 疾风迅雷
		/// 根据假面融合度获得闪避率。
		/// </summary>
        public static string Buff_B_Haku_3 = "B_Haku_3";
		/// <summary>
		/// 一刀两断
		/// </summary>
        public static string Buff_B_Haku_4 = "B_Haku_4";
		/// <summary>
		/// 二人的白皇
		/// 每回合获得一张根源之力。哈克的专属攻击技能将会清除目标的随机一个增益效果。
		/// </summary>
        public static string Buff_B_Haku_5 = "B_Haku_5";
		/// <summary>
		/// 传颂之物
		/// 回合开始时使手中的所有技能费用减少1点。
		/// </summary>
        public static string Buff_B_Haku_6 = "B_Haku_6";
		/// <summary>
		/// 雷针
		/// 受到伤害时额外受到基于假面融合度的伤害，同时对其他拥有雷针效果的敌人造成50%伤害。
		/// </summary>
        public static string Buff_B_Haku_7 = "B_Haku_7";
		/// <summary>
		/// 白皇光环
		/// </summary>
        public static string Buff_B_Haku_8 = "B_Haku_8";
		/// <summary>
		/// 假面之人
		/// 每回合获得一张天地豪掌。死亡时使其他队友完全恢复体力并清除所有减益，根据假面融合度获得属性加成。
		/// </summary>
        public static string Buff_B_Haku_9 = "B_Haku_9";
		/// <summary>
		/// 哈克
		/// Passive:
		/// 获得挚友托付的假面。
		/// 每使用一次哈克的技能，会使其与假面的融合度加深，根据假面的融合度获得属性和技能增强效果，但同时每回合也会受到基于最大生命值百分比的痛苦伤害。
		/// </summary>
        public static string Character_Haku = "Haku";
		/// <summary>
		/// 历战铁扇
		/// 一把带有毒刃的铁扇。
		/// </summary>
        public static string Item_Equip_IronFan = "IronFan";
		/// <summary>
		/// 虚伪的假面
		/// 与假面的融合度，战斗开始时哈克会获得对应层数的被动。使用时消耗50层解除友军无法战斗状态并恢复50%最大生命值。(大于50层才能使用)
		/// </summary>
        public static string Item_Consume_MaskOfDeception = "MaskOfDeception";
		/// <summary>
		/// 白皇的假面
		/// 天命桎梏
		/// </summary>
        public static string Item_Equip_MaskOfTruth = "MaskOfTruth";
        public static string SkillEffect_SE_S_S_Haku_1 = "SE_S_S_Haku_1";
        public static string SkillEffect_SE_S_S_Haku_2 = "SE_S_S_Haku_2";
        public static string SkillEffect_SE_S_S_Haku_6 = "SE_S_S_Haku_6";
        public static string SkillEffect_SE_S_S_Haku_8 = "SE_S_S_Haku_8";
        public static string SkillEffect_SE_S_S_Haku_9 = "SE_S_S_Haku_9";
        public static string SkillEffect_SE_Tick_B_Haku_2 = "SE_Tick_B_Haku_2";
        public static string SkillEffect_SE_T_S_Haku_0 = "SE_T_S_Haku_0";
        public static string SkillEffect_SE_T_S_Haku_10 = "SE_T_S_Haku_10";
        public static string SkillEffect_SE_T_S_Haku_1_0 = "SE_T_S_Haku_1_0";
        public static string SkillEffect_SE_T_S_Haku_2 = "SE_T_S_Haku_2";
        public static string SkillEffect_SE_T_S_Haku_3 = "SE_T_S_Haku_3";
        public static string SkillEffect_SE_T_S_Haku_4 = "SE_T_S_Haku_4";
        public static string SkillEffect_SE_T_S_Haku_5 = "SE_T_S_Haku_5";
        public static string SkillEffect_SE_T_S_Haku_6 = "SE_T_S_Haku_6";
        public static string SkillEffect_SE_T_S_Haku_6_0 = "SE_T_S_Haku_6_0";
        public static string SkillEffect_SE_T_S_Haku_7 = "SE_T_S_Haku_7";
        public static string SkillEffect_SE_T_S_Haku_8 = "SE_T_S_Haku_8";
		/// <summary>
		/// 战术指挥
		/// 使所有手牌费用减少一点，如果哈克装备了某件特殊装备且与假面完全融合，则再减少一点。
		/// </summary>
        public static string Skill_S_Haku_0 = "S_Haku_0";
		/// <summary>
		/// 假面之人
		/// 与假面的融合度超过25%时才能使用。
		/// 与假面的融合度增加10%，变身成假面之人的真实形态，保护所有队友，变身期间每回合获得强力群体攻击技能。
		/// </summary>
        public static string Skill_S_Haku_1 = "S_Haku_1";
		/// <summary>
		/// 根源之力
		/// 与假面完全融合后才能使用。
		/// 使全体友方单位恢复体力极限并解除所有负面状态。
		/// </summary>
        public static string Skill_S_Haku_10 = "S_Haku_10";
		/// <summary>
		/// 天地豪掌
		/// 对自身造成<color=purple>最大生命值20%的痛苦伤害</color>，自身每有1种增益，额外对敌人造成&a点伤害（基于攻击力）。如果哈克装备了某个特殊装备则不会对自身造成伤害。
		/// </summary>
        public static string Skill_S_Haku_1_0 = "S_Haku_1_0";
		/// <summary>
		/// 鸣神奔雷
		/// </summary>
        public static string Skill_S_Haku_2 = "S_Haku_2";
		/// <summary>
		/// 斗扇烈斩
		/// 如果哈克装备了某个特殊装备追加释放一次该技能，如果与假面完全融合则再追加释放一次。
		/// </summary>
        public static string Skill_S_Haku_3 = "S_Haku_3";
		/// <summary>
		/// 起死回生
		/// 恢复目标的体力极限，如果与假面融合度超过50%，则解除目标所有减益。
		/// </summary>
        public static string Skill_S_Haku_4 = "S_Haku_4";
		/// <summary>
		/// 疾风迅雷
		/// 抽取一个技能，如果与假面融合度超过50%，则再抽取一个技能。
		/// </summary>
        public static string Skill_S_Haku_5 = "S_Haku_5";
		/// <summary>
		/// 攻刃之型
		/// 	
		/// 每次释放哈克拥有的技能时，此技能的费用减少1点。释放后获得一张白燕乱舞。
		/// </summary>
        public static string Skill_S_Haku_6 = "S_Haku_6";
		/// <summary>
		/// 白燕乱舞
		/// 指定敌人每有一种减益或一层<sprite=1>减益层数，对随机敌人追加释放一次该技能。
		/// </summary>
        public static string Skill_S_Haku_6_0 = "S_Haku_6_0";
		/// <summary>
		/// 鼓舞士气
		/// 指定单位每有一种增益，恢复1点法力值，与假面完全融合时，每有一种增益便抽一张技能。
		/// </summary>
        public static string Skill_S_Haku_7 = "S_Haku_7";
		/// <summary>
		/// 神话的开端
		/// 与假面完全融合后才能使用。
		/// 使全体队友受到白皇神力沐浴，获得巨幅属性增益。每回合获得一张根源之力。
		/// </summary>
        public static string Skill_S_Haku_8 = "S_Haku_8";
		/// <summary>
		/// 传颂之物
		/// 与假面的融合度增加20%，并抽取2个技能。如果使用前已与假面完全融合，则恢复3点法力值
		/// </summary>
        public static string Skill_S_Haku_9 = "S_Haku_9";
		/// <summary>
		/// 受假面之人的保护
		/// 由&a代替承受攻击。
		/// </summary>
        public static string Buff_B_Haku_15 = "B_Haku_15";

    }

    public static class ModLocalization
    {

    }
}