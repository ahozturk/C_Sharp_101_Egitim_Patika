using System;

namespace ToDo
{
    interface IData
    {
        public void Add(ChartEntity p);
        public void Update(ChartEntity p, int index);
        public void Remove(ChartEntity p);
        public List<ChartEntity> List();
    }

}