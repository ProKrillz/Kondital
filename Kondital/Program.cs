//double kilo = WriteDouble("Weigt in kilo: ");
//double hvilePuls = WriteDouble("Hvilepuls: ");
//double maxPuls = WriteDouble("Maxpuls: ");

Kondital test = new Kondital(WriteDouble("Weigt in kilo: "), WriteDouble("Hvilepuls: "), WriteDouble("Maxpuls: "));
Console.WriteLine(test.BeregnKondital());

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
    public double BeregnKondital()
    {
        return (_maxPuls/ _hvilePuls) * 15.3;
    }
}






