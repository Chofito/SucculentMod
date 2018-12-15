using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SucculentMod.Items
{
    public class CookedMeat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carne cocinada");
            DisplayName.AddTranslation(GameCulture.English, "Cooked Meat");

            Tooltip.SetDefault("Un sabrozo y jugoso pedazo de carne.");
            Tooltip.AddTranslation(GameCulture.English, ""); //TODO Add CookedMeat tooltip translation.
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
            item.value = Item.sellPrice(0, 0, 0, 10);
        }

        public override void AddRecipes()
        {
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "RawMeat");
            recipe.AddTile(TileID.Campfire);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
