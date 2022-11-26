namespace HelloWorld{

class parachute {

    public void print_parachute(int guesses_left, bool game_over){
        if (guesses_left <= 0) {
         Console.WriteLine("   ___   ");}
        if (guesses_left <= 1) 
        {Console.WriteLine("  /___\\ ");}
        if (guesses_left <= 2) 
        {Console.WriteLine("  \\   /");}
        if (guesses_left <= 3) 
        {Console.WriteLine("   \\ /   ");}
        if (game_over == true){
        Console.WriteLine("    O  ");}
        else if (game_over == false){
        Console.WriteLine("    x  ");
        }
         Console.WriteLine("   /|\\   ");
         Console.WriteLine("   / \\   ");
    }   

}}