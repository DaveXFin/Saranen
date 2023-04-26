

Car myCar = new();
myCar.Make = "Mercedes";
myCar.Model = "E200";
//myCar.CurrentSpeed = 55;
//myCar.EngineRunning = true;
myCar.StartEngine();
myCar.Accelerate();
myCar.Decelerate();

Console.WriteLine("Car Make: "+ myCar.Make);
Console.WriteLine("Car Model: "+ myCar.Model);
Console.WriteLine("Current Speed: " + myCar.CurrentSpeed);
Console.WriteLine("Car Engine: "+ myCar.EngineRunning);

