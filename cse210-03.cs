namespace HelloWorld{

class parachute {
<<<<<<< HEAD
    private void print_parachute(int guesses_left){
        if (guesses_left <= 0) {
=======
    public void print_parachute(int guesses_left){
        if (guesses_left >= 4) {
>>>>>>> 7134759edee0c509ef3174d68086a0a02f3f6920
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

}

class guess {
    public int guesses = 0;
    char [] guessed = {};
    public int add_guess(int guess) {
        guess += 1;
        return guess;
    }

    public char [] new_letter(char [] letter, char the_guessed_letter){
        letter.Append(the_guessed_letter);
        return letter;
    }

    public bool game_over(int guesses){
        if (guesses > 4) {
            return true;
        }
        else
            return false;
    }

}

class word {
    
    //get random word, seperate into list
    public string random_word() {
        List<string> word_list = new List<string>() {"dog", "cat", "giraffe", "wolf", "turtle", "rabbit"};
        //How many elements in the list
        int elements = word_list.Count;
        Random generator = new Random();
        int random = generator.Next(elements);

        return word_list[random];
    }

    public string the_word = "";
    public char [] separated_word = {};
    



    private char [] seperate(string word){
        char [] array = word.ToCharArray();
        
        return array;
    }
    

    public char[] guess(char guess, char[] word, char[] reveal){
        int count = word.Count();
        char [] discovered = reveal;
        for (int i=0; i < count; i++){
            if (guess == word[i]){
                discovered[i] = word[i];
            }
        }
        reveal = discovered; //Is this possible to do?
        return discovered; //Then we wouldn't need to return discovered but we could check it against the orginal to see if any new letters have been discovered
    }
    //intake guess letter, for loop to run through the string, checking if any of them equal yes
    
    //reveal the numbers

}

class play {
    
}

}