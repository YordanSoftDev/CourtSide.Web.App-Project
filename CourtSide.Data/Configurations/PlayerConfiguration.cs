namespace CourtSide.Data.Configurations
{
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;
    using CourtSide.Data.Seeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(t => t.Gender)
                   .HasConversion<string>();

            builder.HasMany(p => p.Coaches)
                .WithOne(c => c.Player)
                .HasForeignKey(c => c.PlayerId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasQueryFilter(p => p.IsDeleted == false);

            builder.HasData(DefaultMensPlayers.Concat(DefaultWomensPlayers));

        }

        public static IEnumerable<Player> DefaultMensPlayers =>
            new List<Player>
        {
            new Player
            {
                Id = DeterministicGuid.Create("Player_Novak_Djokovic"),
                FirstName = "Novak",
                LastName = "Djokovic",
                Gender = Gender.Male,
                Age = 39,
                Weight = "170 lbs/(77kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Serbia"),
                Birthplace = "Belgrade, Serbia",
                Rank = 12,
                Points = 3090,
                TournamentsPlayed = 14
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Carlos_Alcaraz"),
                FirstName = "Carlos",
                LastName = "Alcaraz",
                Gender = Gender.Male,
                Age = 23,
                Weight = "163 lbs/(74kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Spain"),
                Birthplace = "El Palmar, Murcia, Spain",
                Rank = 3,
                Points = 5610,
                TournamentsPlayed = 18
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jannik_Sinner"),
                FirstName = "Jannik",
                LastName = "Sinner",
                Gender = Gender.Male,
                Age = 25,
                Weight = "168 lbs/(76kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Italy"),
                Birthplace = "Innichen, Italy",
                Rank = 1,
                Points = 10450,
                TournamentsPlayed = 20
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Daniil_Medvedev"),
                FirstName = "Daniil",
                LastName = "Medvedev",
                Gender = Gender.Male,
                Age = 30,
                Weight = "183 lbs/(83kg)",
                Height = "6'6\"/(198cm)",
                CountryId = DeterministicGuid.Create("Country_Monaco"),
                Birthplace = "Moscow, Russia",
                Rank = 5,
                Points = 3620,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alexander_Zverev"),
                FirstName = "Alexander",
                LastName = "Zverev",
                Gender = Gender.Male,
                Age = 29,
                Weight = "198 lbs/(90kg)",
                Height = "6'6\"/(198cm)",
                CountryId = DeterministicGuid.Create("Country_Germany"),
                Birthplace = "Hamburg, Germany",
                Rank = 2,
                Points = 9750,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Grigor_Dimitrov"),
                FirstName = "Grigor",
                LastName = "Dimitrov",
                Gender = Gender.Male,
                Age = 35,
                Weight = "178 lbs/(80kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Bulgaria"),
                Birthplace = "Haskovo, Bulgaria",
                Rank = 124,
                Points = 472,
                TournamentsPlayed = 16
            },
            new Player
            {
                Id = DeterministicGuid.Create( "Player_Stefanos_Tsitsipas"),
                FirstName = "Stefanos",
                LastName = "Tsitsipas",
                Gender = Gender.Male,
                Age = 28,
                Weight = "198 lbs/(90kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Greece"),
                Birthplace = "Athens, Greece",
                Rank = 35,
                Points = 1380,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Casper_Ruud"),
                FirstName = "Casper",
                LastName = "Ruud",
                Gender = Gender.Male,
                Age = 27,
                Weight = "178 lbs/(81kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Norway"),
                Birthplace = "Oslo, Norway",
                Rank = 25,
                Points = 1995,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Taylor_Fritz"),
                FirstName = "Taylor",
                LastName = "Fritz",
                Gender = Gender.Male,
                Age = 28,
                Weight = "185 lbs/(84kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Rancho Santa Fe, California, USA",
                Rank = 13,
                Points = 2830,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alex_DeMinaur"),
                FirstName = "Alex",
                LastName = "de Minaur",
                Gender = Gender.Male,
                Age = 27,
                Weight = "152 lbs/(69kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Australia"),
                Birthplace = "Sydney, Australia",
                Rank = 10,
                Points = 3280,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Andrey_Rublev"),
                FirstName = "Andrey",
                LastName = "Rublev",
                Gender = Gender.Male,
                Age = 29,
                Weight = "165 lbs/(75kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Russia"),
                Birthplace = "Moscow, Russia",
                Rank = 22,
                Points = 2175,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Hubert_Hurkacz"),
                FirstName = "Hubert",
                LastName = "Hurkacz",
                Gender = Gender.Male,
                Age = 29,
                Weight = "179 lbs/(81kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_Poland"),
                Birthplace = "Wroclaw, Poland",
                Rank = 28,
                Points = 1585,
                TournamentsPlayed = 20
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Ben_Shelton"),
                FirstName = "Ben",
                LastName = "Shelton",
                Gender = Gender.Male,
                Age = 24,
                Weight = "195 lbs/(88kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Atlanta, Georgia, USA",
                Rank = 4,
                Points = 4680,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Frances_Tiafoe"),
                FirstName = "Frances",
                LastName = "Tiafoe",
                Gender = Gender.Male,
                Age = 28,
                Weight = "190 lbs/(86kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Hyattsville, Maryland, USA",
                Rank = 8,
                Points = 3380,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Ugo_Humbert"),
                FirstName = "Ugo",
                LastName = "Humbert",
                Gender = Gender.Male,
                Age = 28,
                Weight = "161 lbs/(73kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Metz, France",
                Rank = 38,
                Points = 1270,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Sebastian_Korda"),
                FirstName = "Sebastian",
                LastName = "Korda",
                Gender = Gender.Male,
                Age = 26,
                Weight = "175 lbs/(79kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Bradenton, Florida, USA",
                Rank = 81,
                Points = 730,
                TournamentsPlayed = 18
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Lorenzo_Musetti"),
                FirstName = "Lorenzo",
                LastName = "Musetti",
                Gender = Gender.Male,
                Age = 24,
                Weight = "165 lbs/(75kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Italy"),
                Birthplace = "Carrara, Italy",
                Rank = 27,
                Points = 1720,
                TournamentsPlayed = 26
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jack_Draper"),
                FirstName = "Jack",
                LastName = "Draper",
                Gender = Gender.Male,
                Age = 24,
                Weight = "187 lbs/(85kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Sutton, London, United Kingdom",
                Rank = 157,
                Points = 360,
                TournamentsPlayed = 17
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Felix_Auger-Aliassime"),
                FirstName = "Felix",
                LastName = "Auger-Aliassime",
                Gender = Gender.Male,
                Age = 26,
                Weight = "194 lbs/(88kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Canada"),
                Birthplace = "Montreal, Canada",
                Rank = 7,
                Points = 3515,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Francisco_Comesana"),
                FirstName = "Francisco",
                LastName = "Comesana",
                Gender = Gender.Male,
                Age = 26,
                Weight = "165 lbs/(75kg)",
                Height = "5'10\"/(178cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "Mar del Plata, Argentina",
                Rank = 128,
                Points = 455,
                TournamentsPlayed = 15
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Cameron_Norrie"),
                FirstName = "Cameron",
                LastName = "Norrie",
                Gender = Gender.Male,
                Age = 31,
                Weight = "180 lbs/(82kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Johannesburg, South Africa",
                Rank = 41,
                Points = 1195,
                TournamentsPlayed = 20
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Stan_Wawrinka"),
                FirstName = "Stan",
                LastName = "Wawrinka",
                Gender = Gender.Male,
                Age = 41,
                Weight = "179 lbs/(81kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create(  "Country_Switzerland"),
                Birthplace = "Lausanne, Switzerland",
                Rank = 148,
                Points = 376,
                TournamentsPlayed = 14
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Matteo_Berrettini"),
                FirstName = "Matteo",
                LastName = "Berrettini",
                Gender = Gender.Male,
                Age = 30,
                Weight = "210 lbs/(95kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_Italy"),
                Birthplace = "Rome, Italy",
                Rank = 46,
                Points = 1083,
                TournamentsPlayed = 16
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Karen_Khachanov"),
                FirstName = "Karen",
                LastName = "Khachanov",
                Gender = Gender.Male,
                Age = 30,
                Weight = "192 lbs/(87kg)",
                Height = "6'6\"/(198cm)",
                CountryId = DeterministicGuid.Create("Country_Russia"),
                Birthplace = "Moscow, Russia",
                Rank = 24,
                Points = 2005,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Sebastian_Baez"),
                FirstName = "Sebastian",
                LastName = "Baez",
                Gender = Gender.Male,
                Age = 25,
                Weight = "154 lbs/(70kg)",
                Height = "5'7\"/(170cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "Buenos Aires, Argentina",
                Rank = 48,
                Points = 1044,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Francisco_Cerundolo"),
                FirstName = "Francisco",
                LastName = "Cerundolo",
                Gender = Gender.Male,
                Age = 28,
                Weight = "172 lbs/(78kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "Buenos Aires, Argentina",
                Rank = 19,
                Points = 2260,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alejandro_Tabilo"),
                FirstName = "Alejandro",
                LastName = "Tabilo",
                Gender = Gender.Male,
                Age = 29,
                Weight = "165 lbs/(75kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Chile"),
                Birthplace = "Toronto, Canada",
                Rank = 30,
                Points = 1565,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Tomas    Martin_Etcheverry"),
                FirstName = "Tomas Martin",
                LastName = "Etcheverry",
                Gender = Gender.Male,
                Age = 27,
                Weight = "181 lbs/(82kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "La Plata, Argentina",
                Rank = 29,
                Points = 1565,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Arthur_Fils"),
                FirstName = "Arthur",
                LastName = "Fils",
                Gender = Gender.Male,
                Age = 22,
                Weight = "183 lbs/(83kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Courcouronnes, France",
                Rank = 9,
                Points = 3375,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Adrian_Mannarino"),
                FirstName = "Adrian",
                LastName = "Mannarino",
                Gender = Gender.Male,
                Age = 38,
                Weight = "174 lbs/(79kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Soisy-sous-Montmorency, France",
                Rank = 73,
                Points = 783,
                TournamentsPlayed = 27
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jan-Lennard_Struff"),
                FirstName = "Jan-Lennard",
                LastName = "Struff",
                Gender = Gender.Male,
                Age = 36,
                Weight = "203 lbs/(92kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Germany"),
                Birthplace = "Warstein, Germany",
                Rank = 54,
                Points = 969,
                TournamentsPlayed = 19
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Nuno_Borges"),
                FirstName = "Nuno",
                LastName = "Borges",
                Gender = Gender.Male,
                Age = 29,
                Weight = "165 lbs/(75kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Portugal"),
                Birthplace = "Maia, Portugal",
                Rank = 51,
                Points = 1000,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Fabian_Marozsan"),
                FirstName = "Fabian",
                LastName = "Marozsan",
                Gender = Gender.Male,
                Age = 27,
                Weight = "165 lbs/(75kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Hungary"),
                Birthplace = "Budapest, Hungary",
                Rank = 61,
                Points = 860,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alexei_Popyrin"),
                FirstName = "Alexei",
                LastName = "Popyrin",
                Gender = Gender.Male,
                Age = 27,
                Weight = "172 lbs/(78kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_Australia"),
                Birthplace = "Sydney, Australia",
                Rank = 127,
                Points = 458,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Matteo_Arnaldi"),
                FirstName = "Matteo",
                LastName = "Arnaldi",
                Gender = Gender.Male,
                Age = 25,
                Weight = "157 lbs/(71kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_Italy"),
                Birthplace = "Sanremo, Italy",
                Rank = 36,
                Points = 1311,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Giovanni_Mpetshi Perricard"),
                FirstName = "Giovanni",
                LastName = "Mpetshi Perricard",
                Gender = Gender.Male,
                Age = 23,
                Weight = "216 lbs/(98kg)",
                Height = "6'8\"/(203cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Lyon, France",
                Rank = 146,
                Points = 385,
                TournamentsPlayed = 18
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Tommy_Paul"),
                FirstName = "Tommy",
                LastName = "Paul",
                Gender = Gender.Male,
                Age = 29,
                Weight = "180 lbs/(82kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Voorhees, New Jersey, USA",
                Rank = 14,
                Points = 2625,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Lorenzo_Sonego"),
                FirstName = "Lorenzo",
                LastName = "Sonego",
                Gender = Gender.Male,
                Age = 31,
                Weight = "169 lbs/(77kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Italy"),
                Birthplace = "Turin, Italy",
                Rank = 90,
                Points = 658,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alejandro_Davidovich Fokina"),
                FirstName = "Alejandro",
                LastName = "Davidovich Fokina",
                Gender = Gender.Male,
                Age = 27,
                Weight = "176 lbs/(80kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Spain"),
                Birthplace = "Malaga, Spain",
                Rank = 15,
                Points = 2610,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Laslo_Djere"),
                FirstName = "Laslo",
                LastName = "Djere",
                Gender = Gender.Male,
                Age = 31,
                Weight = "174 lbs/(79kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Serbia"),
                Birthplace = "Senta, Serbia",
                Rank = 136,
                Points = 412,
                TournamentsPlayed = 17
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Roman_Safiullin"),
                FirstName = "Roman",
                LastName = "Safiullin",
                Gender = Gender.Male,
                Age = 29,
                Weight = "172 lbs/(78kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Russia"),
                Birthplace = "Podolsk, Russia",
                Rank = 69,
                Points = 807,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Arthur_Rinderknech"),
                FirstName = "Arthur",
                LastName = "Rinderknech",
                Gender = Gender.Male,
                Age = 31,
                Weight = "187 lbs/(85kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Gassin, France",
                Rank = 60,
                Points = 870,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Daniel_Altmaier"),
                FirstName = "Daniel",
                LastName = "Altmaier",
                Gender = Gender.Male,
                Age = 28,
                Weight = "170 lbs/(77kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Germany"),
                Birthplace = "Kempen, Germany",
                Rank = 62,
                Points = 849,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Pavel_Kotov"),
                FirstName = "Pavel",
                LastName = "Kotov",
                Gender = Gender.Male,
                Age = 27,
                Weight = "185 lbs/(84kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Russia"),
                Birthplace = "Moscow, Russia",
                Rank = 169,
                Points = 339,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Thiago_Seyboth Wild"),
                FirstName = "Thiago",
                LastName = "Seyboth Wild",
                Gender = Gender.Male,
                Age = 26,
                Weight = "174 lbs/(79kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Brazil"),
                Birthplace = "Marechal Candido Rondon, Brazil",
                Rank = 110,
                Points = 545,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Marcos_Giron"),
                FirstName = "Marcos",
                LastName = "Giron",
                Gender = Gender.Male,
                Age = 33,
                Weight = "160 lbs/(73kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Thousand Oaks, California, USA",
                Rank = 87,
                Points = 676,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Aleksandar_Vukic"),
                FirstName = "Aleksandar",
                LastName = "Vukic",
                Gender = Gender.Male,
                Age = 30,
                Weight = "172 lbs/(78kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Australia"),
                Birthplace = "Sydney, Australia",
                Rank = 116,
                Points = 507,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Botic_van de Zandschulp"),
                FirstName = "Botic",
                LastName = "van de Zandschulp",
                Gender = Gender.Male,
                Age = 31,
                Weight = "185 lbs/(84kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Netherlands"),
                Birthplace = "Wageningen, Netherlands",
                Rank = 37,
                Points = 1295,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Miomir_Kecmanović"),
                FirstName = "Miomir",
                LastName = "Kecmanović",
                Gender = Gender.Male,
                Age = 27,
                Weight = "170 lbs/(77kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Serbia"),
                Birthplace = "Belgrade, Serbia",
                Rank = 161,
                Points = 353,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Tallon_Griekspoor"),
                FirstName = "Tallon",
                LastName = "Griekspoor",
                Gender = Gender.Male,
                Age = 30,
                Weight = "183 lbs/(83kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Netherlands"),
                Birthplace = "Haarlem, Netherlands",
                Rank = 65,
                Points = 835,
                TournamentsPlayed = 26
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Flavio_Cobolli"),
                FirstName = "Flavio",
                LastName = "Cobolli",
                Gender = Gender.Male,
                Age = 24,
                Weight = "165 lbs/(75kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Italy"),
                Birthplace = "Florence, Italy",
                Rank = 6,
                Points = 3590,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Mariano_Navone"),
                FirstName = "Mariano",
                LastName = "Navone",
                Gender = Gender.Male,
                Age = 25,
                Weight = "160 lbs/(73kg)",
                Height = "5'9\"/(175cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "9 de Julio, Argentina",
                Rank = 43,
                Points = 1164,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Brandon_Nakashima"),
                FirstName = "Brandon",
                LastName = "Nakashima",
                Gender = Gender.Male,
                Age = 25,
                Weight = "170 lbs/(77kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "San Diego, California, USA",
                Rank = 17,
                Points = 2350,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Taro_Daniel"),
                FirstName = "Taro",
                LastName = "Daniel",
                Gender = Gender.Male,
                Age = 33,
                Weight = "170 lbs/(77kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Japan"),
                Birthplace = "New York, New York, USA",
                Rank = 177,
                Points = 321,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Roberto_Carballés Baena"),
                FirstName = "Roberto",
                LastName = "Carballés Baena",
                Gender = Gender.Male,
                Age = 33,
                Weight = "165 lbs/(75kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Spain"),
                Birthplace = "Tenerife, Spain",
                Rank = 64,
                Points = 835,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jaume_Munar"),
                FirstName = "Jaume",
                LastName = "Munar",
                Gender = Gender.Male,
                Age = 29,
                Weight = "165 lbs/(75kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Spain"),
                Birthplace = "Santanyi, Spain",
                Rank = 66,
                Points = 835,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alex_Michelsen"),
                FirstName = "Alex",
                LastName = "Michelsen",
                Gender = Gender.Male,
                Age = 21,
                Weight = "170 lbs/(77kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Laguna Hills, California, USA",
                Rank = 34,
                Points = 1385,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create( "Player_Aleksandar_Kovacevic"),
                FirstName = "Aleksandar",
                LastName = "Kovacevic",
                Gender = Gender.Male,
                Age = 27,
                Weight = "174 lbs/(79kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "New York, New York, USA",
                Rank = 84,
                Points = 703,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Max_Purcell"),
                FirstName = "Max",
                LastName = "Purcell",
                Gender = Gender.Male,
                Age = 28,
                Weight = "157 lbs/(71kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Australia"),
                Birthplace = "Sydney, Australia",
                Rank = 91,
                Points = 650,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create( "Player_Thanasi_Kokkinakis"),
                FirstName = "Thanasi",
                LastName = "Kokkinakis",
                Gender = Gender.Male,
                Age = 30,
                Weight = "185 lbs/(84kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Australia"),
                Birthplace = "Adelaide, Australia",
                Rank = 75,
                Points = 760,
                TournamentsPlayed = 20
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Rinky_Hijikata"),
                FirstName = "Rinky",
                LastName = "Hijikata",
                Gender = Gender.Male,
                Age = 25,
                Weight = "152 lbs/(69kg)",
                Height = "5'10\"/(178cm)",
                CountryId = DeterministicGuid.Create("Country_Australia"),
                Birthplace = "Sydney, Australia",
                Rank = 85,
                Points = 689,
                TournamentsPlayed = 26
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_James_Duckworth"),
                FirstName = "James",
                LastName = "Duckworth",
                Gender = Gender.Male,
                Age = 34,
                Weight = "176 lbs/(80kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Australia"),
                Birthplace = "Sydney, Australia",
                Rank = 68,
                Points = 814,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Luciano_Darderi"),
                FirstName = "Luciano",
                LastName = "Darderi",
                Gender = Gender.Male,
                Age = 24,
                Weight = "172 lbs/(78kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Italy"),
                Birthplace = "Villa Gesell, Argentina",
                Rank = 23,
                Points = 2160,
                TournamentsPlayed = 26
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Gabriel_Diallo"),
                FirstName = "Gabriel",
                LastName = "Diallo",
                Gender = Gender.Male,
                Age = 24,
                Weight = "212 lbs/(96kg)",
                Height = "6'8\"/(203cm)",
                CountryId = DeterministicGuid.Create("Country_Canada"),
                Birthplace = "Montreal, Canada",
                Rank = 148,
                Points = 382,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Thiago   Agustín_Tirante"),
                FirstName = "Thiago Agustín",
                LastName = "Tirante",
                Gender = Gender.Male,
                Age = 25,
                Weight = "172 lbs/(78kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "La Plata, Argentina",
                Rank = 49,
                Points = 1024,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Quentin_Halys"),
                FirstName = "Quentin",
                LastName = "Halys",
                Gender = Gender.Male,
                Age = 29,
                Weight = "180 lbs/(82kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Bondy, France",
                Rank = 45,
                Points = 1127,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jesper_de Jong"),
                FirstName = "Jesper",
                LastName = "de Jong",
                Gender = Gender.Male,
                Age = 25,
                Weight = "159 lbs/(72kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_Netherlands"),
                Birthplace = "Haarlem, Netherlands",
                Rank = 100,
                Points = 591,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Billy_Harris"),
                FirstName = "Billy",
                LastName = "Harris",
                Gender = Gender.Male,
                Age = 31,
                Weight = "176 lbs/(80kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Nottingham, United Kingdom",
                Rank = 105,
                Points = 568,
                TournamentsPlayed = 28
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Hamad_Medjedovic"),
                FirstName = "Hamad",
                LastName = "Medjedovic",
                Gender = Gender.Male,
                Age = 23,
                Weight = "190 lbs/(86kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Serbia"),
                Birthplace = "Novi Pazar, Serbia",
                Rank = 78,
                Points = 751,
                TournamentsPlayed = 19
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Kyrian_Jacquet"),
                FirstName = "Kyrian",
                LastName = "Jacquet",
                Gender = Gender.Male,
                Age = 25,
                Weight = "155 lbs/(70kg)",
                Height = "5'10\"/(178cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Lyon, France",
                Rank = 79,
                Points = 741,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Clément_Tabur"),
                FirstName = "Clément",
                LastName = "Tabur",
                Gender = Gender.Male,
                Age = 26,
                Weight = "160 lbs/(73kg)",
                Height = "5'8\"/(173cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Reims, France",
                Rank = 160,
                Points = 355,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Benjamin_Bonzi"),
                FirstName = "Benjamin",
                LastName = "Bonzi",
                Gender = Gender.Male,
                Age = 30,
                Weight = "180 lbs/(82kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Nîmes, France",
                Rank = 97,
                Points = 617,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Luca_Van Assche"),
                FirstName = "Luca",
                LastName = "Van Assche",
                Gender = Gender.Male,
                Age = 22,
                Weight = "158 lbs/(72kg)",
                Height = "5'10\"/(178cm)",
                CountryId = DeterministicGuid.Create("Country_Belgium"),
                Birthplace = "Woluwe-Saint-Lambert, Belgium",
                Rank = 47,
                Points = 1080,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Titouan_Droguet"),
                FirstName = "Titouan",
                LastName = "Droguet",
                Gender = Gender.Male,
                Age = 25,
                Weight = "176 lbs/(80kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Villeneuve-Saint-Georges, France",
                Rank = 72,
                Points = 801,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create(  "Player_Cristian_Garin"),
                FirstName = "Cristian",
                LastName = "Garin",
                Gender = Gender.Male,
                Age = 30,
                Weight = "187 lbs/(85kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create(   "Country_Chile"),
                Birthplace = "Arica, Chile",
                Rank = 101,
                Points = 588,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Arthur_Féry"),
                FirstName = "Arthur",
                LastName = "Féry",
                Gender = Gender.Male,
                Age = 24,
                Weight = "165 lbs/(75kg)",
                Height = "5'9\"/(175cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Sèvres, France",
                Rank = 33,
                Points = 1406,
                TournamentsPlayed = 19
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Borna_Gojo"),
                FirstName = "Borna",
                LastName = "Gojo",
                Gender = Gender.Male,
                Age = 28,
                Weight = "187 lbs/(85kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_Croatia"),
                Birthplace = "Split, Croatia",
                Rank = 135,
                Points = 416,
                TournamentsPlayed = 16
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Pierre-Hugues_Herbert"),
                FirstName = "Pierre-Hugues",
                LastName = "Herbert",
                Gender = Gender.Male,
                Age = 35,
                Weight = "176 lbs/(80kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Schiltigheim, France",
                Rank = 248,
                Points = 315,
                TournamentsPlayed = 18
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Rafael_Jodar"),
                FirstName = "Rafael",
                LastName = "Jodar",
                Gender = Gender.Male,
                Age = 20,
                Weight = "154 lbs/(70kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Spain"),
                Birthplace = "Madrid, Spain",
                Rank = 11,
                Points = 2850,
                TournamentsPlayed = 17
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Arthur_Gea"),
                FirstName = "Arthur",
                LastName = "Gea",
                Gender = Gender.Male,
                Age = 21,
                Weight = "165 lbs/(75kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Hyères, France",
                Rank = 195,
                Points = 295,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Holger_Rune"),
                FirstName = "Holger",
                LastName = "Rune",
                Gender = Gender.Male,
                Age = 23,
                Weight = "170 lbs/(77kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Denmark"),
                Birthplace = "Gentofte, Denmark",
                Rank = 194,
                Points = 2850,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Learner_Tien"),
                FirstName = "Learner",
                LastName = "Tien",
                Gender = Gender.Male,
                Age = 21,
                Weight = "165 lbs/(75kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Irvine, California, USA",
                Rank = 16,
                Points = 2345,
                TournamentsPlayed = 13
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alexander_Bublik"),
                FirstName = "Alexander",
                LastName = "Bublik",
                Gender = Gender.Male,
                Age = 29,
                Weight = "181 lbs/(82kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_Kazakhstan"),
                Birthplace = "Gatchina, Russia",
                Rank = 18,
                Points = 2285,
                TournamentsPlayed = 27
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jiri_Lehecka"),
                FirstName = "Jiri",
                LastName = "Lehecka",
                Gender = Gender.Male,
                Age = 25,
                Weight = "176 lbs/(80kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                Birthplace = "Mlada Boleslav, Czech Republic",
                Rank = 20,
                Points = 2275,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Alexander_Blockx"),
                FirstName = "Alexander",
                LastName = "Blockx",
                Gender = Gender.Male,
                Age = 21,
                Weight = "179 lbs/(81kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Belgium"),
                Birthplace = "Antwerp, Belgium",
                Rank = 21,
                Points = 1790,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Valentin_Vacherot"),
                FirstName = "Valentin",
                LastName = "Vacherot",
                Gender = Gender.Male,
                Age = 28,
                Weight = "185 lbs/(84kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Monaco"),
                Birthplace = "Roquebrune-Cap-Martin, France",
                Rank = 26,
                Points = 1480,
                TournamentsPlayed = 32
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Ignacio_Buse"),
                FirstName = "Ignacio",
                LastName = "Buse",
                Gender = Gender.Male,
                Age = 22,
                Weight = "165 lbs/(75kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Peru"),
                Birthplace = "Lima, Peru",
                Rank = 31,
                Points = 1445,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Joao_Fonseca"),
                FirstName = "Joao",
                LastName = "Fonseca",
                Gender = Gender.Male,
                Age = 20,
                Weight = "176 lbs/(80kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Brazil"),
                Birthplace = "Rio de Janeiro, Brazil",
                Rank = 32,
                Points = 1250,
                TournamentsPlayed = 14
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Adolfo Daniel_Vallejo"),
                FirstName = "Adolfo Daniel",
                LastName = "Vallejo",
                Gender = Gender.Male,
                Age = 22,
                Weight = "165 lbs/(75kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Paraguay"),
                Birthplace = "Asuncion, Paraguay",
                Rank = 39,
                Points = 965,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Daniel_Merida"),
                FirstName = "Daniel",
                LastName = "Merida",
                Gender = Gender.Male,
                Age = 22,
                Weight = "165 lbs/(75kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Spain"),
                Birthplace = "Madrid, Spain",
                Rank = 40,
                Points = 1195,
                TournamentsPlayed = 28
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Raphael_Collignon"),
                FirstName = "Raphael",
                LastName = "Collignon",
                Gender = Gender.Male,
                Age = 24,
                Weight = "172 lbs/(78kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Belgium"),
                Birthplace = "Rochefort, Belgium",
                Rank = 42,
                Points = 975,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jaime_Faria"),
                FirstName = "Jaime",
                LastName = "Faria",
                Gender = Gender.Male,
                Age = 23,
                Weight = "170 lbs/(77kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Portugal"),
                Birthplace = "Lisbon, Portugal",
                Rank = 44,
                Points = 960,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Martin_Landaluce"),
                FirstName = "Martin",
                LastName = "Landaluce",
                Gender = Gender.Male,
                Age = 20,
                Weight = "172 lbs/(78kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_Spain"),
                Birthplace = "Madrid, Spain",
                Rank = 50,
                Points = 835,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Camilo_Ugo Carabelli"),
                FirstName = "Camilo",
                LastName = "Ugo Carabelli",
                Gender = Gender.Male,
                Age = 27,
                Weight = "165 lbs/(75kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "Buenos Aires, Argentina",
                Rank = 52,
                Points = 795,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Roman    Andres_Burruchaga"),
                FirstName = "Roman Andres",
                LastName = "Burruchaga",
                Gender = Gender.Male,
                Age = 24,
                Weight = "170 lbs/(77kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "Buenos Aires, Argentina",
                Rank = 53,
                Points = 765,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Kamil_Majchrzak"),
                FirstName = "Kamil",
                LastName = "Majchrzak",
                Gender = Gender.Male,
                Age = 30,
                Weight = "172 lbs/(78kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_Poland"),
                Birthplace = "Piotrkow Trybunalski, Poland",
                Rank = 55,
                Points = 722,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jacob_Fearnley"),
                FirstName = "Jacob",
                LastName = "Fearnley",
                Gender = Gender.Male,
                Age = 25,
                Weight = "170 lbs/(77kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Edinburgh, Scotland",
                Rank = 56,
                Points = 688,
                TournamentsPlayed = 20
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Marco_Trungelliti"),
                FirstName = "Marco",
                LastName = "Trungelliti",
                Gender = Gender.Male,
                Age = 36,
                Weight = "165 lbs/(75kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "Santiago del Estero, Argentina",
                Rank = 57,
                Points = 672,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Nikoloz_Basilashvili"),
                FirstName = "Nikoloz",
                LastName = "Basilashvili",
                Gender = Gender.Male,
                Age = 34,
                Weight = "174 lbs/(79kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Georgia"),
                Birthplace = "Tbilisi, Georgia",
                Rank = 58,
                Points = 630,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Marin_Cilic"),
                FirstName = "Marin",
                LastName = "Cilic",
                Gender = Gender.Male,
                Age = 38,
                Weight = "196 lbs/(89kg)",
                Height = "6'6\"/(198cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Medjugorje, Bosnia and Herzegovina",
                Rank = 59,
                Points = 625,
                TournamentsPlayed = 18
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Henrique_Rocha"),
                FirstName = "Henrique",
                LastName = "Rocha",
                Gender = Gender.Male,
                Age = 22,
                Weight = "168 lbs/(76kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Portugal"),
                Birthplace = "Porto, Portugal",
                Rank = 67,
                Points = 612,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Michael_Zheng"),
                FirstName = "Michael",
                LastName = "Zheng",
                Gender = Gender.Male,
                Age = 22,
                Weight = "165 lbs/(75kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Montville, NJ, USA",
                Rank = 70,
                Points = 605,
                TournamentsPlayed = 20
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Valentin_Royer"),
                FirstName = "Valentin",
                LastName = "Royer",
                Gender = Gender.Male,
                Age = 25,
                Weight = "172 lbs/(78kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Paris, France",
                Rank = 71,
                Points = 585,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Elmer_Moller"),
                FirstName = "Elmer",
                LastName = "Moller",
                Gender = Gender.Male,
                Age = 23,
                Weight = "168 lbs/(76kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_Denmark"),
                Birthplace = "Aarhus, Denmark",
                Rank = 74,
                Points = 570,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Vilius_Gaubas"),
                FirstName = "Vilius",
                LastName = "Gaubas",
                Gender = Gender.Male,
                Age = 21,
                Weight = "175 lbs/(79kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Lithuania"),
                Birthplace = "Siauliai, Lithuania",
                Rank = 76,
                Points = 555,
                TournamentsPlayed = 26
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Borna_Coric"),
                FirstName = "Borna",
                LastName = "Coric",
                Gender = Gender.Male,
                Age = 29,
                Weight = "183 lbs/(83kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Zagreb, Croatia",
                Rank = 77,
                Points = 750,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_David_Goffin"),
                FirstName = "David",
                LastName = "Goffin",
                Gender = Gender.Male,
                Age = 35,
                Weight = "150 lbs/(68kg)",
                Height = "5'11\"/(180cm)",
                CountryId = DeterministicGuid.Create("Country_Belgium"),
                Birthplace = "Rocourt, Belgium",
                Rank = 80,
                Points = 730,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Dominic_Thiem"),
                FirstName = "Dominic",
                LastName = "Thiem",
                Gender = Gender.Male,
                Age = 33,
                Weight = "179 lbs/(81kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Austria"),
                Birthplace = "Wiener Neustadt, Austria",
                Rank = 82,
                Points = 710,
                TournamentsPlayed = 19
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Milos_Raonic"),
                FirstName = "Milos",
                LastName = "Raonic",
                Gender = Gender.Male,
                Age = 35,
                Weight = "216 lbs/(98kg)",
                Height = "6'5\"/(196cm)",
                CountryId = DeterministicGuid.Create("Country_Canada"),
                Birthplace = "Podgorica, Montenegro",
                Rank = 83,
                Points = 695,
                TournamentsPlayed = 12
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Diego_Schwartzman"),
                FirstName = "Diego",
                LastName = "Schwartzman",
                Gender = Gender.Male,
                Age = 34,
                Weight = "152 lbs/(69kg)",
                Height = "5'7\"/(170cm)",
                CountryId = DeterministicGuid.Create("Country_Argentina"),
                Birthplace = "Buenos Aires, Argentina",
                Rank = 86,
                Points = 680,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Lukas_Klein"),
                FirstName = "Lukas",
                LastName = "Klein",
                Gender = Gender.Male,
                Age = 28,
                Weight = "185 lbs/(84kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_Slovakia"),
                Birthplace = "Spisska Nova Ves, Slovakia",
                Rank = 88,
                Points = 670,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Zizou_Bergs"),
                FirstName = "Zizou",
                LastName = "Bergs",
                Gender = Gender.Male,
                Age = 27,
                Weight = "172 lbs/(78kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_Belgium"),
                Birthplace = "Lommel, Belgium",
                Rank = 89,
                Points = 660,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Bu_Yunchaokete"),
                FirstName = "Bu",
                LastName = "Yunchaokete",
                Gender = Gender.Male,
                Age = 24,
                Weight = "172 lbs/(78kg)",
                Height = "6'1\"/(185cm)",
                CountryId = DeterministicGuid.Create("Country_China"),
                Birthplace = "Bortala, China",
                Rank = 91,
                Points = 650,
                TournamentsPlayed = 22
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Coleman_Wong"),
                FirstName = "Coleman",
                LastName = "Wong",
                Gender = Gender.Male,
                Age = 22,
                Weight = "176 lbs/(80kg)",
                Height = "6'3\"/(191cm)",
                CountryId = DeterministicGuid.Create("Country_China"),
                Birthplace = "Hong Kong, China",
                Rank = 92,
                Points = 645,
                TournamentsPlayed = 24
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Hugo_Gaston"),
                FirstName = "Hugo",
                LastName = "Gaston",
                Gender = Gender.Male,
                Age = 26,
                Weight = "150 lbs/(68kg)",
                Height = "5'8\"/(173cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Toulouse, France",
                Rank = 93,
                Points = 640,
                TournamentsPlayed = 26
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Corentin_Moutet"),
                FirstName = "Corentin",
                LastName = "Moutet",
                Gender = Gender.Male,
                Age = 27,
                Weight = "150 lbs/(68kg)",
                Height = "5'9\"/(175cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Paris, France",
                Rank = 94,
                Points = 630,
                TournamentsPlayed = 23
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Dino_Prizmic"),
                FirstName = "Dino",
                LastName = "Prizmic",
                Gender = Gender.Male,
                Age = 21,
                Weight = "170 lbs/(77kg)",
                Height = "6'2\"/(188cm)",
                CountryId = DeterministicGuid.Create("Country_Croatia"),
                Birthplace = "Split, Croatia",
                Rank = 95,
                Points = 625,
                TournamentsPlayed = 20
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Toby_Samuel"),
                FirstName = "Toby",
                LastName = "Samuel",
                Gender = Gender.Male,
                Age = 24,
                Weight = "165 lbs/(75kg)",
                Height = "6'0\"/(183cm)",
                CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                Birthplace = "Bournemouth, United Kingdom",
                Rank = 96,
                Points = 620,
                TournamentsPlayed = 21
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Terence_Atmane"),
                FirstName = "Terence",
                LastName = "Atmane",
                Gender = Gender.Male,
                Age = 24,
                Weight = "181 lbs/(82kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_France"),
                Birthplace = "Boulogne-sur-Mer, France",
                Rank = 98,
                Points = 612,
                TournamentsPlayed = 25
            },
            new Player
            {
                Id = DeterministicGuid.Create("Player_Jenson_Brooksby"),
                FirstName = "Jenson",
                LastName = "Brooksby",
                Gender = Gender.Male,
                Age = 26,
                Weight = "183 lbs/(83kg)",
                Height = "6'4\"/(193cm)",
                CountryId = DeterministicGuid.Create("Country_United States of America"),
                Birthplace = "Sacramento, California, USA",
                Rank = 99,
                Points = 605,
                TournamentsPlayed = 19
            }
        };

        public static IEnumerable<Player> DefaultWomensPlayers =>
              new List<Player>
        {
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Elena_Rybakina"),
                  FirstName = "Elena",
                  LastName = "Rybakina",
                  Gender = Gender.Female,
                  Age = 27,
                  Weight = "143 lbs/(65kg)",
                  Height = "6'0\"/(184cm)",
                  CountryId = DeterministicGuid.Create(   "Country_Kazakhstan"),
                  Birthplace = "Moscow, Russia",
                  Rank = 1,
                  Points = 9196,
                  TournamentsPlayed = 20
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Aryna_Sabalenka"),
                  FirstName = "Aryna",
                  LastName = "Sabalenka",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "176 lbs/(80kg)",
                  Height = "6'0\"/(182cm)",
                  CountryId = DeterministicGuid.Create( "Country_Belarus"),
                  Birthplace = "Minsk, Belarus",
                  Rank = 2,
                  Points = 7550,
                  TournamentsPlayed = 20
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Mirra_Andreeva"),
                  FirstName = "Mirra",
                  LastName = "Andreeva",
                  Gender = Gender.Female,
                  Age = 19,
                  Weight = "135 lbs/(61kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create( "Country_Russia"),
                  Birthplace = "Krasnoyarsk, Russia",
                  Rank = 3,
                  Points = 6306,
                  TournamentsPlayed = 20
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Jessica_Pegula"),
                  FirstName = "Jessica",
                  LastName = "Pegula",
                  Gender = Gender.Female,
                  Age = 32,
                  Weight = "154 lbs/(70kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Buffalo, New York, USA",
                  Rank = 4,
                  Points = 6235,
                  TournamentsPlayed = 19
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Coco_Gauff"),
                  FirstName = "Coco",
                  LastName = "Gauff",
                  Gender = Gender.Female,
                  Age = 22,
                  Weight = "141 lbs/(64kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Delray Beach, Florida, USA",
                  Rank = 5,
                  Points = 5974,
                  TournamentsPlayed = 19
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Elina_Svitolina"),
                  FirstName = "Elina",
                  LastName = "Svitolina",
                  Gender = Gender.Female,
                  Age = 32,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'9\"/(174cm)",
                  CountryId = DeterministicGuid.Create( "Country_Ukraine"),
                  Birthplace = "Odesa, Ukraine",
                  Rank = 6,
                  Points = 5229,
                  TournamentsPlayed = 19
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Karolina_Muchova"),
                  FirstName = "Karolina",
                  LastName = "Muchova",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "141 lbs/(64kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Olomouc, Czech Republic",
                  Rank = 7,
                  Points = 4833,
                  TournamentsPlayed = 19
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Linda_Noskova"),
                  FirstName = "Linda",
                  LastName = "Noskova",
                  Gender = Gender.Female,
                  Age = 21,
                  Weight = "143 lbs/(65kg)",
                  Height = "5'10\"/(179cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Vsetín, Czech Republic",
                  Rank = 8,
                  Points = 4678,
                  TournamentsPlayed = 19
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Iga_Swiatek"),
                  FirstName = "Iga",
                  LastName = "Swiatek",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "143 lbs/(65kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create( "Country_Poland"),
                  Birthplace = "Warsaw, Poland",
                  Rank = 9,
                  Points = 4389,
                  TournamentsPlayed = 19
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Marta_Kostyuk"),
                  FirstName = "Marta",
                  LastName = "Kostyuk",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "137 lbs/(62kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create( "Country_Ukraine"),
                  Birthplace = "Kyiv, Ukraine",
                  Rank = 10,
                  Points = 3920,
                  TournamentsPlayed = 18
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Maja_Chwalinska"),
                  FirstName = "Maja",
                  LastName = "Chwalinska",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'5\"/(165cm)",
                  CountryId = DeterministicGuid.Create( "Country_Poland"),
                  Birthplace = "Dąbrowa Górnicza, Poland",
                  Rank = 11,
                  Points = 3031,
                  TournamentsPlayed = 22
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Iva_Jovic"),
                  FirstName = "Iva",
                  LastName = "Jovic",
                  Gender = Gender.Female,
                  Age = 18,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Torrance, California, USA",
                  Rank = 12,
                  Points = 2931,
                  TournamentsPlayed = 22
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Diana_Shnaider"),
                  FirstName = "Diana",
                  LastName = "Shnaider",
                  Gender = Gender.Female,
                  Age = 22,
                  Weight = "143 lbs/(65kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create( "Country_Russia"),
                  Birthplace = "Zhigulyovsk, Russia",
                  Rank = 13,
                  Points = 2663,
                  TournamentsPlayed = 22
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Belinda_Bencic"),
                  FirstName = "Belinda",
                  LastName = "Bencic",
                  Gender = Gender.Female,
                  Age = 29,
                  Weight = "139 lbs/(63kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create (   "Country_Switzerland"),
                  Birthplace = "Flawil, Switzerland",
                  Rank = 14,
                  Points = 2662,
                  TournamentsPlayed = 18
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Elise_Mertens"),
                  FirstName = "Elise",
                  LastName = "Mertens",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "148 lbs/(67kg)",
                  Height = "5'10\"/(179cm)",
                  CountryId = DeterministicGuid.Create( "Country_Belgium"),
                  Birthplace = "Leuven, Belgium",
                  Rank = 15,
                  Points = 2540,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Victoria_Mboko"),
                  FirstName = "Victoria",
                  LastName = "Mboko",
                  Gender = Gender.Female,
                  Age = 20,
                  Weight = "143 lbs/(65kg)",
                  Height = "5'9\"/(176cm)",
                  CountryId = DeterministicGuid.Create( "Country_Canada"),
                  Birthplace = "Charlotte, North Carolina, USA",
                  Rank = 16,
                  Points = 2501,
                  TournamentsPlayed = 16
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Sorana_Cirstea"),
                  FirstName = "Sorana",
                  LastName = "Cirstea",
                  Gender = Gender.Female,
                  Age = 36,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'9\"/(176cm)",
                  CountryId = DeterministicGuid.Create( "Country_Romania"),
                  Birthplace = "Bucharest, Romania",
                  Rank = 17,
                  Points = 2380,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Amanda_Anisimova"),
                  FirstName = "Amanda",
                  LastName = "Anisimova",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Freehold, New Jersey, USA",
                  Rank = 18,
                  Points = 2363,
                  TournamentsPlayed = 15
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Naomi_Osaka"),
                  FirstName = "Naomi",
                  LastName = "Osaka",
                  Gender = Gender.Female,
                  Age = 29,
                  Weight = "152 lbs/(69kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_Japan"),
                  Birthplace = "Chuo-ku, Osaka, Japan",
                  Rank = 19,
                  Points = 2297,
                  TournamentsPlayed = 18
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Alexandra_Eala"),
                  FirstName = "Alexandra",
                  LastName = "Eala",
                  Gender = Gender.Female,
                  Age = 21,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create (   "Country_Philippines"),
                  Birthplace = "Quezon City, Philippines",
                  Rank = 20,
                  Points = 2241,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Madison_Keys"),
                  FirstName = "Madison",
                  LastName = "Keys",
                  Gender = Gender.Female,
                  Age = 31,
                  Weight = "145 lbs/(66kg)",
                  Height = "5'10\"/(178cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Rock Island, Illinois, USA",
                  Rank = 21,
                  Points = 2029,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Qinwen_Zheng"),
                  FirstName = "Qinwen",
                  LastName = "Zheng",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "139 lbs/(63kg)",
                  Height = "5'10\"/(178cm)",
                  CountryId = DeterministicGuid.Create("Country_China"),
                  Birthplace = "Shiyan, Hubei, China",
                  Rank = 22,
                  Points = 2018,
                  TournamentsPlayed = 18
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Anna_Kalinskaya"),
                  FirstName = "Anna",
                  LastName = "Kalinskaya",
                  Gender = Gender.Female,
                  Age = 27,
                  Weight = "137 lbs/(62kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create( "Country_Russia"),
                  Birthplace = "Moscow, Russia",
                  Rank = 23,
                  Points = 1989,
                  TournamentsPlayed = 22
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Jelena_Ostapenko"),
                  FirstName = "Jelena",
                  LastName = "Ostapenko",
                  Gender = Gender.Female,
                  Age = 29,
                  Weight = "141 lbs/(64kg)",
                  Height = "5'10\"/(178cm)",
                  CountryId = DeterministicGuid.Create("Country_Latvia"),
                  Birthplace = "Riga, Latvia",
                  Rank = 24,
                  Points = 1916,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Ann_Li"),
                  FirstName = "Ann",
                  LastName = "Li",
                  Gender = Gender.Female,
                  Age = 26,
                  Weight = "135 lbs/(61kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "King of Prussia, Pennsylvania, USA",
                  Rank = 25,
                  Points = 1833,
                  TournamentsPlayed = 27
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Marie_Bouzkova"),
                  FirstName = "Marie",
                  LastName = "Bouzkova",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "134 lbs/(61kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Prague, Czech Republic",
                  Rank = 26,
                  Points = 1818,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create ( "Player_Anastasia_Potapova"),
                  FirstName = "Anastasia",
                  LastName = "Potapova",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "126 lbs/(57kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create("Country_Russia"),
                  Birthplace = "Saratov, Russia",
                  Rank = 27,
                  Points = 1814,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Emma_Navarro"),
                  FirstName = "Emma",
                  LastName = "Navarro",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "154 lbs/(70kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "New York City, New York, USA",
                  Rank = 28,
                  Points = 1794,
                  TournamentsPlayed = 25
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Nikola_Bartunkova"),
                  FirstName = "Nikola",
                  LastName = "Bartunkova",
                  Gender = Gender.Female,
                  Age = 20,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Prague, Czech Republic",
                  Rank = 29,
                  Points = 1711,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Leylah_Fernandez"),
                  FirstName = "Leylah",
                  LastName = "Fernandez",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'6\"/(168cm)",
                  CountryId = DeterministicGuid.Create("Country_Canada"),
                  Birthplace = "Montreal, Canada",
                  Rank = 30,
                  Points = 1709,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Maria_Sakkari"),
                  FirstName = "Maria",
                  LastName = "Sakkari",
                  Gender = Gender.Female,
                  Age = 31,
                  Weight = "138 lbs/(62kg)",
                  Height = "5'8\"/(172cm)",
                  CountryId = DeterministicGuid.Create("Country_Greece"),
                  Birthplace = "Athens, Greece",
                  Rank = 31,
                  Points = 1706,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Sara_Bejlek"),
                  FirstName = "Sara",
                  LastName = "Bejlek",
                  Gender = Gender.Female,
                  Age = 20,
                  Weight = "125 lbs/(57kg)",
                  Height = "5'5\"/(165cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Hrušovany nad Jevišovkou, Czech Republic",
                  Rank = 32,
                  Points = 1650,
                  TournamentsPlayed = 25
              },
              new Player
              {
                  Id = DeterministicGuid.Create ("Player_Ekaterina_Alexandrova"),
                  FirstName = "Ekaterina",
                  LastName = "Alexandrova",
                  Gender = Gender.Female,
                  Age = 31,
                  Weight = "146 lbs/(66kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create("Country_Russia"),
                  Birthplace = "Chelyabinsk, Russia",
                  Rank = 33,
                  Points = 1591,
                  TournamentsPlayed = 26
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Diane_Parry"),
                  FirstName = "Diane",
                  LastName = "Parry",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_France"),
                  Birthplace = "Nice, France",
                  Rank = 34,
                  Points = 1549,
                  TournamentsPlayed = 27
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Jasmine_Paolini"),
                  FirstName = "Jasmine",
                  LastName = "Paolini",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "119 lbs/(54kg)",
                  Height = "5'4\"/(163cm)",
                  CountryId = DeterministicGuid.Create("Country_Italy"),
                  Birthplace = "Castelnuovo di Garfagnana, Italy",
                  Rank = 35,
                  Points = 1453,
                  TournamentsPlayed = 19
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Donna_Vekic"),
                  FirstName = "Donna",
                  LastName = "Vekic",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "141 lbs/(64kg)",
                  Height = "5'10\"/(179cm)",
                  CountryId = DeterministicGuid.Create("Country_Croatia"),
                  Birthplace = "Osijek, Croatia",
                  Rank = 36,
                  Points = 1333,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Peyton_Stearns"),
                  FirstName = "Peyton",
                  LastName = "Stearns",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "135 lbs/(61kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Cincinnati, Ohio, USA",
                  Rank = 37,
                  Points = 1316,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Cristina_Bucsa"),
                  FirstName = "Cristina",
                  LastName = "Bucsa",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create("Country_Spain"),
                  Birthplace = "Chisinau, Moldova",
                  Rank = 38,
                  Points = 1294,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Xinyu_Wang"),
                  FirstName = "Xinyu",
                  LastName = "Wang",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "139 lbs/(63kg)",
                  Height = "6'0\"/(182cm)",
                  CountryId = DeterministicGuid.Create("Country_China"),
                  Birthplace = "Shenzhen, China",
                  Rank = 39,
                  Points = 1288,
                  TournamentsPlayed = 25
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Daria_Snigur"),
                  FirstName = "Daria",
                  LastName = "Snigur",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_Ukraine"),
                  Birthplace = "Kyiv, Ukraine",
                  Rank = 40,
                  Points = 1280,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Kimberly_Birrell"),
                  FirstName = "Kimberly",
                  LastName = "Birrell",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_Australia"),
                  Birthplace = "Dusseldorf, Germany",
                  Rank = 41,
                  Points = 1280,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Talia_Gibson"),
                  FirstName = "Talia",
                  LastName = "Gibson",
                  Gender = Gender.Female,
                  Age = 22,
                  Weight = "135 lbs/(61kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create("Country_Australia"),
                  Birthplace = "Perth, Australia",
                  Rank = 42,
                  Points = 1273,
                  TournamentsPlayed = 31
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Liudmila_Samsonova"),
                  FirstName = "Liudmila",
                  LastName = "Samsonova",
                  Gender = Gender.Female,
                  Age = 27,
                  Weight = "148 lbs/(67kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_Russia"),
                  Birthplace = "Olenegorsk, Russia",
                  Rank = 43,
                  Points = 1234,
                  TournamentsPlayed = 25
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Hailey_Baptiste"),
                  FirstName = "Hailey",
                  LastName = "Baptiste",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "150 lbs/(68kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Washington, D.C., USA",
                  Rank = 44,
                  Points = 1154,
                  TournamentsPlayed = 15
              },
              new Player
              {
                  Id = DeterministicGuid.Create ( "Player_Barbora_Krejcikova"),
                  FirstName = "Barbora",
                  LastName = "Krejcikova",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "137 lbs/(62kg)",
                  Height = "5'10\"/(178cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Brno, Czech Republic",
                  Rank = 45,
                  Points = 1133,
                  TournamentsPlayed = 20
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Janice_Tjen"),
                  FirstName = "Janice",
                  LastName = "Tjen",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'6\"/(168cm)",
                  CountryId = DeterministicGuid.Create("Country_Indonesia"),
                  Birthplace = "Jakarta, Indonesia",
                  Rank = 46,
                  Points = 1120,
                  TournamentsPlayed = 29
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Magdalena_Frech"),
                  FirstName = "Magdalena",
                  LastName = "Frech",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "134 lbs/(61kg)",
                  Height = "5'7\"/(171cm)",
                  CountryId = DeterministicGuid.Create("Country_Poland"),
                  Birthplace = "Łódź, Poland",
                  Rank = 47,
                  Points = 1110,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Karolina_Pliskova"),
                  FirstName = "Karolina",
                  LastName = "Pliskova",
                  Gender = Gender.Female,
                  Age = 34,
                  Weight = "159 lbs/(72kg)",
                  Height = "6'1\"/(186cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Louny, Czech Republic",
                  Rank = 48,
                  Points = 1105,
                  TournamentsPlayed = 15
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Sonay_Kartal"),
                  FirstName = "Sonay",
                  LastName = "Kartal",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                  Birthplace = "London, United Kingdom",
                  Rank = 49,
                  Points = 1097,
                  TournamentsPlayed = 11
              },
              new Player
              {
                  Id = DeterministicGuid.Create ( "Player_Yuliia_Starodubtseva"),
                  FirstName = "Yuliia",
                  LastName = "Starodubtseva",
                  Gender = Gender.Female,
                  Age = 26,
                  Weight = "135 lbs/(61kg)",
                  Height = "5'8\"/(172cm)",
                  CountryId = DeterministicGuid.Create("Country_Ukraine"),
                  Birthplace = "Kakhovka, Ukraine",
                  Rank = 50,
                  Points = 1090,
                  TournamentsPlayed = 29
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Anhelina_Kalinina"),
                  FirstName = "Anhelina",
                  LastName = "Kalinina",
                  Gender = Gender.Female,
                  Age = 29,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'10\"/(179cm)",
                  CountryId = DeterministicGuid.Create("Country_Ukraine"),
                  Birthplace = "Nova Kakhovka, Ukraine",
                  Rank = 51,
                  Points = 1087,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Mayar_Sherif"),
                  FirstName = "Mayar",
                  LastName = "Sherif",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "137 lbs/(62kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_Egypt"),
                  Birthplace = "Cairo, Egypt",
                  Rank = 52,
                  Points = 1085,
                  TournamentsPlayed = 27
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Lanlana_Tararudee"),
                  FirstName = "Lanlana",
                  LastName = "Tararudee",
                  Gender = Gender.Female,
                  Age = 22,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create("Country_Thailand"),
                  Birthplace = "Nakhon Ratchasima, Thailand",
                  Rank = 53,
                  Points = 1080,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Clara_Tauson"),
                  FirstName = "Clara",
                  LastName = "Tauson",
                  Gender = Gender.Female,
                  Age = 23,
                  Weight = "150 lbs/(68kg)",
                  Height = "6'0\"/(182cm)",
                  CountryId = DeterministicGuid.Create("Country_Denmark"),
                  Birthplace = "Copenhagen, Denmark",
                  Rank = 54,
                  Points = 1074,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Ashlyn_Krueger"),
                  FirstName = "Ashlyn",
                  LastName = "Krueger",
                  Gender = Gender.Female,
                  Age = 22,
                  Weight = "143 lbs/(65kg)",
                  Height = "6'1\"/(185cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Spring, Texas, USA",
                  Rank = 55,
                  Points = 1072,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Tamara_Korpatsch"),
                  FirstName = "Tamara",
                  LastName = "Korpatsch",
                  Gender = Gender.Female,
                  Age = 31,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_Germany"),
                  Birthplace = "Hamburg, Germany",
                  Rank = 56,
                  Points = 1070,
                  TournamentsPlayed = 33
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Lilli_Tagger"),
                  FirstName = "Lilli",
                  LastName = "Tagger",
                  Gender = Gender.Female,
                  Age = 18,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create("Country_Austria"),
                  Birthplace = "Lienz, Austria",
                  Rank = 57,
                  Points = 1052,
                  TournamentsPlayed = 22
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Katie_Boulter"),
                  FirstName = "Katie",
                  LastName = "Boulter",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "137 lbs/(62kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                  Birthplace = "Leicester, United Kingdom",
                  Rank = 58,
                  Points = 1042,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Caty_Mcnally"),
                  FirstName = "Caty",
                  LastName = "Mcnally",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "139 lbs/(63kg)",
                  Height = "5'10\"/(178cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Cincinnati, Ohio, USA",
                  Rank = 59,
                  Points = 1035,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Elena- Gabriela_Ruse"),
                  FirstName = "Elena-Gabriela",
                  LastName = "Ruse",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'8\"/(172cm)",
                  CountryId = DeterministicGuid.Create("Country_Romania"),
                  Birthplace = "Bucharest, Romania",
                  Rank = 60,
                  Points = 1033,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Paula_Badosa"),
                  FirstName = "Paula",
                  LastName = "Badosa",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "154 lbs/(70kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_Spain"),
                  Birthplace = "New York City, USA",
                  Rank = 61,
                  Points = 1023,
                  TournamentsPlayed = 22
              },
              new Player
              {
                  Id = DeterministicGuid.Create ( "Player_Oleksandra_Oliynykova"),
                  FirstName = "Oleksandra",
                  LastName = "Oliynykova",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create("Country_Ukraine"),
                  Birthplace = "Kyiv, Ukraine",
                  Rank = 62,
                  Points = 1022,
                  TournamentsPlayed = 30
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Zeynep_Sonmez"),
                  FirstName = "Zeynep",
                  LastName = "Sonmez",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create( "Country_Turkey"),
                  Birthplace = "Istanbul, Turkey",
                  Rank = 63,
                  Points = 987,
                  TournamentsPlayed = 26
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Alycia_Parks"),
                  FirstName = "Alycia",
                  LastName = "Parks",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "143 lbs/(65kg)",
                  Height = "6'1\"/(185cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Atlanta, Georgia, USA",
                  Rank = 64,
                  Points = 985,
                  TournamentsPlayed = 36
              },
              new Player
              {
                  Id = DeterministicGuid.Create(  "Player_Elisabetta_Cocciaretto"),
                  FirstName = "Elisabetta",
                  LastName = "Cocciaretto",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "123 lbs/(56kg)",
                  Height = "5'5\"/(166cm)",
                  CountryId = DeterministicGuid.Create("Country_Italy"),
                  Birthplace = "Ancona, Italy",
                  Rank = 65,
                  Points = 975,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Yulia_Putintseva"),
                  FirstName = "Yulia",
                  LastName = "Putintseva",
                  Gender = Gender.Female,
                  Age = 31,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'4\"/(163cm)",
                  CountryId = DeterministicGuid.Create( "Country_Kazakhstan"),
                  Birthplace = "Moscow, Russia",
                  Rank = 66,
                  Points = 969,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Kamilla_Rakhimova"),
                  FirstName = "Kamilla",
                  LastName = "Rakhimova",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create( "Country_Uzbekistan"),
                  Birthplace = "Yekaterinburg, Russia",
                  Rank = 67,
                  Points = 966,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Camila_Osorio"),
                  FirstName = "Camila",
                  LastName = "Osorio",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'3\"/(160cm)",
                  CountryId = DeterministicGuid.Create( "Country_Colombia"),
                  Birthplace = "Cúcuta, Colombia",
                  Rank = 68,
                  Points = 963,
                  TournamentsPlayed = 25
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Tatjana_Maria"),
                  FirstName = "Tatjana",
                  LastName = "Maria",
                  Gender = Gender.Female,
                  Age = 39,
                  Weight = "137 lbs/(62kg)",
                  Height = "5'8\"/(172cm)",
                  CountryId = DeterministicGuid.Create( "Country_Germany"),
                  Birthplace = "Bad Saulgau, Germany",
                  Rank = 69,
                  Points = 945,
                  TournamentsPlayed = 32
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Maria_Timofeeva"),
                  FirstName = "Maria",
                  LastName = "Timofeeva",
                  Gender = Gender.Female,
                  Age = 22,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'6\"/(167cm)",
                  CountryId = DeterministicGuid.Create( "Country_Uzbekistan"),
                  Birthplace = "Moscow, Russia",
                  Rank = 70,
                  Points = 931,
                  TournamentsPlayed = 25
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Jaqueline_Cristian"),
                  FirstName = "Jaqueline",
                  LastName = "Cristian",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "143 lbs/(65kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create( "Country_Romania"),
                  Birthplace = "Bucharest, Romania",
                  Rank = 71,
                  Points = 928,
                  TournamentsPlayed = 20
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Anna_Blinkova"),
                  FirstName = "Anna",
                  LastName = "Blinkova",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'10\"/(179cm)",
                  CountryId = DeterministicGuid.Create( "Country_France"),
                  Birthplace = "Moscow, Russia",
                  Rank = 72,
                  Points = 921,
                  TournamentsPlayed = 32
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Sinja_Kraus"),
                  FirstName = "Sinja",
                  LastName = "Kraus",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'8\"/(172cm)",
                  CountryId = DeterministicGuid.Create( "Country_Austria"),
                  Birthplace = "Lienz, Austria",
                  Rank = 76,
                  Points = 910,
                  TournamentsPlayed = 32
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Magda_Linette"),
                  FirstName = "Magda",
                  LastName = "Linette",
                  Gender = Gender.Female,
                  Age = 34,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'7\"/(171cm)",
                  CountryId = DeterministicGuid.Create( "Country_Poland"),
                  Birthplace = "Poznań, Poland",
                  Rank = 77,
                  Points = 908,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Petra_Marcinko"),
                  FirstName = "Petra",
                  LastName = "Marcinko",
                  Gender = Gender.Female,
                  Age = 20,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create( "Country_Croatia"),
                  Birthplace = "Zagreb, Croatia",
                  Rank = 78,
                  Points = 905,
                  TournamentsPlayed = 30
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Kaitlin_Quevedo"),
                  FirstName = "Kaitlin",
                  LastName = "Quevedo",
                  Gender = Gender.Female,
                  Age = 20,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_Spain"),
                  Birthplace = "Naples, Florida, USA",
                  Rank = 79,
                  Points = 902,
                  TournamentsPlayed = 23
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Alina_Korneeva"),
                  FirstName = "Alina",
                  LastName = "Korneeva",
                  Gender = Gender.Female,
                  Age = 19,
                  Weight = "135 lbs/(61kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create( "Country_Russia"),
                  Birthplace = "Moscow, Russia",
                  Rank = 80,
                  Points = 900,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Xiyu_Wang"),
                  FirstName = "Xiyu",
                  LastName = "Wang",
                  Gender = Gender.Female,
                  Age = 25,
                  Weight = "148 lbs/(67kg)",
                  Height = "5'11\"/(180cm)",
                  CountryId = DeterministicGuid.Create("Country_China"),
                  Birthplace = "Taixing, Jiangsu, China",
                  Rank = 81,
                  Points = 899,
                  TournamentsPlayed = 17
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Viktorija_Golubic"),
                  FirstName = "Viktorija",
                  LastName = "Golubic",
                  Gender = Gender.Female,
                  Age = 34,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'7\"/(169cm)",
                  CountryId = DeterministicGuid.Create( "Country_Switzerland"),
                  Birthplace = "Zurich, Switzerland",
                  Rank = 82,
                  Points = 899,
                  TournamentsPlayed = 24
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Panna_Udvardy"),
                  FirstName = "Panna",
                  LastName = "Udvardy",
                  Gender = Gender.Female,
                  Age = 28,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create( "Country_Hungary"),
                  Birthplace = "Kaposvár, Hungary",
                  Rank = 83,
                  Points = 899,
                  TournamentsPlayed = 31
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Mananchaya_Sawangkaew"),
                  FirstName = "Mananchaya",
                  LastName = "Sawangkaew",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'6\"/(168cm)",
                  CountryId = DeterministicGuid.Create( "Country_Thailand"),
                  Birthplace = "Chanthaburi, Thailand",
                  Rank = 84,
                  Points = 886,
                  TournamentsPlayed = 27
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Shuai_Zhang"),
                  FirstName = "Shuai",
                  LastName = "Zhang",
                  Gender = Gender.Female,
                  Age = 37,
                  Weight = "143 lbs/(65kg)",
                  Height = "5'10\"/(177cm)",
                  CountryId = DeterministicGuid.Create("Country_China"),
                  Birthplace = "Tianjin, China",
                  Rank = 85,
                  Points = 880,
                  TournamentsPlayed = 33
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Katerina_Siniakova"),
                  FirstName = "Katerina",
                  LastName = "Siniakova",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "150 lbs/(68kg)",
                  Height = "5'9\"/(174cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Hradec Králové, Czech Republic",
                  Rank = 86,
                  Points = 865,
                  TournamentsPlayed = 18
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Taylah_Preston"),
                  FirstName = "Taylah",
                  LastName = "Preston",
                  Gender = Gender.Female,
                  Age = 20,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'8\"/(172cm)",
                  CountryId = DeterministicGuid.Create( "Country_Australia"),
                  Birthplace = "Perth, Australia",
                  Rank = 87,
                  Points = 858,
                  TournamentsPlayed = 32
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Tereza_Valentova"),
                  FirstName = "Tereza",
                  LastName = "Valentova",
                  Gender = Gender.Female,
                  Age = 19,
                  Weight = "135 lbs/(61kg)",
                  Height = "5'10\"/(178cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Prague, Czech Republic",
                  Rank = 88,
                  Points = 833,
                  TournamentsPlayed = 21
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Taylor_Townsend"),
                  FirstName = "Taylor",
                  LastName = "Townsend",
                  Gender = Gender.Female,
                  Age = 30,
                  Weight = "170 lbs/(77kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Chicago, Illinois, USA",
                  Rank = 89,
                  Points = 831,
                  TournamentsPlayed = 13
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Maya_Joint"),
                  FirstName = "Maya",
                  LastName = "Joint",
                  Gender = Gender.Female,
                  Age = 20,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create( "Country_Australia"),
                  Birthplace = "Grosse Pointe, Michigan, USA",
                  Rank = 90,
                  Points = 824,
                  TournamentsPlayed = 26
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Antonia_Ruzic"),
                  FirstName = "Antonia",
                  LastName = "Ruzic",
                  Gender = Gender.Female,
                  Age = 23,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'9\"/(175cm)",
                  CountryId = DeterministicGuid.Create( "Country_Croatia"),
                  Birthplace = "Oroslavje, Croatia",
                  Rank = 91,
                  Points = 823,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Leolia_Jeanjean"),
                  FirstName = "Leolia",
                  LastName = "Jeanjean",
                  Gender = Gender.Female,
                  Age = 31,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'6\"/(168cm)",
                  CountryId = DeterministicGuid.Create( "Country_France"),
                  Birthplace = "Montpellier, France",
                  Rank = 92,
                  Points = 816,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Darja_Vidmanova"),
                  FirstName = "Darja",
                  LastName = "Vidmanova",
                  Gender = Gender.Female,
                  Age = 23,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create("Country_Czech Republic"),
                  Birthplace = "Moscow, Russia",
                  Rank = 93,
                  Points = 812,
                  TournamentsPlayed = 26
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Renata_Zarazua"),
                  FirstName = "Renata",
                  LastName = "Zarazua",
                  Gender = Gender.Female,
                  Age = 29,
                  Weight = "126 lbs/(57kg)",
                  Height = "5'3\"/(160cm)",
                  CountryId = DeterministicGuid.Create( "Country_Mexico"),
                  Birthplace = "Mexico City, Mexico",
                  Rank = 94,
                  Points = 801,
                  TournamentsPlayed = 34
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Claire_Liu"),
                  FirstName = "Claire",
                  LastName = "Liu",
                  Gender = Gender.Female,
                  Age = 26,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create("Country_United States of America"),
                  Birthplace = "Thousand Oaks, California, USA",
                  Rank = 95,
                  Points = 789,
                  TournamentsPlayed = 25
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Jessica_ Bouzas Maneiro"),
                  FirstName = "Jessica",
                  LastName = "Bouzas Maneiro",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "134 lbs/(61kg)",
                  Height = "5'8\"/(173cm)",
                  CountryId = DeterministicGuid.Create("Country_Spain"),
                  Birthplace = "Vilagarcía de Arousa, Spain",
                  Rank = 96,
                  Points = 769,
                  TournamentsPlayed = 29
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Alina_Charaeva"),
                  FirstName = "Alina",
                  LastName = "Charaeva",
                  Gender = Gender.Female,
                  Age = 24,
                  Weight = "130 lbs/(59kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create( "Country_Armenia"),
                  Birthplace = "Moscow, Russia",
                  Rank = 97,
                  Points = 759,
                  TournamentsPlayed = 30
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Hanne_Vandewinkel"),
                  FirstName = "Hanne",
                  LastName = "Vandewinkel",
                  Gender = Gender.Female,
                  Age = 22,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create( "Country_Belgium"),
                  Birthplace = "Lommel, Belgium",
                  Rank = 98,
                  Points = 756,
                  TournamentsPlayed = 28
              },
              new Player
              {
                  Id = DeterministicGuid.Create( "Player_Francesca_Jones"),
                  FirstName = "Francesca",
                  LastName = "Jones",
                  Gender = Gender.Female,
                  Age = 26,
                  Weight = "132 lbs/(60kg)",
                  Height = "5'8\"/(172cm)",
                  CountryId = DeterministicGuid.Create("Country_United Kingdom"),
                  Birthplace = "Leeds, United Kingdom",
                  Rank = 99,
                  Points = 752,
                  TournamentsPlayed = 26
              },
              new Player
              {
                  Id = DeterministicGuid.Create("Player_Fiona_Ferro"),
                  FirstName = "Fiona",
                  LastName = "Ferro",
                  Gender = Gender.Female,
                  Age = 29,
                  Weight = "128 lbs/(58kg)",
                  Height = "5'7\"/(170cm)",
                  CountryId = DeterministicGuid.Create( "Country_France"),
                  Birthplace = "Libreville, Gabon",
                  Rank = 100,
                  Points = 748,
                  TournamentsPlayed = 24
              }
        };
    }
}
