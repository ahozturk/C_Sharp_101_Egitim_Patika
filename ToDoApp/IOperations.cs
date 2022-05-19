using System;

namespace ToDo
{
    interface IOperations
    {
        bool Add();
        bool Move();
        bool Remove();
        bool List();
    }

}