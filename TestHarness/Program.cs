using LengthUnits;


void Turtles()
{
    var x = InchesReferenceData.InchesCollection;
    var y = LengthUnitAliases.ImperialUnitMap;
    foreach ( var item in x)
    {
        if (y.TryGetValue(item, out LengthUnit value))
        Console.WriteLine(value);
    }
}

Turtles();