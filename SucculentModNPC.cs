using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SucculentMod
{
    public class SucculentModNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Bunny)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("RawMeat"));
            }
        }
    }
}
