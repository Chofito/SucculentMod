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
		    item.maxStack = 50;
		    item.reuseDelay = 5;
		    item.healLife = 100;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
