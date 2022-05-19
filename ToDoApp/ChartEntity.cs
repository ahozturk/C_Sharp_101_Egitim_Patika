using System;

namespace ToDo
{
    public class ChartEntity
    {
        public ChartEntity(string title, string content, Persons person, ChartSize size, ChartState state)
        {
            Title = title;
            Content = content;
            Person = person;
            Size = size;
            State = state;
        }

        public ChartEntity(){}

        private string title;
        public string Title { get => title; set => title = value; }

        private string content;
        public string Content { get => content; set => content = value; }

        private Persons person;
        public Persons Person { get => person; set => person = value; }

        private ChartSize size;
        public ChartSize Size { get => size; set => size = value; }

        private ChartState state;
        public ChartState State { get => state; set => state = value; }
    }

    public enum ChartState
    {
        Todo = 1,
        InProgress,
        Done
    }

    public enum ChartSize
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }

    public enum Persons
    {
        Developer = 1,
        Administrator,
        Humen_Resource
    }
}