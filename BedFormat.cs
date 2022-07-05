// See https://aka.ms/new-console-template for more information


using System.Runtime.Serialization;

[Serializable]
internal class BedFormat : Exception
{
    public BedFormat()
    {
    }

    public BedFormat(string? message) : base(message)
    {
    }

    public BedFormat(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected BedFormat(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public void ToManyOrNotEnoughElements()
    {
        Console.WriteLine("Ooops sembra che questo array non sia della dimensione giusta!");
    }
}