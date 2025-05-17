using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }

    public Entry(string prompt, string response, string mood)
    {
        Date = DateTime.Now.ToShortDateString();
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public string GetDisplayText()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nMood: {Mood}\n";
    }

    public string ToCsv()
    {
        return $"\"{Date}\",\"{Prompt.Replace("\"", "\"\"")}\",\"{Response.Replace("\"", "\"\"")}\",\"{Mood.Replace("\"", "\"\"")}\"";
    }

    public static Entry FromCsv(string line)
    {
        string[] parts = line.Split("\",\"");
        if (parts.Length != 4)
        {
            throw new FormatException("Invalid CSV format");
        }

        string date = parts[0].Trim('"');
        string prompt = parts[1];
        string response = parts[2];
        string mood = parts[3].TrimEnd('"');

        Entry entry = new Entry(prompt, response, mood);
        entry.Date = date;
        return entry;
    }
}
