using System;
using System.Collections.Generic;
using System.IO;

public class SaveLoad
{
    public List<string> _toSave = new List<string>();
    public List<string> _loaded = new List<string>();



    public void LoadFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file does not exist");
            return;
        }

        List<string> lines = new List<string>(File.ReadAllLines(fileName));
        foreach (string i in lines)
        {
            _loaded.Add(i);
        }
        Console.WriteLine("File loaded");
    }

    
    public void SaveFile(string fileToSave)
    {
        string save = fileToSave;
        File.AppendAllLines(save, _toSave);

        Console.WriteLine("File saved");
    }




}