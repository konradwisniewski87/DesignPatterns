﻿using Strategy.RouteStrategy;

namespace Strategy;

internal class Map
{
    private IRouteStrategy _routeStrategy;
    public Map(IRouteStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        _routeStrategy.CreateRoute(start, end);
    }
}
