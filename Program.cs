

public class Program {
    
    public static void Main() {
        
        double faren = 95;
        double cel;
        
        ConvertTemperature(in faren, out cel);
        
        Console.WriteLine(cel);
        
    }
    
    static void ConvertTemperature(in double farenheight, out double celsius) {
        
        celsius = (farenheight - 32) / 1.8;
    }
    
}
