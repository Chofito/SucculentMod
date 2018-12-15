using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SucculentMod.Items
{
    public class ApplePie : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pie de Manzana");
            DisplayName.AddTranslation(GameCulture.English, "Apple Pie");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 31;
            item.maxStack = 99;
            item.rare = 1;
            item.useStyle = 2;
            item.useAnimation = 20;
            item.useTime = 20;
            item.UseSound = SoundID.Item2;
            item.consumable = true;
            item.healLife = 5;
            item.value = Item.sellPrice(0, 0, 0, 45);
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Apple", 5);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
