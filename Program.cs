//string myString = "This is the string";
//string interpolatedString = $"This string is interpolated to say the number {5 + 5}"; // Immutable is replaceable with new values
//myString = interpolatedString; // this will copy the value in interpolated string and replace the original value
//interpolatedString = "New String"; //Creates new address/value and refers to it

//Console.WriteLine(interpolatedString);
//Console.WriteLine(myString);


////mutable
//int numberOne = 5;// address 1
//int numberTwo = 6;// address 2

//numberOne = numberTwo; // Change what is inside the address 2 to be the same as what's in the address 1


//string s1 = "My name is Fred";
//string s2 = "Fred";

//bool compareString = s1.Contains(s2);

//Console.WriteLine(compareString);

//String Method
//1. Replace - Replace a matching character in a string (str.Replace('what to replace', 'which to replace'))
//2. Trim - Trimming unecessary values in a string
//3. Substring - targeting the index of a string name.Substring(index, No.ofChar).
//4. Split - splitting the spaces of a string and writeline
//5. Contains - check if string is in a string
//6. Stringbuilder
//using System.Text;
//StringBuilder builder = new StringBuilder();
//List<int> ints = new List<int>();


//sentinel value
//-1 IndexOf

/* Create a method for Capitalizing the first letter of a sentence
 * Create a method for capitalizing the first letter of every word in the String.
 * Create a method for reversing a string ("hello world" -> "dlrow olleh") using iteration (StringBuilder)
 */

//Create a method for Capitalizing the first letter of a sentence
string myString = "the quick brown fox jumps";
char toUpperString = char.ToUpper(myString[0]);

Console.WriteLine(toUpperString);
Console.WriteLine(toUpperString + myString.Substring(1)); //substring to cast the char

//inClass solution
string testSentences = "The quick brown fox jumped. The lazy dog did not.";
CapitalizeSentenceStarts(testSentences);
string CapitalizeSentenceStarts(string sentences)
{
    string[] sentenceArray = sentences.Split(' ');

    for(int i=0; i < sentenceArray.Length; i++)
    {
        if (sentenceArray[i].Length > 0 )
        {
            string sentence = sentenceArray[i].Trim();
            //get first letter of the array
            char firstLetter = sentence.ToCharArray()[0];
            sentence = sentence.Remove(0, 1);
            sentenceArray[i] = sentenceArray[i].Insert(0, Char.ToUpper(firstLetter).ToString());
            sentenceArray[i] = sentenceArray[i].Insert(sentenceArray[i].Length, ".");

        }

    }

    return String.Join("", sentenceArray);
}



//Create a method for capitalizing the first letter of every word in the String.
bool checkForEmptySpace = myString.Contains(' '); //Always returns a boolean
char emptyChar = ' ';

int index = myString.IndexOf(emptyChar);
Console.WriteLine(index);
// try using ToTitleCase
//ToCharArray put string into array