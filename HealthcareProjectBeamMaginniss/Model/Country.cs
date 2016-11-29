using System.Collections.Generic;

namespace HealthcareProjectBeamMaginniss.Model
{
    public class Country
    {
        #region Properties

        public Dictionary<string, string> CountryDict { get; }

        #endregion

        #region Constructors

        public Country()
        {
            this.CountryDict = new Dictionary<string, string>();
            this.addCountries();
        }

        #endregion

        #region Methods

        public bool Contains(string key)
        {
            return this.CountryDict.ContainsKey(key);
        }

        public string Get(string key)
        {
            return this.CountryDict[key];
        }

        /// <summary>
        ///     I'm so sorry
        /// </summary>
        private void addCountries()
        {
            this.CountryDict.Add("Andorra", "AD");
            this.CountryDict.Add("United Arab Emirates", "AE");
            this.CountryDict.Add("Afghanistan", "AF");
            this.CountryDict.Add("Antigua and Barbuda", "AG");
            this.CountryDict.Add("Albania", "AL");
            this.CountryDict.Add("Armenia", "AM");
            this.CountryDict.Add("Angola", "AO");
            this.CountryDict.Add("Argentina", "AR");
            this.CountryDict.Add("Austria", "AT");
            this.CountryDict.Add("Australia", "AU");
            this.CountryDict.Add("Azerbaijan", "AZ");
            this.CountryDict.Add("Bosnia and Herzegovina", "BA");
            this.CountryDict.Add("Barbados", "BB");
            this.CountryDict.Add("Bangladesh", "BD");
            this.CountryDict.Add("Belgium", "BE");
            this.CountryDict.Add("Burkina Faso", "BF");
            this.CountryDict.Add("Bulgaria", "BG");
            this.CountryDict.Add("Bahrain", "BH");
            this.CountryDict.Add("Burundi", "BI");
            this.CountryDict.Add("Benin", "BJ");
            this.CountryDict.Add("Brunei Darussalam", "BN");
            this.CountryDict.Add("Bolivia (Plurinational State of)", "BO");
            this.CountryDict.Add("Brazil", "BR");
            this.CountryDict.Add("Bahamas", "BS");
            this.CountryDict.Add("Bhutan", "BT");
            this.CountryDict.Add("Botswana", "BW");
            this.CountryDict.Add("Belarus", "BY");
            this.CountryDict.Add("Belize", "BZ");
            this.CountryDict.Add("Canada", "CA");
            this.CountryDict.Add("Democratic Republic of the Congo", "CD");
            this.CountryDict.Add("Central African Republic", "CF");
            this.CountryDict.Add("Congo", "CG");
            this.CountryDict.Add("Switzerland", "CH");
            this.CountryDict.Add("Côte d'Ivoire", "CI");
            this.CountryDict.Add("Chile", "CL");
            this.CountryDict.Add("Cameroon", "CM");
            this.CountryDict.Add("China", "CN");
            this.CountryDict.Add("Colombia", "CO");
            this.CountryDict.Add("Costa Rica", "CR");
            this.CountryDict.Add("Cuba", "CU");
            this.CountryDict.Add("Cape Verde", "CV");
            this.CountryDict.Add("Cyprus", "CY");
            this.CountryDict.Add("Czech Republic", "CZ");
            this.CountryDict.Add("Germany", "DE");
            this.CountryDict.Add("Djibouti", "DJ");
            this.CountryDict.Add("Denmark", "DK");
            this.CountryDict.Add("Dominica", "DM");
            this.CountryDict.Add("Dominican Republic", "DO");
            this.CountryDict.Add("Algeria", "DZ");
            this.CountryDict.Add("Ecuador", "EC");
            this.CountryDict.Add("Estonia", "EE");
            this.CountryDict.Add("Egypt", "EG");
            this.CountryDict.Add("Eritrea", "ER");
            this.CountryDict.Add("Spain", "ES");
            this.CountryDict.Add("Ethiopia", "ET");
            this.CountryDict.Add("Finland", "FI");
            this.CountryDict.Add("Fiji", "FJ");
            this.CountryDict.Add("Micronesia (Federated States of)", "FM");
            this.CountryDict.Add("France", "FR");
            this.CountryDict.Add("Gabon", "GA");
            this.CountryDict.Add("United Kingdom of Great Britain and Northern Ireland", "GB");
            this.CountryDict.Add("Grenada", "GD");
            this.CountryDict.Add("Georgia", "GE");
            this.CountryDict.Add("Ghana", "GH");
            this.CountryDict.Add("Gambia", "GM");
            this.CountryDict.Add("Guinea", "GN");
            this.CountryDict.Add("Equatorial Guinea", "GQ");
            this.CountryDict.Add("Greece", "GR");
            this.CountryDict.Add("Guatemala", "GT");
            this.CountryDict.Add("Guinea-Bissau", "GW");
            this.CountryDict.Add("Guyana", "GY");
            this.CountryDict.Add("Honduras", "HN");
            this.CountryDict.Add("Croatia", "HR");
            this.CountryDict.Add("Haiti", "HT");
            this.CountryDict.Add("Hungary", "HU");
            this.CountryDict.Add("Indonesia", "ID");
            this.CountryDict.Add("Ireland", "IE");
            this.CountryDict.Add("Israel", "IL");
            this.CountryDict.Add("India", "IN");
            this.CountryDict.Add("Iraq", "IQ");
            this.CountryDict.Add("Iran (Islamic Republic of)", "IR");
            this.CountryDict.Add("Iceland", "IS");
            this.CountryDict.Add("Italy", "IT");
            this.CountryDict.Add("Jamaica", "JM");
            this.CountryDict.Add("Jordan", "JO");
            this.CountryDict.Add("Japan", "JP");
            this.CountryDict.Add("Kenya", "KE");
            this.CountryDict.Add("Kyrgyzstan", "KG");
            this.CountryDict.Add("Cambodia", "KH");
            this.CountryDict.Add("Kiribati", "KI");
            this.CountryDict.Add("Comoros", "KM");
            this.CountryDict.Add("Saint Kitts and Nevis", "KN");
            this.CountryDict.Add("Democratic People's Republic of Korea", "KP");
            this.CountryDict.Add("Republic of Korea", "KR");
            this.CountryDict.Add("Kuwait", "KW");
            this.CountryDict.Add("Kazakhstan", "KZ");
            this.CountryDict.Add("Lao People's Democratic Republic", "LA");
            this.CountryDict.Add("Lebanon", "LB");
            this.CountryDict.Add("Saint Lucia", "LC");
            this.CountryDict.Add("Liechtenstein", "LI");
            this.CountryDict.Add("Sri Lanka", "LK");
            this.CountryDict.Add("Liberia", "LR");
            this.CountryDict.Add("Lesotho", "LS");
            this.CountryDict.Add("Lithuania", "LT");
            this.CountryDict.Add("Luxembourg", "LU");
            this.CountryDict.Add("Latvia", "LV");
            this.CountryDict.Add("Libyan Arab Jamahiriya", "LY");
            this.CountryDict.Add("Morocco", "MA");
            this.CountryDict.Add("Monaco", "MC");
            this.CountryDict.Add("Republic of Moldova", "MD");
            this.CountryDict.Add("Montenegro", "ME");
            this.CountryDict.Add("Madagascar", "MG");
            this.CountryDict.Add("Marshall Islands", "MH");
            this.CountryDict.Add("The former Yugoslav Republic of Macedonia", "MK");
            this.CountryDict.Add("Mali", "ML");
            this.CountryDict.Add("Myanmar", "MM");
            this.CountryDict.Add("Mongolia", "MN");
            this.CountryDict.Add("Mauritania", "MR");
            this.CountryDict.Add("Malta", "MT");
            this.CountryDict.Add("Mauritius", "MU");
            this.CountryDict.Add("Maldives", "MV");
            this.CountryDict.Add("Malawi", "MW");
            this.CountryDict.Add("Mexico", "MX");
            this.CountryDict.Add("Malaysia", "MY");
            this.CountryDict.Add("Mozambique", "MZ");
            this.CountryDict.Add("Namibia", "NA");
            this.CountryDict.Add("Niger", "NE");
            this.CountryDict.Add("Nigeria", "NG");
            this.CountryDict.Add("Nicaragua", "NI");
            this.CountryDict.Add("Netherlands", "NL");
            this.CountryDict.Add("Norway", "NO");
            this.CountryDict.Add("Nepal", "NP");
            this.CountryDict.Add("Nauru", "NR");
            this.CountryDict.Add("New Zealand", "NZ");
            this.CountryDict.Add("Oman", "OM");
            this.CountryDict.Add("Panama", "PA");
            this.CountryDict.Add("Peru", "PE");
            this.CountryDict.Add("Papua New Guinea", "PG");
            this.CountryDict.Add("Philippines", "PH");
            this.CountryDict.Add("Pakistan", "PK");
            this.CountryDict.Add("Poland", "PL");
            this.CountryDict.Add("Portugal", "PT");
            this.CountryDict.Add("Palau", "PW");
            this.CountryDict.Add("Paraguay", "PY");
            this.CountryDict.Add("Qatar", "QA");
            this.CountryDict.Add("Romania", "RO");
            this.CountryDict.Add("Serbia", "RS");
            this.CountryDict.Add("Russian Federation", "RU");
            this.CountryDict.Add("Rwanda", "RW");
            this.CountryDict.Add("Saudi Arabia", "SA");
            this.CountryDict.Add("Solomon Islands", "SB");
            this.CountryDict.Add("Seychelles", "SC");
            this.CountryDict.Add("Sudan", "SD");
            this.CountryDict.Add("Sweden", "SE");
            this.CountryDict.Add("Singapore", "SG");
            this.CountryDict.Add("Slovenia", "SI");
            this.CountryDict.Add("Slovakia", "SK");
            this.CountryDict.Add("Sierra Leone", "SL");
            this.CountryDict.Add("San Marino", "SM");
            this.CountryDict.Add("Senegal", "SN");
            this.CountryDict.Add("Somalia", "SO");
            this.CountryDict.Add("Suriname", "SR");
            this.CountryDict.Add("South Sudan", "SS");
            this.CountryDict.Add("Sao Tome and Principe", "ST");
            this.CountryDict.Add("El Salvador", "SV");
            this.CountryDict.Add("Syrian Arab Republic", "SY");
            this.CountryDict.Add("Swaziland", "SZ");
            this.CountryDict.Add("Chad", "TD");
            this.CountryDict.Add("Togo", "TG");
            this.CountryDict.Add("Thailand", "TH");
            this.CountryDict.Add("Tajikistan", "TJ");
            this.CountryDict.Add("Timor-Leste", "TL");
            this.CountryDict.Add("Turkmenistan", "TM");
            this.CountryDict.Add("Tunisia", "TN");
            this.CountryDict.Add("Tonga", "TO");
            this.CountryDict.Add("Turkey", "TR");
            this.CountryDict.Add("Trinidad and Tobago", "TT");
            this.CountryDict.Add("Tuvalu", "TV");
            this.CountryDict.Add("United Republic of Tanzania", "TZ");
            this.CountryDict.Add("Ukraine", "UA");
            this.CountryDict.Add("Uganda", "UG");
            this.CountryDict.Add("United States of America", "US");
            this.CountryDict.Add("Uruguay", "UY");
            this.CountryDict.Add("Uzbekistan", "UZ");
            this.CountryDict.Add("Saint Vincent and the Grenadines", "VC");
            this.CountryDict.Add("Venezuela (Bolivarian Republic of)", "VE");
            this.CountryDict.Add("Viet Nam", "VN");
            this.CountryDict.Add("Vanuatu", "VU");
            this.CountryDict.Add("Samoa", "WS");
            this.CountryDict.Add("Yemen", "YE");
            this.CountryDict.Add("South Africa", "ZA");
            this.CountryDict.Add("Zambia", "ZM");
            this.CountryDict.Add("Zimbabwe", "ZW");
        }

        #endregion
    }
}