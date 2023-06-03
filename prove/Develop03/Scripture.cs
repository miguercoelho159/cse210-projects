using System.Text;
public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string words)
    {
        string[] wordses = words.Split(' ');
        foreach (string word in wordses)
        {
            _words.Add(new Word(word));
        }
        _reference = reference;
    }

    public void Display()
    {
        string otherTempString = _reference.GetReferenceString();
        Console.WriteLine(otherTempString);
        StringBuilder tempString = new StringBuilder("");
        foreach (Word word in _words)
        {
            tempString.Append($"{word.GetWord()} ");
        }
        Console.WriteLine(tempString.ToString());
    }
    public void HideRandomWord()
    {
        var randomGenerator = new Random();
        var randomNumber = randomGenerator.Next(0,_words.Count);

        _words[randomNumber].Hide();
    }

    public bool isAllHidden()
    {
        bool boolHolder = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                boolHolder = word.IsHidden();
            }
        }

        return boolHolder;
    }
}