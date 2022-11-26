namespace HelloWorld {

class parachute_game {

public static void Main(){

word word = new word();

word.the_word = word.random_word();

//Console.Write(word.the_word);

Console.Write("Guess a letter");

string guess = Console.ReadLine();

Console.Write(guess);


parachute parachute = new parachute();

int guesses_left = -1;
while(guesses_left <= 4){


Console.WriteLine();
parachute.print_parachute(guesses_left);
guesses_left+=1;

}


}

}

}