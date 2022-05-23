Kondital test = new Kondital(WriteDouble("Weigt in kilo: "), WriteDouble("Hvilepuls: "), WriteDouble("Maxpuls: "));
Console.WriteLine("Kondital: {0:F2}", test.BeregnKondital());
Console.WriteLine("Kondital: {0:F2}", test.BeregnIltoptagelse());

static double WriteDouble(string text)
{
    double value;
    while (true)
    {
        Console.Write(text);
        try
        {
            return value = Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

class Kondital
{
    double _kilo;
    double _hvilePuls;
    double _maxPuls;
    
    public Kondital(double kilo, double hvilePuls, double maxPuls)
    {
        this._kilo = kilo; 
        this._hvilePuls = hvilePuls;
        this._maxPuls = maxPuls;
    }
    /// <summary>
    /// Metode
    /// </summary>
    /// <returns>Kondital</returns>
    public double BeregnKondital()
    {
        return (_maxPuls/ _hvilePuls) * 15.3;
    }
    /// <summary>
    /// Metode 
    /// </summary>
    /// <returns>Iltoptagelse</returns>
    public double BeregnIltoptagelse()
    {
        return (BeregnKondital() * _kilo) / 1000;
    }
}





