
internal class Program
{class Node<T>
    {
        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node <T> Next
        {
            get;set; 
        }
        public Node()
        {
        }
        public Node(T data)
        {
            this.data = data;
            Next = null;
        }
    }
    class List<T>
    {
        Node<T> first;
        Node<T> last;
        int count;
        public List()
        {
                
        }
        public List(T item)
        {
            Node<T>temb=new Node<T>(item);
            Add_First(temb);
        }
        public List(Node<T>temb)
        {
            
            Add_First(temb);
        }
        public bool IsEmty()
        {
            if (first == null)
            {
                Console.WriteLine("The list is emty");
                return true;
            }
            return false;
        }
        public void Add_First(T item)
        {
            if (IsEmty())
            {
                Node<T> temb = new Node<T>(item);
                first = temb;
                last = temb;
                Console.WriteLine("Add successfull at first");
                count++;
                return;
            }
            Node<T> Temb = new Node<T>(item);
            Temb.Next = first;
            first = Temb;
            Console.WriteLine("Add successfull at first");
            count++;
        }
        public void Add_First(Node<T> temb)
        {
            if (IsEmty())
            {
                first = temb;
                last = temb;
                Console.WriteLine("Add successfull at first");
                count++;
                return;
            }

            temb.Next = first;
            first = temb;
            Console.WriteLine("Add successfull at first");
            count++;

        }
        public void Add_Last(T item)
        {
            if (IsEmty())
            {
                Add_First(item);
                return;
            }
            
            Node<T> temb = new Node<T>(item);
            last.Next = temb;
            last = temb;
            Console.WriteLine("Add successfull at last");
            count++;
        }
        public void Add_Last(Node<T> temb)
        {
            if (IsEmty())
            {
                Add_First(temb);
                return;
            }
            last.Next = temb;
            last = temb;
            Console.WriteLine("Add successfull at last");
            count++;
        }
        public void Add_index(T item, int index)
        {
            if (IsEmty()||index<=0)
            {
                Console.WriteLine("rong index you item add in first");
                Add_First(item);
                return;
            }
            if (index>count)
            {
                Console.WriteLine("your index is greater then list length your item add in last");
                Add_Last(item);
                return;
            }
            Node<T> temb = new Node<T>(item);
            index = index - 1;
            Node<T> move = first;
            int c = 1;
            while (c != index)
            {
                move = move.Next;
                c++;
            }
            temb.Next = move.Next;
            move.Next = temb;
            Console.WriteLine("add successfull in index " + (index+1));
            count++;

        }
        public void Add_index(Node<T>temb, int index)
        {
            if (IsEmty() || index <= 0)
            {
                Console.WriteLine("rong index you item add in first");
                Add_First(temb);
                return;
            }
            if (index > count)
            {
                Console.WriteLine("your index is biger then last length your item add in last");
                Add_Last(temb);
                return;
            }
            
            index = index - 1;
            Node<T> move = first;
            int c = 1;
            while (c != index)
            {
                move = move.Next;
                c++;
            }
            temb.Next = move.Next;
            move.Next = temb;
            Console.WriteLine("add successfull in index " + (index+1));
            count++;
        }
        public void Delet_first()
        {

            if (IsEmty())
            {
                
                return;
            }
            first = first.Next;
            Console.WriteLine("the delet complate");
            count--;
        }
        public void Delet_last()
        {
            if (IsEmty())
            {

                
                return;
            }
            Node<T> move = first;
            while (move.Next!=last)
            {
                move = move.Next;
            }
            move.Next = null;
            Console.WriteLine("the delet complate");
            count--;

        }
        public void Getlengthg() { Console.WriteLine("the length of list "+count); }
        public void print()
        {
            Node<T>move = first;
            while (move!=null)
            {
                Console.WriteLine($"the data {move.Data}");
                move = move.Next;
            }
            Console.WriteLine(  );


        }
    }
    private static void Main(string[] args)
    {
        List<int>list = new List<int>();
        list.Add_First(2);
        list.Add_First(1);
        list.Add_Last(3);
        list.Add_index(33, 2);
        list.Add_index(44, 8);
        list.Add_index(55, -1);
        list.Getlengthg();
        Console.WriteLine("____________");
        list.print();
        Console.WriteLine("____________");
        list.Delet_first();
        list.Delet_last();
        Console.WriteLine("_____________");
        list.print();
        Console.WriteLine("_____________");
        list.Getlengthg();
       
    }
}