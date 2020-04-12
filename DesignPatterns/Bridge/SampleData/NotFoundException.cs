namespace Bridge.SampleData
{
    using System;
    public class NotFoundException : Exception
    {
        #nullable enable
        public NotFoundException(string? message) : base (message) {}
    }
}