namespace HelloWorld {

class parachute_game {

public static void Main(){

word word = new word();

word.the_word = word.random_word();

Console.Write(word.the_word);

int guesses_left = 4;
parachute parachute = new parachute();

Console.WriteLine();
parachute.print_parachute(guesses_left);



}

}

}