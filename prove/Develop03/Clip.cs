using System;

public class Clip{
    public string words = "";
    public string reference = "";
    public string[] results;
    public List<int> hidden;
    public int catch_i = 0;

    public Clip(){}

    public void GetScripture(Scriptures scripture){
        words = scripture.scripture_text;
        results = words.Split(" ");
        hidden = new List<int>();
    }
    

    public string ClipScripture(string in_ref){
        reference = in_ref;
        List<string> clipped = new List<string>();
        catch_i = 0;
        ClipWord();
        for(var i = 0; i < results.Length; i++){
            var str = results[i];
            int len = str.Length;
            string blanked = new String('_', len);
            if(hidden.Contains(i)){
                clipped.Add($"{blanked} ");
            }else{
                clipped.Add($"{str} ");
            }
        }
        var clip_scrip = string.Join("", clipped.ToArray());
        return clip_scrip;
    }

    public void ClipWord(){
        var index1 = ClipIndex();
        var index2 = ClipIndex();
        if(hidden.Contains(index1) || hidden.Contains(index2)){
            catch_i += 1;
            if(catch_i < results.Length + 50){
                ClipWord();
            }
        }else{
            hidden.Add(index1);
            hidden.Add(index2);
        }
    }    

    public int ClipIndex(){
        var random = new Random();
        var index = random.Next(results.Length);
        return index;
    }
}