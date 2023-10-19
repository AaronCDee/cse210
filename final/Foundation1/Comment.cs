class Comment {
    string _name;
    string _commentText;
    public Comment(string name, string commentText){
        _name = name;
        _commentText = commentText;
    }

    public void Display(){
        Console.WriteLine($"{_name} commented, '{_commentText}'");
    }
}