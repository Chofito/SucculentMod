using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace SucculentMod.Items
{
    public class ChocolateBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Barra de chocolate");
            DisplayName.AddTranslation(GameCulture.English, "Chocolate Bar");

            Tooltip.SetDefault("Comida de Dioses");
            Tooltip.AddTranslation(GameCulture.English, "Food of the Gods");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 64;
            item.maxStack = 999;
            item.rare = 10;
            item.useStyle = 2;
            item.useAnimation = 20;
            item.useTime = 20;
            item.UseSound = SoundID.Item2;
            item.consumable = true;
            item.healLife = 100;
            item.healMana = 100;
            item.value = Item.sellPrice(10, 50, 0, 0);

        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType<Chocolate>(), 5); 

            recipe.AddTile(TileID.Furnaces); 
            recipe.AddTile(TileID.WorkBenches); 

            recipe.AddRecipe(); 
        }
    }
}
