﻿namespace SpellWork.DBC.Structures
{
    public sealed class SkillLineAbilityEntry
    {
        public int SpellID;
        public uint RaceMask;
        public uint SupercedesSpell;
        public uint Unknown703;
        public ushort SkillLine;
        public ushort MinSkillLineRank;
        public ushort TrivialSkillLineRankHigh;
        public ushort TrivialSkillLineRankLow;
        public ushort UniqueBit;
        public ushort TradeSkillCategoryID;
        public byte AquireMethod;
        public byte NumSkillUps;
        public uint ClassMask;
    }
}
