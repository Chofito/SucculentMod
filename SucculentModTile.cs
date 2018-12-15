using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SucculentMod
{
    public class SucculentModTile : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if (type == TileID.Trees)
            {
                Item.NewItem(i * 16, (j - 5) * 16, 32, 32, mod.ItemType("Apple"), Main.rand.Next(1, 3));
            }

            return base.Drop(i, j, type);
        }
    }
}
