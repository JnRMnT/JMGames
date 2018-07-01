
using System;

namespace JMGames.Common.Entities
{
    [Flags]
    public enum NPCTradingTypeEnum
    {
        None = (1 << 0),
        Accessories = (1 << 1),
        Potions = (1 << 2),
        Armor = (1 << 3),
        Weapons = (1 << 4)
    }
}
