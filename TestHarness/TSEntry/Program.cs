using LengthUnits;


void Turtles()
{
    var x = InchesReferenceData.InchesCollection;
    foreach ( var item in x)
    {
        Console.WriteLine(item);
    }
}

Turtles();