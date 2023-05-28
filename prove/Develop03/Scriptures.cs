using System;

public class Scriptures{

    public List<Scriptures> scripture = new List<Scriptures>();
    private string filename = "scriptures.txt";
    private string key;
    private string text;
    public int index;
    public string scripture_text;

    public void ScripturesLoad(){
        List<string> read = File.ReadAllLines(filename).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach(string row in read){
            string[] entries = row.Split("|");
            Scriptures entry = new Scriptures();

            entry.key = entries[0];
            entry.text = entries[5];

            scripture.Add(entry);
        }
    }

    public string ScripturesRandom(){
        index = RandomIndex();
        scripture_text = scripture[index].text;
        return scripture_text;
    }

    public int RandomIndex(){
        var random = new Random();
        index = random.Next(scripture.Count);
        return index;
    }
}