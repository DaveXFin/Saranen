// Coded along with Jani Järvinen

class Car
{
    // Model,  Make, CurrentSpeed, EngineRunning
    public string Model { get; set; }

    public string Make { get; set; }

    public int CurrentSpeed { get; private set; }

    public bool EngineRunning { get; private set;}

    //methods
    public void StartEngine()
    {
        EngineRunning = true;
    }

    public void Accelerate()
    {
        
        if (!EngineRunning)
        {
            //return;
            throw new Exception("Engine not on, please turn on the engine. Use StartEngine()");
        }
        
        const int MaxSpeed = 200;
        
        CurrentSpeed += 10;

         if (CurrentSpeed >MaxSpeed)
        {
            CurrentSpeed = MaxSpeed;
        }
    }

     public void Decelerate()
    {
        CurrentSpeed -= 10;

        if (CurrentSpeed < 0)
        {
            CurrentSpeed = 0;
        }
    }
}