public class DataProcessor
{
    public List<string> func1(List<object> items)
    {
        var output = new List<string>();
        foreach (var item in items)
        {
            if (item.GetType() == typeof(string))
            {
                output.Add(
                item.ToString().ToUpper());
            }
        }
        return output;
    }
}
