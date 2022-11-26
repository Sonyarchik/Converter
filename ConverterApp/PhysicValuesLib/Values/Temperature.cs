namespace PhysicValuesLib.Values;

public class Temperature : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Температура";

    //<summary>
    //Тут названия величин, используемых в конвертаторе
    //</summary>
    //<returns></returns>

    private List<string> _measureList = new List<string>()
    {
        "Градусы Цельсия",
        "Градусы Ранкена",
        "Градусы Фаренгейта"
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
            case "Градусы Ранкена":
                break;
            case "Градусы Цельсия":
                Value -= 491.67;
                break;
            case "Градусы Фаренгейта":
                Value -= 255.37;
                break;
        }
    }

    /// <summary>
    /// Метод переводит в систему СИ
    /// </summary>
    public void ToSi()
    {
        switch (From)
        {
            case "Градусы Ранкена":
                break;
            case "Градусы Цельсия":
                Value += 491.67;
                break;
            case "Градусы Фаренгейта":
                Value += 255.37;
                break;
        }
    }

    public string GetValueName()
    {
        return _valueName;
    }
}
