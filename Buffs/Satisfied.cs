using Terraria;
using Terraria.ModLoader;

namespace SucculentMod.Buffs
{
    public class Satisfied : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Satisfied");
            Description.SetDefault("Nothing better than food :)");
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = false;
        }
    }
}
