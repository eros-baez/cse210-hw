public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public Entry(string prompt, string text)
    {
        _date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        _prompt = prompt;
        _text = text;
    }

    public string GetDisplay()
    {
        return $"{_date} - {_prompt}\n{_text}";
    }
}