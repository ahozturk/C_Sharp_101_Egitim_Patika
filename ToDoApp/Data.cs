using System;

namespace ToDo
{
    public class Data : IData
    {
        public static List<ChartEntity> list;
        public Data()
        {
            
        }

        static Data()
        {
            list = new List<ChartEntity>();
            
            list.Add(new ChartEntity("ToDo uygulaması", "Yapın artık", Persons.Humen_Resource, ChartSize.M, ChartState.InProgress));
            list.Add(new ChartEntity("Medium", "Yaz şunu", Persons.Developer, ChartSize.S, ChartState.Todo));
            //list.Add(new ChartEntity("Lise", "Bittttiii", Persons.Administrator, ChartSize.XL, ChartState.Done));
            //list.Add(new ChartEntity("Bilgisayar aldım", "Yeni", Persons.Developer, ChartSize.L, ChartState.Done));
        }

        public void Add(ChartEntity p)
        {
            list.Add(p);
        }

        public void Remove(ChartEntity p)
        {
            list.Remove(p);
        }

        public void Update(ChartEntity p, int index)
        {
            list[index] = p;
        }

        public List<ChartEntity> List()
        {
            return list;
        }
    }
}