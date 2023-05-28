using System;

public class References{

    public List<References> reference = new List<References>();
    private string filename = "scriptures.txt";
    private string key;
    private string book;
    private int chapter;
    private int verse_open;
    private int verse_close;

    public void ReferencesLoad(){
        List<string> read = File.ReadAllLines(filename).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach(string row in read){
            string[] entries = row.Split("|");
            References entry = new References();

            entry.key = entries[0];
            entry.book = entries[1];
            entry.chapter = int.Parse(entries[2]);
            entry.verse_open = int.Parse(entries[3]);
            entry.verse_close = int.Parse(entries[4]);

            reference.Add(entry);
        }
    }

    public string ReferencesGet(Scriptures scripture){
        var index = scripture.index;
        var ref_i = reference[index];
        string ref1;
        if(ref_i.verse_close.Equals(0)){
            ref1 = ($"{ref_i.book} {ref_i.chapter}:{ref_i.verse_open}");
        }else{
            ref1 = ($"{ref_i.book} {ref_i.chapter}:{ref_i.verse_open}-{ref_i.verse_close}");
        }
        return ref1;
    }
}