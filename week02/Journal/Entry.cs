using System;


public class Entry
{
    public SaveLoad readList = new SaveLoad();
    public List<string> copySave;
        
    public SaveLoad copyLoad = new SaveLoad();
    

    public Entry ()
    {
        copySave = new List<string>(readList._toSave);
    }
    public void WriteOption()
    {
        Prompts prompts = new Prompts();
        prompts.GetRandomPrompt();

        Console.Write("Write something: ");
        string answer = Console.ReadLine();

        string dateTime = DateTime.Now.ToString("dd/MM/yyyy HH : mm");
        answer = $"{dateTime}, {answer}";
        copySave.Add(answer);

    }

    public void Display()
    {
        if (copySave.Count > 0)
        {
            foreach (string i in copySave)
            {
                Console.WriteLine(i);
            }
        }
        if (copyLoad._loaded.Count > 0)
        {
            foreach (string i in copyLoad._loaded)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}