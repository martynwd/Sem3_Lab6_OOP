using System;

namespace Lab6.BasicClasses
{
    public abstract class ChainOfResponsibility<T>
    {
        public ChainOfResponsibility<T> Next { get; set; }

        public ChainOfResponsibility<T> SetNext(ChainOfResponsibility<T> next)
        {
            Next = next;
            return Next;
        }

        public virtual T Handle(ref T request)
        {
            return Next != null ? Next.Handle(ref request) : default;
        }
    }
}