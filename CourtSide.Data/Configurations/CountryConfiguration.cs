namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using CourtSide.Data.Models;
    using CourtSide.Data.Seeding;

    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(DefaultCountries);
        }

        public static IEnumerable<Country> DefaultCountries =>
             new List<Country>
             {
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Afghanistan"),
                      Name = "Afghanistan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Albania"),
                      Name = "Albania"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Algeria"),
                      Name = "Algeria"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Andorra"),
                      Name = "Andorra"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Angola"),
                      Name = "Angola"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Antigua and Barbuda"),
                      Name = "Antigua and Barbuda"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Argentina"),
                      Name = "Argentina"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Armenia"),
                      Name = "Armenia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Australia"),
                      Name = "Australia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Austria"),
                      Name = "Austria"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Azerbaijan"),
                      Name = "Azerbaijan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Bahamas"),
                      Name = "Bahamas"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Bahrain"),
                      Name = "Bahrain"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Bangladesh"),
                      Name = "Bangladesh"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Barbados"),
                      Name = "Barbados"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Belarus"),
                      Name = "Belarus"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Belgium"),
                      Name = "Belgium"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Belize"),
                      Name = "Belize"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Benin"),
                      Name = "Benin"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Bhutan"),
                      Name = "Bhutan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Bolivia"),
                      Name = "Bolivia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Bosnia and Herzegovina"),
                      Name = "Bosnia and Herzegovina"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Botswana"),
                      Name = "Botswana"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Brazil"),
                      Name = "Brazil"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Brunei"),
                      Name = "Brunei"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Bulgaria"),
                      Name = "Bulgaria"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Burkina Faso"),
                      Name = "Burkina Faso"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Burundi"),
                      Name = "Burundi"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Cabo Verde"),
                      Name = "Cabo Verde"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Cambodia"),
                      Name = "Cambodia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Cameroon"),
                      Name = "Cameroon"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Canada"),
                      Name = "Canada"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Central African Republic"),
                      Name = "Central African Republic"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Chad"),
                      Name = "Chad"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Chile"),
                      Name = "Chile"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_China"),
                      Name = "China"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Colombia"),
                      Name = "Colombia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Comoros"),
                      Name = "Comoros"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Congo (Brazzaville)"),
                      Name = "Congo (Brazzaville)"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Costa Rica"),
                      Name = "Costa Rica"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Côte d'Ivoire"),
                      Name = "Côte d'Ivoire"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Croatia"),
                      Name = "Croatia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Cuba"),
                      Name = "Cuba"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Cyprus"),
                      Name = "Cyprus"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Czech Republic"),
                      Name = "Czech Republic"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Democratic Republic of the Congo"),
                      Name = "Democratic Republic of the Congo"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Denmark"),
                      Name = "Denmark"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Djibouti"),
                      Name = "Djibouti"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Dominica"),
                      Name = "Dominica"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Dominican Republic"),
                      Name = "Dominican Republic"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Ecuador"),
                      Name = "Ecuador"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Egypt"),
                      Name = "Egypt"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_El Salvador"),
                      Name = "El Salvador"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Equatorial Guinea"),
                      Name = "Equatorial Guinea"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Eritrea"),
                      Name = "Eritrea"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Estonia"),
                      Name = "Estonia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Eswatini"),
                      Name = "Eswatini"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Ethiopia"),
                      Name = "Ethiopia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Fiji"),
                      Name = "Fiji"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Finland"),
                      Name = "Finland"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_France"),
                      Name = "France"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Gabon"),
                      Name = "Gabon"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Gambia"),
                      Name = "Gambia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Georgia"),
                      Name = "Georgia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Germany"),
                      Name = "Germany"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Ghana"),
                      Name = "Ghana"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Greece"),
                      Name = "Greece"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Grenada"),
                      Name = "Grenada"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Guatemala"),
                      Name = "Guatemala"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Guinea"),
                      Name = "Guinea"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Guinea-Bissau"),
                      Name = "Guinea-Bissau"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Guyana"),
                      Name = "Guyana"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Haiti"),
                      Name = "Haiti"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Holy See"),
                      Name = "Holy See"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Honduras"),
                      Name = "Honduras"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Hungary"),
                      Name = "Hungary"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Iceland"),
                      Name = "Iceland"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_India"),
                      Name = "India"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Indonesia"),
                      Name = "Indonesia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Iran"),
                      Name = "Iran"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Iraq"),
                      Name = "Iraq"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Ireland"),
                      Name = "Ireland"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Israel"),
                      Name = "Israel"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Italy"),
                      Name = "Italy"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Jamaica"),
                      Name = "Jamaica"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Japan"),
                      Name = "Japan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Jordan"),
                      Name = "Jordan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Kazakhstan"),
                      Name = "Kazakhstan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Kenya"),
                      Name = "Kenya"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Kiribati"),
                      Name = "Kiribati"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Kuwait"),
                      Name = "Kuwait"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Kyrgyzstan"),
                      Name = "Kyrgyzstan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Laos"),
                      Name = "Laos"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Latvia"),
                      Name = "Latvia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Lebanon"),
                      Name = "Lebanon"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Lesotho"),
                      Name = "Lesotho"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Liberia"),
                      Name = "Liberia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Libya"),
                      Name = "Libya"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Liechtenstein"),
                      Name = "Liechtenstein"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Lithuania"),
                      Name = "Lithuania"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Luxembourg"),
                      Name = "Luxembourg"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Madagascar"),
                      Name = "Madagascar"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Malawi"),
                      Name = "Malawi"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Malaysia"),
                      Name = "Malaysia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Maldives"),
                      Name = "Maldives"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Mali"),
                      Name = "Mali"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Malta"),
                      Name = "Malta"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Marshall Islands"),
                      Name = "Marshall Islands"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Mauritania"),
                      Name = "Mauritania"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Mauritius"),
                      Name = "Mauritius"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Mexico"),
                      Name = "Mexico"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Micronesia"),
                      Name = "Micronesia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Moldova"),
                      Name = "Moldova"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Monaco"),
                      Name = "Monaco"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Mongolia"),
                      Name = "Mongolia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Montenegro"),
                      Name = "Montenegro"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Morocco"),
                      Name = "Morocco"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Mozambique"),
                      Name = "Mozambique"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Myanmar (Burma)"),
                      Name = "Myanmar (Burma)"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Namibia"),
                      Name = "Namibia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Nauru"),
                      Name = "Nauru"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Nepal"),
                      Name = "Nepal"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Netherlands"),
                      Name = "Netherlands"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_New Zealand"),
                      Name = "New Zealand"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Nicaragua"),
                      Name = "Nicaragua"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Niger"),
                      Name = "Niger"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Nigeria"),
                      Name = "Nigeria"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_North Korea"),
                      Name = "North Korea"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_North Macedonia"),
                      Name = "North Macedonia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Norway"),
                      Name = "Norway"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Oman"),
                      Name = "Oman"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Pakistan"),
                      Name = "Pakistan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Palau"),
                      Name = "Palau"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Palestine State"),
                      Name = "Palestine State"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Panama"),
                      Name = "Panama"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Papua New Guinea"),
                      Name = "Papua New Guinea"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Paraguay"),
                      Name = "Paraguay"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Peru"),
                      Name = "Peru"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Philippines"),
                      Name = "Philippines"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Poland"),
                      Name = "Poland"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Portugal"),
                      Name = "Portugal"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Qatar"),
                      Name = "Qatar"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Romania"),
                      Name = "Romania"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Russia"),
                      Name = "Russia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Rwanda"),
                      Name = "Rwanda"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Saint Kitts and Nevis"),
                      Name = "Saint Kitts and Nevis"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Saint Lucia"),
                      Name = "Saint Lucia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Saint Vincent and the Grenadines"),
                      Name = "Saint Vincent and the Grenadines"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Samoa"),
                      Name = "Samoa"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_San Marino"),
                      Name = "San Marino"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Sao Tome and Principe"),
                      Name = "Sao Tome and Principe"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Saudi Arabia"),
                      Name = "Saudi Arabia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Senegal"),
                      Name = "Senegal"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Serbia"),
                      Name = "Serbia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Seychelles"),
                      Name = "Seychelles"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Sierra Leone"),
                      Name = "Sierra Leone"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Singapore"),
                      Name = "Singapore"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Slovakia"),
                      Name = "Slovakia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Slovenia"),
                      Name = "Slovenia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Solomon Islands"),
                      Name = "Solomon Islands"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Somalia"),
                      Name = "Somalia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_South Africa"),
                      Name = "South Africa"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_South Korea"),
                      Name = "South Korea"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_South Sudan"),
                      Name = "South Sudan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Spain"),
                      Name = "Spain"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Sri Lanka"),
                      Name = "Sri Lanka"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Sudan"),
                      Name = "Sudan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Suriname"),
                      Name = "Suriname"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Sweden"),
                      Name = "Sweden"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Switzerland"),
                      Name = "Switzerland"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Syria"),
                      Name = "Syria"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Tajikistan"),
                      Name = "Tajikistan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Tanzania"),
                      Name = "Tanzania"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Thailand"),
                      Name = "Thailand"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Timor-Leste"),
                      Name = "Timor-Leste"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Togo"),
                      Name = "Togo"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Tonga"),
                      Name = "Tonga"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Trinidad and Tobago"),
                      Name = "Trinidad and Tobago"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Tunisia"),
                      Name = "Tunisia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Turkey"),
                      Name = "Turkey"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Turkmenistan"),
                      Name = "Turkmenistan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Tuvalu"),
                      Name = "Tuvalu"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Uganda"),
                      Name = "Uganda"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Ukraine"),
                      Name = "Ukraine"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_United Arab Emirates"),
                      Name = "United Arab Emirates"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_United Kingdom"),
                      Name = "United Kingdom"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_United States of America"),
                      Name = "United States of America"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Uruguay"),
                      Name = "Uruguay"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Uzbekistan"),
                      Name = "Uzbekistan"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Vanuatu"),
                      Name = "Vanuatu"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Venezuela"),
                      Name = "Venezuela"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Vietnam"),
                      Name = "Vietnam"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Yemen"),
                      Name = "Yemen"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Zambia"),
                      Name = "Zambia"
                  },
                  new Country
                  {
                      Id = DeterministicGuid.Create("Country_Zimbabwe"),
                      Name = "Zimbabwe"
                  }
             };
    }
}