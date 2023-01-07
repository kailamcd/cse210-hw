int x = 17;
Console.Writeline(x);
Console.Writeline("Well, that's it!");
Console.Write("No newline, what's your favorite color? ");
user_fave_color = Console.Readline();
Console.Writeline(user_fave_color);
if (user_fave_color == "pink")
{
    Console.Writeline("Mine, too!");
}
else
{
    Console.Write($"{user_fave_color} isn't my favorite, but I do like it!");
}