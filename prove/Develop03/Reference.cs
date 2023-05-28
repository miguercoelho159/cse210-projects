public class Reference
{
    string _book;
    int _verse1;
    int _verse2;
    int _chapter;
    
    public Reference(string book, int verse1, int verse2, int chapter)
    {
        _book = book;
        _verse1 = verse1;
        _verse2 = verse2;
        _chapter = chapter;    
    }    
    public Reference(string book, int verse1, int chapter)
    {
        _book = book;
        _verse1 = verse1;
        _chapter = chapter;
        _verse2 = -1;
    }

    public string GetReferenceString()
    {
        if (_verse2 == -1)
        {
            return $"{_book} {_chapter}:{_verse1}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse1}-{_verse2}";
        }
    }
}