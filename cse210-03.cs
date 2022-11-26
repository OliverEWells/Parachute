namespace HelloWorld{





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

    private char [] hidden(char [] word){
        char [] hidden = {};
        foreach (char letter in word){
            hidden.Append('-');
        }
        return hidden;
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