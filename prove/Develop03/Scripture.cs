class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){
        _reference = reference;
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide){
        Random rand = new Random();
        List<Word> shownWords = _words.Where(word => !word.IsHidden()).ToList();
        List<Word> shuffledWords = shownWords.OrderBy(word => rand.Next()).ToList();
        List<Word> randomWordsToHide = shuffledWords.Take(numberToHide).ToList();
        foreach(Word word in randomWordsToHide){
            word.Hide();
        }
    }

    public string GetDisplayText(){
        List<string> wordTextList = new List<string>();
        
        foreach (Word word in _words)
        {
            wordTextList.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}\r\n" + String.Join(" ", wordTextList);
    }

    public string GetReferenceText(){
        return _reference.GetDisplayText();
    }

    public bool IsCompletelyHidden(){
        return _words.TrueForAll(word => word.IsHidden());
    }
}