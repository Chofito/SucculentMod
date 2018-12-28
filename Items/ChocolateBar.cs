using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace SucculentMod.Items
{
    public class ChocolateBar : ModItem
    {
        //aqui no se puede usar var
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
            item.value = Item.sellPrice(10, 50, 0, 0);
        }

        public override void AddRecipes()
        {
            // ModRecipe recipe = new ModRecipe(mod);
            var recipe = new ModRecipe(mod); // aqui creamos un OBJETO que permite añadir recetas, como parametro recibe MOD, que indica que la receta es propia de este mod
            recipe.AddIngredient(mod.ItemType<Chocolate>(), 5); // aqui añadis un ingrediente, le envias el ingrediente y la cantidad
            // todas esas formas son correctas, Tile es para indicar que tiene que tener cerca tu personaje para pdoer crear el item

            recipe.AddTile(TileID.Furnaces); // TileID es para hacer referencia a un Tile/objeto de terraria, en este caso es la forja
            recipe.AddTile(TileID.WorkBenches); // y aqui esta la mesa de trabajo, luego añadiremos alguna especia de cocina xd

            recipe.AddRecipe(); // y este metodo añade la receta
        }
    }
}
