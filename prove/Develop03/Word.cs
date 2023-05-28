using System.Text;

public class Word
{

    private bool _hidden;
    private string _text;
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetWord()
    {

        if (_hidden == true)
        {
            StringBuilder tempString = new StringBuilder("");
            
            for (int i = 0; i<_text.Length; i++)
            {
            tempString.Append("-");
            }
            return tempString.ToString();
        }
        else
        {
        return _text;
        }    
    
    }
}

//