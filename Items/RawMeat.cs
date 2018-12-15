using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace SucculentMod.Items
{
    public class RawMeat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carne cruda");
            DisplayName.AddTranslation(GameCulture.English, "Raw meat");

            Tooltip.SetDefault("No parece buena idea comer esto.");
            Tooltip.AddTranslation(GameCulture.English, ""); //TODO Add RawMeat tooltip translation.
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 31;
            item.maxStack = 999;
            item.rare = 1;
            item.useStyle = 2;
            item.useAnimation = 25;
            item.useTime = 25;
            item.UseSound = SoundID.Item2;
            item.consumable = true;
            item.value = Item.sellPrice(0, 0, 0, 10);
        }
    }
}
