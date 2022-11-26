namespace PhysicValuesLib.Values;

public class RussianValue : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "(Старо) Русская система измерения";

    //<summary>
    //Тут названия величин, используемых в конвертаторе
    //</summary>
    //<returns></returns>

    private List<string> _measureList = new List<string>()
    {
        "Аршин",
        "Локоть",
        "Ладонь",
        "Фут"
    };

    /// <summary>
    /// Метод возвращает конвертированное значение
    /// </summary>
    /// <returns></returns>
    public double GetConvertedValue(double value, string from, string to)
    {
        Value = value;
        From = from;
        To = to;

        ToSi();
        ToRequired();
        return Value;
    }

    /// <summary>
    /// Метод возвращает список единиц измерения
    /// </summary>
    /// <returns></returns>
    public List<string> GetMeasureList()
    {
        return _measureList;
    }

    /// <summary>
    /// Метод конвертирует в нужные единицы измерения
    /// </summary>
    public void ToRequired()
    {
        switch (To)
        {
            case "Аршин":
                break;
            case "Локоть":
                Value *= 0.6222222222222;
                break;
            case "Ладонь":
                Value *= 9.333333333333;
                break;
            case "Фут":
                Value *= 2.333333333333;
                break;
        }
    }

    /// <summary>
    /// Метод переводит в нужную систему измеренмя
    /// </summary>
    public void ToSi()
    {
        switch (From)
        {
            case "Аршин":
                break;
            case "Локоть":
                Value /= 0.6222222222222;
                break;
            case "Ладонь":
                Value /= 9.333333333333;
                break;
            case "Фут":
                Value /= 2.333333333333;
                break;
        }
    }

    public string GetValueName()
    {
        return _valueName;
    }
}
