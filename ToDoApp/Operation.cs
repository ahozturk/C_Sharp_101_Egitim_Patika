using System;

namespace ToDo
{
    class Operation : IOperations
    {
        static Data data;
        public Operation()
        {
            data = new Data();         
        }

        public bool Add()
        {
            ChartEntity chart = new();
            chart.Title = Input.InputString("Enter title");
            chart.Content = Input.InputString("Enter content");
            int inputSize = Input.InputInt("Enter size (XS(1) - S(2) - M(3) - L(4) - XL(5))", 1, 5);
            chart.Size = inputSize == -1 ? ChartSize.XS : (ChartSize)inputSize;
            int inputState = Input.InputInt("Enter state (Todo(1) - In Progress(2) - Done(3))", 1, 3);
            chart.State = inputState == -1 ? ChartState.Todo : (ChartState)inputState;
            int inputPerson = Input.InputInt("Enter person (Developer(1) - Administrator(2) - Humer_Resources(3))", 1, 3);
            chart.Person = inputPerson == -1 ? Persons.Administrator : (Persons)inputPerson;
            data.Add(chart);
            return true;
        }

        public bool Remove()
        {
            string input = Input.InputString("Enter chart name to delete");
            int index = ContainsName(input);
            if(index == -1)
                return false;
            data.Remove(data.List()[index]);
            return true;
        }

        public bool Move()
        {
            string input = Input.InputString("Enter chart name to move");
            int inputState = Input.InputInt("Enter state (Todo(1) - In Progress(2) - Done(3))", 1, 3);
            if(inputState == -1) return false;
            int index = ContainsName(input);
            if(index == -1)
                return false;
            ChartEntity updated = data.List()[index];
            updated.State = (ChartState)inputState;
            data.Update(updated, index);
            return false;
        }

        static int ContainsName(string input)
        {
            List<ChartEntity> list = data.List();
            foreach(var i in list)
            {
                if(i.Title.ToLower() == input.ToLower())
                {
                    
                    return list.IndexOf(i);
                }
            }
            return -1;
        }

        public bool List()
        {
            Console.WriteLine("---");
            string todo = "";
            string inprog = "";
            string done = "";
            foreach (var item in data.List())
            {
                string print = $"Title\t: {item.Title}\nContent\t: {item.Content}\nPerson\t: {item.Person}\nSize\t: {item.Size}\n\n";
                if(item.State == ChartState.Todo)
                    todo += print;
                if(item.State == ChartState.InProgress)
                    inprog += print;
                if(item.State == ChartState.Done)
                    done += print;
            }
            Console.WriteLine("---------------\nTo Do: ");
            Console.WriteLine(todo);
            Console.WriteLine("---------------\nIn Progress: ");
            Console.WriteLine(inprog);
            Console.WriteLine("---------------\nDone: ");
            Console.WriteLine(done);
            return true;
        }
    }
}