using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingExchange.BL
{
    class Cities
    {
        public List<string> GetCitiesOfCountry(string country)
        {
            switch (country)
            {
                case "Iraq":
                    return new List<string> { "Baghdad", "Mosul", "Basra", "Kirkuk", "Najaf", "Kala", "Ramadi", "Fallujah", "Erbil", "Sulaymaniyah" };
                case "Jordan":
                    return new List<string> { "Amman", "Zarqa", "Irbid", "Russeifa", "Al-Quwaysimah", "Aqaba", "Madaba", "Jerash", "Tafilah", "Ma'an" };
                case "Kuwait":
                    return new List<string> { "Kuwait City", "Al Ahmadi", "Hawalli", "Farwaniya", "Sabah Al-S", "Salwa", "Al Jahra", "Mubarak Al-Kabeer", "Al-Fintas", "Janub as Surrah" };
                case "Lebanon":
                    return new List<string> { "Beirut", "Tripoli", "Sidon", "Tyre", "Nabatieh", "Jounieh", "Zahle", "Baalbek", "Byb", "Batroun" };
                case "Oman":
                    return new List<string> { "Muscat", "Salalah", "Sohar", "Nizwa", "Sur", "Bahla", "Ibri", "Rustaq", "Al Buraimi", "Khasab" };
                case"Palestine":
                    return new List<string> { "East Jerusalem", "Gaza City", "Hebron", "Nablus", "Ramallah", "Bethlehem", "Jenin", "Tulkarm ","Qqilya", "Jericho" };
                case "Qatar":
                    return new List<string> { "Doha", "Al Rayyan", "Umm Salal", "Al Wakrah", "Al Khor", "Ash Shahaniyah", "Dukhan", "Al Wukayr", "Al Ghuwayriyah", "Al Jumayliyah" };
                case "Saudi Arabia":
                    return new List<string> { "Riyadh", "Jeddah", "Mecca", "Medina", "Dam", "Taif", "Tabuk", "Buraidah", "Khamis Mushait", "Al Hufuf" };
                case "Syria":
                    return new List<string> { "Damascus", "Aleppo", "H", "Latak", "Hama", "Deir ez-Zor", "Raqqa", "Idlib", "Daraa", "As-Suwayda" };
                case "UAE":
                    return new List<string> { "Abu Dhabi", "Dubai", "Sharjah", "Al Ain", "Ajman", "Ras Al Khaimah", "Fujairah", "Umm Al Quwain", "Khor Fakkan", "Dibba Al-Fujairah" };
                case "Yemen":
                    return new List<string> { "Sana'a", "Aden", "Taiz", "Al Hudaydah", "Ibb", "Dhamar", "Al-Mukalla" ,"Zinjibar", "Sayun", "Sadah" };
                case "Bahrain":
                    return new List<string> { "Manama", "Marraq", "Riffa", "Hamad Town", "Isa Town", "Jidhafs", "Al-Maliki", "Sitra", "Budaiya", "Al Hidd" };
                case "Egypt":
                    return new List<string> { "Cairo", "Alexandria", "Giza", "Shubra El-Kheima", "Port Said", "Suez", "Luxor", "Mansoura", "Tanta", "Asyut" };
        default:
            return new List<string>();
            }
        }

    }
}
