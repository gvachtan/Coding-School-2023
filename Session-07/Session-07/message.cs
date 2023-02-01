using System;

namespace Session_07
    public class Message
{
    public Guid ID { get; set; }
    public DateTime TimeStamp { get; set; }
    public string Message { get; set; }

    public Message(Guid id, DateTime timeStamp, string message)
    {
        ID = id;
        TimeStamp = timeStamp;
        Message = message;
    }
}

