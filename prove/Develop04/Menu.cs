public class Menu
{
    private string _option1;
    private string _option2;
    private string _option3;
    // private string _menuChoice;

    public Menu(string option1, string option2, string option3) {
        _option1 = option1;
        _option2 = option2;
        _option3 = option3;
    }

    public void DisplayMenu(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine($"  1. {_option1}");
        Console.WriteLine($"  2. {_option2}");
        Console.WriteLine($"  3. {_option3}");
        Console.WriteLine("  4. Quit");
    }
}