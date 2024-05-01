namespace Pilha
{
    internal class Stack
    {
        Book? top = null;

        public bool IsEmpty()
        {
            return this.top == null;
        }

        public void Insert(Book node)
        {
            if (this.IsEmpty())
            {
                this.top = node;
                return;
            }

            node.SetPrevious(this.top);
            this.top = node;
        }

        public Book? Unstack() {
            if (this.IsEmpty())
                return null;

            Book? node = this.top;

            this.top = this.top?.GetPrevious();

            return node;
        }

        public void Search(string title)
        {
            if (this.IsEmpty())
                return;

            Book? current = this.top;

            bool bookExists = false;

            while (current != null)
            {
                if (current.GetTitle().ToLower() == title.ToLower())
                {
                    Console.WriteLine($"Livro encontrado: {current.GetTitle()}");
                    bookExists = true;
                }

                current = current.GetPrevious();
            }

            if (!bookExists)
                Console.WriteLine("Livro não encontrado!");
        }

        public int Count()
        {
            int count = 0;

            Book? current = this.top;

            while (current != null)
            {
                count++;
                current = current.GetPrevious();
            }

            return count;
        }

        public void Display()
        {
            Book? current = this.top;

            while (current != null)
            {
                Console.WriteLine(current);
                current = current.GetPrevious();
            }
        }
    }
}
