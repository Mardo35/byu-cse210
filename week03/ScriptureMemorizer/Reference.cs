public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; 
    }

    // Constructor for a range of verses (Overloading)
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        // Formats to account for "Proverbs 3:5" or "Proverbs 3:5-6"
        string verseStr = (_verse == _endVerse) ? $"{_verse}" : $"{_verse}-{_endVerse}";
        return $"{_book} {_chapter}:{verseStr}";
    }
}