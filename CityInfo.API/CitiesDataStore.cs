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
                    Description = "America's Mumbai",
                    PointsOfIntrest = new List<PointOfIntrestDto>()
                    {
                        new PointOfIntrestDto()
                        {
                            Id= 1,
                            Name = "Central Park",
                            Description = "Friends"
                        },
                        new PointOfIntrestDto()
                        {
                            Id=2,
                            Name = "Empire State Building",
                            Description = "Sky Scrapper"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Place where Antman was born",
                    PointsOfIntrest = new List<PointOfIntrestDto>()
                    {
                        new PointOfIntrestDto()
                        {
                            Id= 1,
                            Name = "Antwerp Park",
                            Description = "Friends"
                        },
                        new PointOfIntrestDto()
                        {
                            Id=2,
                            Name = "Antwerp State Building",
                            Description = "Sky Scrapper"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Famous for MNM",
                    PointsOfIntrest = new List<PointOfIntrestDto>()
                    {
                        new PointOfIntrestDto()
                        {
                            Id= 1,
                            Name = "Eiffel Tower",
                            Description = "Tower"
                        },
                        new PointOfIntrestDto()
                        {
                            Id=2,
                            Name = "Paris Saint Germain",
                            Description = "Football Team"
                        }
                    }
                }
            };
        }
    }
}
