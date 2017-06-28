using System;

namespace WebApi
{
    public class Entity<T> where T : IEquatable<T>
    {
        public T Id { get; set; }
    }
}
