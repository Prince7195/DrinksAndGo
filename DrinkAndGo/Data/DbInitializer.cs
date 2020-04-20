using DrinkAndGo.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data
{
    public class DbInitializer
    {
        public static void Seed(AppDBContext context)
        {

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Beer",
                        Price = 7.95,
                        ShortDescription = "The most widely consumed alcohol",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://images.askmen.com/1080x540/2019/03/26-052442-man_goes_on_beer_only_diet_loses_25_pounds.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://p7.hiclipart.com/preview/352/344/58/beer-cocktail-lager-dunkel-wheat-beer-beer-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Rum & Coke",
                        Price = 12.95,
                        ShortDescription = "Cocktail made of cola, lime and rum.",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.artofdrink.com/wp-content/uploads/2016/02/rum-coke-coca-cola-cuba-libre-720x540.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://p1.hiclipart.com/preview/968/829/233/zombie-rum-and-coke-cocktail-cocacola-drink-fizzy-drinks-old-fashioned-bacardi-png-clipart-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Tequila",
                        Price = 12.95,
                        ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://townsquare.media/site/704/files/2019/07/RS13864_470777337-e1563885991396.jpg?w=980&q=75",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://w7.pngwing.com/pngs/9/574/png-transparent-olmeca-tequila-whiskey-margarita-wine-wine-distilled-beverage-wine-whiskey-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "Wine ",
                        Price = 16.75,
                        ShortDescription = "A very elegant alcoholic drink",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.nippon.com/en/ncommon/contents/japan-data/176361/176361.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://i7.pngguru.com/preview/202/692/876/red-wine-distilled-beverage-pinotage-grape-wine-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Margarita",
                        Price = 17.95,
                        ShortDescription = "A cocktail with sec, tequila and lime",
                        Category = Categories["Alcoholic"],
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/marg-h-1526063646.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcS1wcYxaW1MCIUCs1YiMS7m1JOcijE7Mt49h1GM97tZewk8D-ze&usqp=CAU"
                    },
                    new Drink
                    {
                        Name = "Whiskey with Ice",
                        Price = 15.95,
                        ShortDescription = "The best way to taste whiskey",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cmkt-image-prd.freetls.fastly.net/0.1.0/ps/6677622/910/607/m2/fpnw/wm1/luwuo7wrivuzzfdid7co7u71mt1lszsoxka825llsxnjn8xryrn3sg1gvmeknmuv-.jpg?1563115432&s=ecbb5e0772343cac62c92dcb227f01a5",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://f0.pngfuel.com/png/618/601/clear-drinking-glass-illustration-png-clip-art-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "Jägermeister",
                        Price = 15.95,
                        ShortDescription = "A German digestif made with 56 herbs",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://images.ctfassets.net/kjc0jmow0idt/L2fCg9Aq4MKwIa8SSk6U8/e5e9a74c333fad67ced83270f3e41a46/HP_img_fts.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://p7.hiclipart.com/preview/471/615/786/jagermeister-liqueur-distilled-beverage-amarula-shot-glasses-gift-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Champagne",
                        Price = 15.95,
                        ShortDescription = "That is how sparkling wine can be called",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cheap-champagne-1576023414.png?crop=1.00xw:1.00xh;0,0&resize=1200:*",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://w0.pngwave.com/png/298/237/champagne-glass-sparkling-wine-champagne-png-clip-art-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "Piña colada",
                        Price = 15.95,
                        ShortDescription = "A sweet cocktail made with rum.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.goya.com/media/6610/test33.png?quality=80",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://w0.pngwave.com/png/444/786/pina-colada-malibu-cocktail-non-alcoholic-mixed-drink-non-alcoholic-drink-cocktail-png-clip-art-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "White Russian",
                        Price = 15.95,
                        ShortDescription = "A cocktail made with vodka ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/vQNrCXreNCw/maxresdefault.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://w7.pngwing.com/pngs/533/604/png-transparent-mix-drink-glass-cocktail-martini-brandy-alexander-white-russian-vodka-cream-recipe-non-alcoholic-beverage-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "Long Island Iced Tea",
                        Price = 15.95,
                        ShortDescription = "Aa mixed drink made with tequila.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/cUZTStHFePw/maxresdefault.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://p7.hiclipart.com/preview/78/932/920/long-island-iced-tea-juice-iced-coffee-lime-ice-tea-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Vodka",
                        Price = 15.95,
                        ShortDescription = "A distilled beverage with water and ethanol.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://classic105.s3.amazonaws.com/wp-content/uploads/2019/07/vodka_banner.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://b7.pngbarn.com/png/750/948/grey-goose-vodka-distilled-beverage-distillation-cognac-vodka-png-clip-art-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "Gin and tonic",
                        Price = 15.95,
                        ShortDescription = "Made with gin and tonic water poured over ice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.foxandbriar.com/wp-content/uploads/2016/07/Spanish-Gin-Tonics-7-of-19.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://p7.hiclipart.com/preview/808/54/537/gin-and-tonic-tonic-water-cocktail-distilled-beverage-gin-tonic-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Cosmopolitan",
                        Price = 15.95,
                        ShortDescription = "Made with vodka, triple sec, cranberry juice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://files2.hungryforever.com/wp-content/uploads/2017/05/19103702/cosmopolitan_png_.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://w7.pngwing.com/pngs/15/121/png-transparent-martini-with-sliced-of-lemon-bacardi-cocktail-cosmopolitan-martini-distilled-beverage-cocktail-citrus-cocktail-non-alcoholic-beverage-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "Tea",
                        Price = 12.95,
                        ShortDescription = "Made by leaves of the tea plant in hot water.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://static.toiimg.com/photo/69385334.cms",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://i7.pngguru.com/preview/117/466/436/green-tea-masala-chai-yogi-tea-matcha-ginger-tea-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Water",
                        Price = 12.95,
                        ShortDescription = " It makes up more than half of your body weight ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRzzjK6Q_KtwqCSGPk3LgujTbFimQpm0zABTDf_S1S4-4LCt7ed&usqp=CAU",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://i7.pngguru.com/preview/874/65/185/water-glass-cup-pour-mineral-water-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Coffee",
                        Price = 12.95,
                        ShortDescription = " A beverage prepared from coffee beans",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://img.jakpost.net/c/2019/06/11/2019_06_11_74157_1560246985._large.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://w0.pngwave.com/png/730/808/cafe-computer-icons-coffee-cup-scalable-graphics-tea-png-clip-art-thumbnail.png"
                    },
                    new Drink
                    {
                        Name = "Kvass",
                        Price = 12.95,
                        ShortDescription = "A very refreshing Russian beverage",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/97/Mint_bread_kvas.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://p7.hiclipart.com/preview/586/263/627/kvass-rye-bread-beer-ale-fizzy-drinks-beer-thumbnail.jpg"
                    },
                    new Drink
                    {
                        Name = "Juice ",
                        Price = 12.95,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsu, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original for, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://res.cloudinary.com/grohealth/image/upload/v1583836679/DCUK/Content/iStock-821583034.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://f0.pngfuel.com/png/0/852/strawberry-juice-png-clip-art-thumbnail.png"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
