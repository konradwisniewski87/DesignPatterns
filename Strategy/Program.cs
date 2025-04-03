using Strategy;
using Strategy.RouteStrategy;

Console.WriteLine("-------------------------------------------------------------------");
Map map = new Map(new WalkStrategy());
map.CreateRoute(new Coordinate { Longitude = 1, Latitude = 1 }, new Coordinate { Longitude = 2, Latitude = 2});


Console.WriteLine("-------------------------------------------------------------------");