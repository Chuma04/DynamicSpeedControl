namespace DynamicSpeedControl.Shared.Models
{
    public class RestrictedAreaEntity : BaseEntity
    {
        public List<Coordinate> Perimeter { get; set; } = new();
        public int SpeedLimit { get; set; }

        // Method to check if the current location is in the restricted area
        public bool IsInArea(Coordinate currentLocation)
        {
            // get all coordinates of the restricted area
            Coordinate[] areaCoordinates = this.Perimeter.ToArray();

            bool inside = false;
            int j = areaCoordinates.Length - 1; // index of the last vertex

            for (int i = 0; i < areaCoordinates.Length; j = i++) // loop through all vertices of the HomeCoordinates
            {
                // check if the point is on an horizontal edge of the areaCoordinates
                if (areaCoordinates[i].Longitude == currentLocation.Longitude && areaCoordinates[j].Longitude == currentLocation.Longitude &&
                    (areaCoordinates[i].Latitude >= currentLocation.Latitude) != (areaCoordinates[j].Latitude >= currentLocation.Latitude))
                    return true;
                // check if the edge intersects with the ray
                if ((areaCoordinates[i].Longitude > currentLocation.Longitude) 
                    != (areaCoordinates[j].Longitude > currentLocation.Longitude) 
                    && currentLocation.Latitude < (areaCoordinates[j].Latitude
                        - areaCoordinates[i].Latitude) * (currentLocation.Longitude
                        - areaCoordinates[i].Longitude) / (areaCoordinates[j].Longitude
                        - areaCoordinates[i].Longitude) + areaCoordinates[i].Latitude)
                    inside = !inside; // toggle state
            }
            return inside;
        }
    }
}
