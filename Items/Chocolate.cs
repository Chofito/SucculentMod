//vamos a importar unas librerias necesarias
using Terraria; // el Namespace de los elementos basicos de terraria, aqui hay otras clases que usas para trabajar, luego lo vemos
using Terraria.ModLoader; // Namespace del ModLoader, esto contiene clases que te permite tener contacto con Terraria
using Terraria.ID; // Namespace de ID, aqui estan unas clases que contiene los identificadores de los items, etc, de terraria
using Terraria.Localization; // Aqui estan algunas clases que te permiten trabajar con los idiomas del juego
// namespace es como decir paquete y los paquetes tienen varias clases
// como en java, java.util.*    esto es el equivalente de namespace, importar todo, aparte es importar una sola clase

namespace SucculentMod.Items // aqui indicas que esta clase es de SucculentMod y esta dentro de Item
{
    public class Chocolate : ModItem // esto es esencial, aqui heredas e indicas que esta clase es un item de Terraria
    {
        // ahora tenemos que SOBRE ESCRIBIR algunas cosas para poder crear el item personalizado, para esto usas la palabra reservada override
        public override void SetStaticDefaults() // este tiene la palabra Static porque indica que esto no se puede modificar durante el juego
        // esto quiere decir que el nombre del item ES y siempre SERA Chocolate
        {
            // base.SetStaticDefaults(); no lo borro para explcarte, ese base indica que por defecto hace lo que ya estaba ahi escrito
            // imaginemos que dentro ya esta un Console.WriteLine y otras 20 lineas de codigo, pues en lugar de que aparezcan, el base lo indica
            // al borrar el base pues, es como dejarlo en blanco y te da espacio a escribir lo que necesites
            DisplayName.SetDefault("Chocolate"); // aqui pones el nombre del item
            DisplayName.AddTranslation(GameCulture.English, "Chocolate"); // aqui podes añadir traducciones, luego te enseño la otra forma, fijate en lo que sale cuando pongo el mouse
            // asi podes ver si recibe y que recibe un metodo, en este caso recibe un INT y un STRING
            // el de culture indica el idioma y value es la traduccion
            // GameCulture.English retorna un INT que indica el idioma
            Tooltip.SetDefault("Delicious uwu"); // esta es la descripcion del item, es opcional
        }

        public override void SetDefaults() // lo que esta aqui adentro si se puede modificar
        {
            // DisplayName.SetDefault("Chocolate"); // pero si lo pones aqui en vez del Static, quiere decir que si puede cambiar
            // aqui vamos a ESTABLECER las estadisticas y propiedades basicas de un item
            item.width = 32; // aqui pones el ancho del item
            item.height = 32; // el alto, usualmente usas el tamaño del sprite como un 40x28, xd
            item.maxStack = 999; // aqui definis el stack maximo
            item.rare = 10; // la rareza del item
            item.useStyle = 2; // aqui indicas la animacion que sale al usar el item, el 2 es de comer/beber
            item.useAnimation = 20; //la duracion de la animacion
            item.useTime = 20; // el tiempo que se tarda tu personaje en usarlo, animation y time suelen ser iguales
            item.UseSound = SoundID.Item2; // aqui indicas el sonido, si te das cuenta SoundID pertenece a Terraria.ID, Item2 es el sonido de comer/beber
            item.consumable = true; // aqui indicas que este item se puede consumir
            item.healLife = 5; // lo que te cura al usarlo
            // aqui hay 2 formas de decir el valor, un INT que indica cuantas monedas de cobre o Item.sellPrice(0, 0, 0, 5);
            // item.value = 1500; // osea, 1 de oro y 50 de plata
            item.value = Item.sellPrice(0, 1, 50, 0); // platino, oro, plata, cobre, 1 de oro y 50 de plata
            // ambas formas estan bien jaja ok 7.7
        }

        public override void AddRecipes()
        {
            base.AddRecipes();
        }
    }
}
