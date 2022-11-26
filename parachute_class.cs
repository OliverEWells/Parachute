namespace HelloWorld{

class parachute {

    public void print_parachute(int guesses_left){
        if (guesses_left <= 0) {
         Console.WriteLine("   ___   ");}
        if (guesses_left <= 1) 
        {Console.WriteLine("  /___\\ ");}
        if (guesses_left <= 2) 
        {Console.WriteLine("  \\   /");}
        if (guesses_left <= 3) 
        {Console.WriteLine("   \\ /   ");}
         Console.WriteLine("    O  ");
         Console.WriteLine("   /|\\   ");
         Console.WriteLine("   / \\   ");
    }   

}}