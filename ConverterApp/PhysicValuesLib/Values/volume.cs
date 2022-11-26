namespace PhysicValuesLib.Values;

public class Volume : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Объем";

    //<summary>
    //Тут названия величин, используемых в конвертаторе
    //</summary>
    //<returns></returns>

    private List<string> _measureList = new List<string>()
    {
        "Литры",
        "Миллилитры",
        "Кубические метры",
        "Кубические сантиметры" //я вообще не знала, что такие величины существуют хаха треш.
                                //Нет, ну, знала, но не настолько же. Я вообще конвертатор в обьем стакана видела
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
            case "Кубические метры":
                break;
            case "Литры":
                Value *= 1000;
                break;
            case "Миллилитры":
                Value *= 1000000;
                break;
            case "Кубические сантиметры":
                Value *= 1000000;
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
            case "Кубические метры":
                break;
            case "Литры":
                Value /= 1000;
                break;
            case "Миллилитры":
                Value /= 1000000;
                break;
            case "Кубические сантиметры":
                Value /= 1000000;
                break;
        }
    }

    public string GetValueName()
    {
        return _valueName;
    }
}
