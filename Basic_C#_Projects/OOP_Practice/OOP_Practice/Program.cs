﻿

var internationalPizzaDay23 = new DateTime(2023, 2, 9);

Console.WriteLine("year is " + internationalPizzaDay23.Year);
Console.WriteLine("month is " + internationalPizzaDay23.Month);
Console.WriteLine("day is " + internationalPizzaDay23.Day);
Console.WriteLine("day of the week is " + internationalPizzaDay23.DayOfWeek);

var internationalPizzaDay24 = internationalPizzaDay23.AddYears(1);

Console.WriteLine("year is " + internationalPizzaDay24.Year);
Console.WriteLine("month is " + internationalPizzaDay24.Month);
Console.WriteLine("day is " + internationalPizzaDay24.Day);
Console.WriteLine("day of the week is " + internationalPizzaDay24.DayOfWeek);


Console.ReadKey();
