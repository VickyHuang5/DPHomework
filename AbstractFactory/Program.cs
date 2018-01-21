using System;

namespace AbstractFactory
{
    /// <summary>
    /// 主程式
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("請輸入系列(Pokemon/Warcraft)及角色名稱，例：Pokemon,皮卡丘");
            string[] product = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (product[0].ToUpperInvariant() == "POKEMON")
            {
                Console.WriteLine("生產寶可夢Cosplay服裝：");
                PokemonCosplayClothingFactory pokemonFactory = new PokemonCosplayClothingFactory(product[1]);
                CosplayClothingStore pokemonProductLine = new CosplayClothingStore(pokemonFactory);
                pokemonProductLine.OutputClothingOfRole();
            }
            else if (product[0].ToUpperInvariant() == "WARCRAFT")
            {
                Console.WriteLine("生產魔獸爭霸Cosplay服裝：");
                WarcraftCosplayClothingFactory warcraftFactory = new WarcraftCosplayClothingFactory(product[1]);
                CosplayClothingStore warcraftProductLine = new CosplayClothingStore(warcraftFactory);
                warcraftProductLine.OutputClothingOfRole();
            }
            else
            {
                Console.WriteLine("系列名稱請輸入Pokemon或Warcraft");
            }

            Console.ReadKey();
        }
    }
}