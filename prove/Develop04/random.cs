using System;

public class RNG{
    private int _generated_number;
    private int _random_end;

    public RNG(){}

    public int RNGGenerate(int _end){
        _random_end = _end;
        var _random_number = new Random();
        _generated_number = _random_number.Next(_random_end);
        return _generated_number;
    } 
}