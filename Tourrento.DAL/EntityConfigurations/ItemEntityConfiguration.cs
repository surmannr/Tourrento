using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourrento.DAL.Models;

namespace Tourrento.DAL.EntityConfigurations
{
    public class ItemEntityConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasData(
                new Item() { 
                    Id = 1,
                    InStock = 4,
                    Name = "Xemrot Tandem bicikli v2.0",
                    Description = "Ez a kétszemélyes bicikli megfelelő a túrázáshoz. Könnyen tekerhető és írányítható, ami nagyszerű élményt biztosít.",
                    Price = 3000,
                    FeePerDay = 5000,
                    ImageName = "item1.jpg"
                },
                new Item()
                {
                    Id = 2,
                    InStock = 27,
                    Name = "GroundedZero bukósisak - felnőtt",
                    Description = "Óvja biztonságát biciklizés vagy görkorcsolyázás közben! Brit tudósok által tesztelt, teljes védelmet biztosít esés esetén.",
                    Price = 990,
                    FeePerDay = 1500,
                    ImageName = "item2.jpg"
                },
                new Item()
                {
                    Id = 3,
                    InStock = 20,
                    Name = "Skydiver x20 ejtőernyő",
                    Description = "Válaszd a legnagyobb biztonságú és hatékonyságú ejtőernyőt. Dupla öltésű varratok ragasztott menettel. Megerősítés a kulcsfontosságú területeken az extra tartósság érdekében.",
                    Price = 1990,
                    FeePerDay = 3500,
                    ImageName = "item3.jpg"
                },
                new Item()
                {
                    Id = 4,
                    InStock = 3,
                    Name = "Neuzer Nelson 18 Férfi Mountain Bike bicikli",
                    Description = "A 250W extra teljesítménnyel az elektromos rásegítés kiegészíti a pedálozást, hogy megküzdj az akadályokkal. Tovább élvezheted a hegyi kerékpározást. A motor leáll, amint abbahagyod a pedálozást.",
                    Price = 1590,
                    FeePerDay = 4000,
                    ImageName = "item4.jpg"
                },
                 new Item()
                 {
                     Id = 5,
                     InStock = 24,
                     Name = "Powerslide Offroad XC Trainer 150 Terep Görkorcsolya",
                     Description = "A Offroad XC Trainer 150 Görkorcsolya a legjobb választásnak bizonyul azok számára, akik nem ragaszkodnak a járdák által megszabott útvonalakhoz. Az alumínium váz rendkívül könnyű és jó irányíthatóságot ad.",
                     Price = 1490,
                     FeePerDay = 3250,
                     ImageName = "item5.jpg"
                 },
                  new Item()
                  {
                      Id = 6,
                      InStock = 28,
                      Name = "Fa fogantyús sétabot - fekete",
                      Description = "A sétabot kiváló minőségű alumíniumból készült. Egyszerűen elfogható, és a végén csúszásgátló járóbot gumi van, amely biztonságos és zajmentes használatot tesz lehetővé.",
                      Price = 990,
                      FeePerDay = 1550,
                      ImageName = "item6.jpg"
                  },
                new Item()
                {
                    Id = 7,
                    InStock = 41,
                    Name = "Kötél karabinerrel",
                    Description = "3 m hosszú, 12 mm átmérőjű, körszövött, statikus poliamid kötél • félautomata hossz-szabályzó egység • mechanikai sérülések elleni védőtömlő • egy csavarmenetes, egy rugós karabiner • EU szabvány: EN358.",
                    Price = 990,
                    FeePerDay = 1450,
                    ImageName = "item7.jpg"
                },
                 new Item()
                 {
                     Id = 8,
                     InStock = 11,
                     Name = "Túlélő felszerelés készlet",
                     Description = "Akár sátorozni mész a természetbe, vagy akár csak fel akarsz \"fegyverkezni\" a hétköznapokban előforduló vészhelyzetekre, ez a kompakt Túlélőfelszerelés garantáltan megfelelő társad lesz. Ebben a könyvméretű csomagban összpontosul a 8 legfontosabb eszköz, amire szükséged lehet egy - egy kaland során.Méretéből adódóan pedig akkora, hogy simán elfér a hátizsákodban vagy az autó kesztyűtartójában.",
                     Price = 2390,
                     FeePerDay = 4500,
                     ImageName = "item8.jpg"
                 },
                 new Item()
                 {
                     Id = 9,
                     InStock = 17,
                     Name = "Blank 2021 Tyro 20 Inch Bike Steel Grey",
                     Description = "Széles gumiabroncsok - amortizációként szolgálhatnak, ami azt jelenti, hogy a legtöbb akadály gyakorlatilag észrevehetetlen. A tárcsára gyakorolt ​​erő sokkal nagyobb, ami csökkenti a féktávolságot.",
                     Price = 3690,
                     FeePerDay = 6400,
                     ImageName = "item9.jpg"
                 },
                 new Item()
                 {
                     Id = 10,
                     InStock = 7,
                     Name = "ZCCO Férfi Szörfoverall - XL",
                     Description = "A hideg vízben a nedvesruha extra melegen tarthatja a testet. A búvárruhák működési elve az, hogy amikor a víz belép a ruhákba, majd egy vékony vizes réteget hagy a testen. akkor a test folyamatosan mozog, hogy hőt termeljen, melegedjen és melegen tartsa a testet.",
                     Price = 5990,
                     FeePerDay = 10000,
                     ImageName = "item10.jpg"
                 }
            );
        }
    }
}
