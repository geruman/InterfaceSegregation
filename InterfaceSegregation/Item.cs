namespace InterfaceSegregation
{
    public class Item
    {
        public int Id { get; private set; }
        public string Content { get; set; }
        public Item(int id, string content)
        {
            Id = id;
            Content = content;
        }
        public override string ToString()
        {
            return "item " + Id + " //" + Content;
        }
    }
}