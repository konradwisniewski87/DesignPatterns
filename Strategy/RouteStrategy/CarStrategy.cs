﻿namespace Strategy.RouteStrategy;

internal class CarStrategy : IRouteStrategy
{
    public void CreateRoute(Coordinate start, Coordinate end)
    {
        Console.WriteLine("Car strategy");
    }
}
