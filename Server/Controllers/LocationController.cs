global using DynamicSpeedControl.Shared.Models;

namespace DynamicSpeedControl.Server.Controllers
{
    
    public class LocationController : BaseController
    {
        // a property that is a list of all restricted areas in the database
        public List<RestrictedAreaEntity> RestrictedAreas { get; set; }

        public LocationController(DataContext dataContext) : base(dataContext)
        {
            // get all restricted areas from the database
            RestrictedAreas = _dataContext.RestrictedAreas.ToList();
        }  

        [HttpPost]
        public ActionResult<RestrictedAreaEntity> CheckLocation(Coordinate currentLocation) 
            => Ok(_dataContext.RestrictedAreas.FirstOrDefault(restrictedArea 
                => restrictedArea.IsInArea(currentLocation)));

    }
}
