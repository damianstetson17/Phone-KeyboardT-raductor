using System;
using Phone.Exceptions;

namespace Phone.Controllers
{
    /*  
        The TextController class
        This class contains all necessary methods for process a text input
    */
    public class TextController
    {
        /*
            This method return a string of numerical coordinates from a word
        */
        public string getNumberSecuence(string word){
            string resultCoord ="";
            if(word.Length > 0)
            {
                foreach (char letter in word)
                {
                    //if its the first input
                    if(resultCoord.Length == 0){
                        resultCoord += getLetterNumber(letter);
                    }else{
                        //getting the next number coords
                        string nextNumbers = getLetterNumber(letter);
                        //it if the last number in input is equal to the first new one
                        if(resultCoord[resultCoord.Length-1] == nextNumbers[0])
                        {
                            resultCoord += " " + nextNumbers;
                        }else{
                            resultCoord += nextNumbers;
                        }
                    }  
                }
            }else{
                throw new EmptyWordException ("Empty word recibed");
            }
            return (resultCoord);
        }

        /*
            This method return a string of numerica coordinate from a char
        */
        public string getLetterNumber(char OneLetter){
            OneLetter = Char.ToLower(OneLetter);
            int lettersInButtonLimit = 3;
            int MaybeIsNextButton = 1;
            char charOffset;
            char charLimit;
            string charCoord ="";
            int button = 2;

            if(OneLetter != ' ')
            {   
                //if the letter is on button 7 or 8 or 9 button
                if(OneLetter > 'o')
                {
                    charOffset = 'p';
                    //if the letter is on button 7
                    if(OneLetter <'t')
                    {
                        charOffset = 'p'; 
                        charLimit = 's';
                        button = 7;
                        lettersInButtonLimit = 4 ;  
                    }else{
                        //if the letter is on button 8 
                        if(OneLetter < 'w')
                        {
                            charOffset = 't'; 
                            charLimit = 'v';
                            button = 8;
                            lettersInButtonLimit = 3 ;
                        }else{
                            //the letter is on button 9
                            charOffset = 'w';
                            charLimit = 'z';
                            button = 9;
                            lettersInButtonLimit = 4 ; 
                        }
                    }
                }else{
                    charOffset = 'a';
                    charLimit = 'o';
                    lettersInButtonLimit = 3 ;
                }
                //if its not a 'space' letter
                for (char l = charOffset; l <= charLimit; l++)
                {
                    //if its not the letter... 
                    if(OneLetter != l)
                    {
                        //if we go over three letters, we must continue through the next botton and count again...
                        if(MaybeIsNextButton >= lettersInButtonLimit)
                        {
                            button++;
                            MaybeIsNextButton = 1;
                        }else{
                            MaybeIsNextButton++;
                        }
                    //if its the letter!!
                    }else{
                        charCoord = button.ToString();
                        //add the necessary repetitions in button for get the letter
                        for (int i = 1; i < MaybeIsNextButton; i++)
                        {
                            charCoord += button.ToString();
                        }
                        break;
                    }
                }
            }else{
                charCoord = "0";
            }
            return (charCoord);
        }
    }
}