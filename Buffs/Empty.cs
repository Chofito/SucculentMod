using Terraria;
using Terraria.ModLoader;

namespace SucculentMod.Buffs
{
    public class Empty : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Empty");
            Description.SetDefault("You need a snack :s");
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = false;
        }
    }
}
