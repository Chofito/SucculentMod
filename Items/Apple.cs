using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SucculentMod.Items
{
	public class Apple : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Manzana");
            DisplayName.AddTranslation(GameCulture.English, "Apple");
		}

		public override void SetDefaults()
		{
		    item.width = 30;
		    item.height = 31;
		    item.maxStack = 999;
		    item.rare = 0;
		    item.useStyle = 2;
		    item.useAnimation = 20;
		    item.useTime = 20;
		    item.UseSound = SoundID.Item2;
		    item.consumable = true;
		    item.healLife = 1;
		    item.value = Item.sellPrice(0, 0, 0, 5);
		}
	}
}
