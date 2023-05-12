using CityInfo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities/{cityId}/pointsofinterest")]
    [ApiController]
    public class PointsOfInterest : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfIntrestDto>> GetPointsOfInterest(int cityID)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityID);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.PointsOfIntrest);
        }
        [HttpGet("{pointofinterestid}")]
        public ActionResult<PointOfIntrestDto> GetPointOfInterest(int cityID, int pointofinterestid)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityID);
            if (city == null)
            {
                return NotFound();
            }
            // find point of interest
            var pointofInterest = city.PointsOfIntrest.FirstOrDefault(c=> c.Id == pointofinterestid);
            if (pointofInterest == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfIntrest.ElementAt(pointofinterestid));
        }
    }
}
