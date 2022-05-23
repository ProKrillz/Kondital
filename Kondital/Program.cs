double kilo = WriteDouble("Weigt in kilo: ");
double hvilePuls = WriteDouble("Hvilepuls: ");
double maxPuls = WriteDouble("Maxpuls: ");

static double WriteDouble(string text)
{
    double kilo;
    while (true)
    {
        Console.Write(text);
        try
        {
            return kilo = Convert.ToDouble(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}






