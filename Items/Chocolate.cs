using Terraria; 
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization; 
namespace SucculentMod.Items 
{
    public class Chocolate : ModItem 
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chocolate"); 
            DisplayName.AddTranslation(GameCulture.English, "Chocolate"); 
            Tooltip.SetDefault("Delicious uwu"); 
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32; 
            item.maxStack = 999; 
            item.rare = 10; 
            item.useStyle = 2; 
            item.useAnimation = 20; 
            item.useTime = 20; 
            item.UseSound = SoundID.Item2; 
            item.consumable = true; 
            item.healLife = 5; 
            item.value = Item.sellPrice(0, 1, 50, 0);
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
        }
    }
}
