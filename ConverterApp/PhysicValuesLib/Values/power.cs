namespace PhysicValuesLib.Values;

public class Power : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Мощность";

    //<summary>
    //Тут названия величин, используемых в конвертаторе
    //</summary>
    //<returns></returns>

    private List<string> _measureList = new List<string>()
    {
        "Лошадиная сила",
        "Мегаватт",
        "Киловатт",
        "Ватт"
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
            case "Ватт":
                break;
            case "Киловатт":
                Value *= 0.001;
                break;
            case "Мегаватт":
                Value *= 0.000001;
                break;
            case "Лошадиная сила":
                Value *= 0.001341022089595;
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
            case "Ватт":
                break;
            case "Киловатт":
                Value /= 0.001;
                break;
            case "Мегаватт":
                Value /= 0.000001;
                break;
            case "Лошадиная сила":
                Value /= 0.001341022089595;
                break;
        }
    }

    public string GetValueName()
    {
        return _valueName;
    }
}
