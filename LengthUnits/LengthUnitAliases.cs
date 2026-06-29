
namespace LengthUnits
{
    public class LengthUnitAliases
    {
        public static readonly Dictionary<string, LengthUnit> ImperialUnitMap = new()
        {
            ["in"] = LengthUnit.Inch,
            ["in."] = LengthUnit.Inch,
            ["inch"] = LengthUnit.Inch,
            ["inches"] = LengthUnit.Inch,
            ["\""] = LengthUnit.Inch,

            ["ft"] = LengthUnit.Feet,
            ["ft."] = LengthUnit.Feet,
            ["foot"] = LengthUnit.Feet,
            ["feet"] = LengthUnit.Feet,
            ["'"] = LengthUnit.Feet,
        };

        public static readonly Dictionary<string, LengthUnit> MetricUnitMap = new()
        {
            ["mm"] = LengthUnit.Millimeter,
            ["mm."] = LengthUnit.Millimeter,
            ["millimeter"] = LengthUnit.Millimeter,
            ["millimeters"] = LengthUnit.Millimeter,

            ["cm"] = LengthUnit.Centimeter,
            ["cm."] = LengthUnit.Centimeter,
            ["centimeter"] = LengthUnit.Centimeter,
            ["centimeters"] = LengthUnit.Centimeter,
        };
    }
}
