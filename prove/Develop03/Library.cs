class Library{
    List<Scripture> _scriptures = new List<Scripture>();

    public Library(){}

    public void AddScripture(Scripture scripture){
        _scriptures.Add(scripture);
    }

    public string GetMenuText(){
        string menuText = "";
        foreach (Scripture scripture in _scriptures)
        {   
            int index = _scriptures.IndexOf(scripture);
            menuText += $"{index}. {scripture.GetReferenceText()}\r\n";
        }
        return menuText;
    }

    public Scripture SelectScripture(int index = 0, bool random = true){
        if(index > _scriptures.Count - 1){
            throw new Exception("There isn't a scripture that corresponds to the given index");
        }
        Random rand = new Random();
        return random ? _scriptures[rand.Next(0, _scriptures.Count() - 1)] : _scriptures[index];
    }
}