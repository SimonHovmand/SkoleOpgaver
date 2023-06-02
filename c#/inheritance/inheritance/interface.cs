interface IEngine
{
    double CalculateHP();
}

interface IElectricEngine : IEngine
{
    double LoadingCapacity();
}

interface ICompostionEngine : IEngine
{
    double MaxNPM();
    double CalculateCarbonOxide();
}

class test : IElectricEngine
{
    public double CalculateHP() { return 201; }
    public double LoadingCapacity() { return 798; }
}