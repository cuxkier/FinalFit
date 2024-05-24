using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fitness.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class adada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DietName", "ImageUrl", "Price" },
                values: new object[] { "Dieta niskowęglowodanowa, wysokotłuszczowa, zaprojektowana dla osób chcących zredukować wagę. Bogata w awokado, olej kokosowy, masło i orzechy.", "Keto Lean 1500", "https://img.freepik.com/darmowe-zdjecie/grillowany-filet-z-lososia-i-salata-ze-swiezych-warzyw-z-zielonej-salaty-i-pomidorow-z-awokado-guacamole-koncepcja-zrownowazonego-odzywiania-dla-czystego-zywienia-flexitarian-srodziemnomorskiej-diety_1150-44857.jpg?t=st=1716506783~exp=1716510383~hmac=bffdc6feec3e49acd7328b5bd83e56ea2e4c1beecf0c94b380168690acaa3744&w=1060", 30.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { 1, "Utrzymanie równowagi energetycznej przy umiarkowanym spożyciu kalorii, z tłustymi rybami, mięsem karmionym trawą i zdrowymi olejami.", "Keto Balance 2000", "https://img.freepik.com/darmowe-zdjecie/apetyczna-salatka-ze-swiezymi-warzywami-i-jajkami-na-talerzu-w-kobiecych-rekach_169016-19087.jpg?t=st=1716509274~exp=1716512874~hmac=1b6849e25e6a0965d5e768b72343936894285f10bf779dd5a888ac4023b9422c&w=1060", 2000, 30.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { "Idealna dla aktywnych osób potrzebujących więcej energii. Zawiera więcej tłustych mięs, serów i oliwy z oliwek, aby dostarczyć odpowiednią ilość kalorii.", "Keto Power 2500", "https://img.freepik.com/darmowe-zdjecie/stek-z-kurczaka-na-czarnym-talerzu_1150-23143.jpg?t=st=1716509251~exp=1716512851~hmac=3098bd347cc4fe1e2d7dab709b2a0ddc07d6a0342180354363ae8c91a21128f5&w=1060", 2500, 30.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { 1, "Maksymalna energia z tłuszczów dla osób o wysokim zapotrzebowaniu kalorycznym. Zawiera smalec, masło klarowane, tłuste ryby i duże ilości orzechów.", "Keto Max 3000", "https://img.freepik.com/darmowe-zdjecie/salatka-dietetyczna-z-malzami-jajkami-przepiorczymi-ogorkami-rzodkiewka-i-salata-zdrowe-jedzenie-salatka-z-owocow-morza-widok-z-gory-lezal-plasko_2829-4457.jpg?t=st=1716506871~exp=1716510471~hmac=c4655169083ef742fd9be13e6453dad686f3a266f84be782b6f0a5717b1e8d28&w=1060", 3000, 30.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "DietName", "ImageUrl", "Price" },
                values: new object[] { "Dieta skoncentrowana na chudym mięsie, rybach, jajkach i białkach roślinnych, dostarczająca białko przy minimalnej ilości tłuszczów i węglowodanów.", "Protein Punch 1500", "https://img.freepik.com/darmowe-zdjecie/widok-z-gory-sproszkowana-maka-na-talerzu-miski-z-maka-i-migdalami-orzechowe-jajka-przepiorcze-owies-na-stole_140725-145220.jpg?t=st=1716509316~exp=1716512916~hmac=fa8dcb351d7acfdb81cc061310e7e17efd62c70bb94e2f81eef1ee719442f2f4&w=1060", 30.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { 2, "Zwiększona ilość białek z mięsa, ryb, nabiału i roślin strączkowych, z większym dodatkiem zdrowych tłuszczów i węglowodanów złożonych.", "Protein Boost 2000", "https://img.freepik.com/darmowe-zdjecie/zbieranie-powszechnych-alergenow-pokarmowych-dla-ludzi_23-2149870522.jpg?t=st=1716509332~exp=1716512932~hmac=6f7b0532e20884dc386eba6e3cdc202a937b760a86aa50bbf2ac568358c20c9b&w=1060", 2000, 30.0 });

            migrationBuilder.InsertData(
                table: "Diet",
                columns: new[] { "Id", "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[,]
                {
                    { 7, 2, "Dieta dla osób o wyższym zapotrzebowaniu energetycznym, bogata w białko z różnych źródeł oraz zdrowe tłuszcze i węglowodany.", "Protein Powerhouse 2500", "https://img.freepik.com/darmowe-zdjecie/zdrowe-skladniki-zywnosci-na-rustykalnym-stole_144627-30549.jpg?t=st=1716509347~exp=1716512947~hmac=f1642ccf870bf8785c0b7c9d556cf4ba9374d020b504b06a94b539f4f8230831&w=996", 2500, 30.0 },
                    { 8, 2, "Maksymalna ilość białka dla sportowców i aktywnych osób, z dużą ilością mięsa, ryb, nabiału i roślin strączkowych, wspierająca regenerację i budowę mięśni.", "rotein Titan 3000", "https://img.freepik.com/darmowe-zdjecie/zasierzutny-widok-chlebowi-piekarnia-skladniki-z-toczna-szpilka-na-drewnianym-tle_23-2147872582.jpg?t=st=1716509372~exp=1716512972~hmac=93104a09d00383b8fc01e2b11245fb79dac747d8db00e8b1372d6ca883aa292e&w=1060", 3000, 30.0 },
                    { 9, 3, "Niskokaloryczna dieta wegańska, bogata w warzywa, owoce, rośliny strączkowe i pełnoziarniste produkty, zapewniająca wszystkie niezbędne składniki odżywcze.", "Green Energy 1500", "https://img.freepik.com/darmowe-zdjecie/widok-z-gory-smaczne-jedzenie-dla-smakoszy-z-dipem_23-2148375712.jpg?t=st=1716509449~exp=1716513049~hmac=01bd8d5e178930b1290b23636d579f451b1d90f55cd596016f3543b6c7d23f03&w=1060", 1500, 40.0 },
                    { 10, 3, "Zbilansowana dieta roślinna z większą ilością kalorii, zawierająca orzechy, nasiona, tofu i rośliny strączkowe, zapewniająca energię i zdrowie.", "Vegan Vitality 2000", "https://img.freepik.com/darmowe-zdjecie/swieza-salatka-z-awokado-w-rustykalnej-misce-wygenerowana-przez-ai_24640-80838.jpg?t=st=1716509434~exp=1716513034~hmac=3e48b4c465783967b0be43e8c265b5b04d0014d95b01f46c502bce877b000e02&w=1380", 2000, 40.0 },
                    { 11, 3, "Dieta wegańska dla aktywnych osób, z dużą ilością roślin strączkowych, pełnoziarnistych produktów, orzechów i nasion, dostarczająca odpowiednią ilość białka i kalorii.", "Plant Power 2500", "https://img.freepik.com/darmowe-zdjecie/bardzo-swieza-miska-z-ziol-quinoa_53876-126673.jpg?t=st=1716509421~exp=1716513021~hmac=0df611545ce6b4a6b047d43a6cdf1ffd85955ec3fb1d2479cb1bc7219935dd53&w=996", 2500, 40.0 },
                    { 12, 3, "Maksymalna energia z roślin dla osób o wysokim zapotrzebowaniu kalorycznym, z dużą ilością owoców, warzyw, roślin strączkowych, orzechów i nasion.", "Vegan Fuel 3000", "https://img.freepik.com/darmowe-zdjecie/zdrowa-wegetarianska-salatka-z-komosy-ryzowej-ze-swiezymi-warzywami-wygenerowana-przez-ai_24640-80498.jpg?t=st=1716509404~exp=1716513004~hmac=e61104c82a880756601d8cd9620d1a409d4952856e0e77f1f3d901fe9f4c8a9b&w=1380", 3000, 40.0 }
                });

            migrationBuilder.InsertData(
                table: "DietsCategory",
                columns: new[] { "Id", "CategoryName", "DisplayOrder" },
                values: new object[,]
                {
                    { 4, "Dieta Wegetariańska", 4 },
                    { 5, "Dieta Karniworska", 5 }
                });

            migrationBuilder.InsertData(
                table: "Diet",
                columns: new[] { "Id", "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[,]
                {
                    { 13, 4, "Niskokaloryczna dieta wegetariańska, bogata w warzywa, owoce, nabiał i rośliny strączkowe, zapewniająca zrównoważone spożycie składników odżywczych.", "Veggie Delight 1500", "https://img.freepik.com/darmowe-zdjecie/odgornego-widoku-karmowy-przygotowania-na-drewnianym-tle_23-2148287541.jpg?t=st=1716509474~exp=1716513074~hmac=959b8a80f6142952c015fcc1cc6de461db4186b7565d893f5288552ff5a2675c&w=1060", 1500, 35.0 },
                    { 14, 4, "Zbilansowana dieta wegetariańska z większą ilością kalorii, zawierająca nabiał, jaja, warzywa i pełnoziarniste produkty, wspierająca zdrowie i energię.", "Vegetarian Harmony 2000", "https://img.freepik.com/darmowe-zdjecie/wegetarianska-miska-buddy-z-salatka-ze-swiezych-warzyw-i-ciecierzyca_1150-42361.jpg?t=st=1716509487~exp=1716513087~hmac=fe91bb21521f45bde049b7ce600fb2cc97d6eb557bb37c70c7a6dac2b5da81c1&w=1060", 2000, 35.0 },
                    { 15, 4, "Dieta dla aktywnych wegetarian, z dużą ilością nabiału, jaj, roślin strączkowych i pełnoziarnistych produktów, dostarczająca odpowiednią ilość białka i kalorii.", "Veggie Boost 2500", "https://img.freepik.com/darmowe-zdjecie/swieza-salatka-warzywna-z-bliska-na-kuchennym-stole_169016-49881.jpg?t=st=1716509498~exp=1716513098~hmac=e9137d9138b219b17fe3b3b73163a83cb8e43c8ed43e280aae49abb4ac2cfff2&w=1060", 2500, 35.0 },
                    { 16, 4, "Maksymalna energia dla wegetarian, z dużą ilością nabiału, jaj, warzyw, roślin strączkowych i pełnoziarnistych produktów, wspierająca aktywność i zdrowie.", "Veggie Max 3000", "https://img.freepik.com/darmowe-zdjecie/makaron-farfalle-z-pszenicy-durum-z-pieczonymi-klopsikami-fileta-z-kurczaka-w-sosie-pomidorowym-i-surowka-w-misce_2829-11169.jpg?t=st=1716509507~exp=1716513107~hmac=1d5943c3e8811bdb75d154fe35d97f84dea9d28d30ca9f40aafc430983e50797&w=1060", 3000, 35.0 },
                    { 17, 5, "Niskokaloryczna dieta oparta na mięsie, rybach i jajkach, minimalizująca spożycie innych składników, idealna dla osób redukujących wagę.", "Carnivore Slim 1500", "https://img.freepik.com/darmowe-zdjecie/widok-miesa-wolowego-na-tatar-ze-stekow_23-2150550508.jpg?t=st=1716509531~exp=1716513131~hmac=96ef7c54bf6fa3ff5756b16f583ab5135c18e0059046253a69fd1b00faee89ca&w=1060", 1500, 25.0 },
                    { 18, 5, "Zbilansowana dieta mięsna z większą ilością kalorii, zawierająca różnorodne rodzaje mięsa, ryby i jaja, dostarczająca energię i białko.", "Carnivore Balance 2000", "https://img.freepik.com/darmowe-zdjecie/prawdziwy-uklad-piramidy-zywieniowej-martwa-natura_23-2150238925.jpg?t=st=1716509546~exp=1716513146~hmac=cb5d237ad4fbbccd06b4ee4e8e2b07fa57727f06caf5df0a3b549e731283b430&w=1060", 2000, 25.0 },
                    { 19, 5, "Dieta dla aktywnych osób, bazująca na mięsie, rybach, jajach i tłustych produktach zwierzęcych, dostarczająca odpowiednią ilość białka i tłuszczów.", "Carnivore Power 2500", "https://img.freepik.com/darmowe-zdjecie/widok-z-gory-pyszne-jedzenie-na-stole_23-2150227827.jpg?t=st=1716509558~exp=1716513158~hmac=61a49f28faee658adca93e779be8513cfa3b006cb308c146540d4a2bc90cf215&w=1060", 2500, 25.0 },
                    { 20, 5, "Maksymalna energia z mięsa dla osób o wysokim zapotrzebowaniu kalorycznym, z dużą ilością tłustych mięs, ryb, jaj i tłuszczów zwierzęcych, wspierająca intensywną aktywność fizyczną.", "Carnivore Max 3000", "https://img.freepik.com/darmowe-zdjecie/zdrowy-obiad-obiad-w-misce-z-grillowanym-stekiem-wolowym-i-komosa-ryzowa-kukurydza-ogorkiem-rzodkiewka-i-rukola-na-drewnianym-stole-salatka-miesna_2829-6994.jpg?t=st=1716509573~exp=1716513173~hmac=ccc690fa8b3a6cde36cf635c1cc50d68ba10bf3c7ecff3fad428cf680f0b40dc&w=996", 3000, 25.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DietsCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DietsCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "DietName", "ImageUrl", "Price" },
                values: new object[] { "Dieta numer 1", "Dieta 1500kcal", "", 0.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { 2, "Dieta numer 2", "Dieta 2000kcal", "", 1500, 0.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { "Dieta numer 3", "Dieta 2500kcal", "", 1500, 0.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { 3, "Dieta numer 3", "Dieta 3000kcal", "", 1500, 0.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "DietName", "ImageUrl", "Price" },
                values: new object[] { "Dieta numer 3", "Dieta 3500kcal", "", 0.0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryDietId", "Description", "DietName", "ImageUrl", "Kcal", "Price" },
                values: new object[] { 3, "Dieta numer 3", "Dieta 4000kcal", "", 1500, 0.0 });
        }
    }
}
