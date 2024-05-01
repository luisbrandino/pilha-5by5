namespace Pilha
{
    internal class Book
    {
        string title;
        Book? previous = null;

        public Book(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }

        public Book? GetPrevious()
        {
            return this.previous;
        }

        public void SetPrevious(Book? previous)
        {
            this.previous = previous;
        }

        public override string ToString()
        {
            return $"Título: {this.title}";
        }

    }
}