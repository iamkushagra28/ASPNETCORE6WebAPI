using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            //init Dummy Data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "America's Mumbai"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Place where Antman was born"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Famous for MNM"
                }
            };
        }
    }
}
