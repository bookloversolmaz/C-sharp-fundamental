namespace CSharp.InstanceFields;

class Post {
// This class has two fields both hold strings
string content;
string author;
// constructor
  Post(string content, string author) {
    this.content = content;
    this.author = author;
  }

}
Post weather = new Post("The weather today is great", "Serena");
Post holiday = new Post("Just about to head off to the Solomon Islands!", "Kevwe");
