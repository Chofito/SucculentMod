using Terraria.ID;
using Terraria.ModLoader;

namespace SucculentMod.Items
{
	public class Apple : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manzana");
			Tooltip.SetDefault("Una manzana muy deliciosa.");
		}
		public override void SetDefaults()
		{ 
            item.CloneDefaults(ItemID.CandyApple);
		    item.maxStack = 200;
		    item.healLife = 5;
		}
	}
}
