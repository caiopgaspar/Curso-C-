namespace ExerCompos2.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        //Constru

        public Comment() { }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
