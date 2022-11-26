namespace HelloWorld{



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

}}