using System;

namespace Session_07
    public class MessageLogger
{
    public Message[] Messages { get; set; }

    public MessageLogger()
    {
        Messages = new Message[0];
    }

    public void ReadAll()
    {
        foreach (var message in Messages)
        {
            Console.WriteLine(message);
        }
    }

    public void Clear()
    {
        Messages = new Message[0];
    }

    public void Write(Message message)
    {
        var temp = new Message[Messages.Length + 1];
        Array.Copy(Messages, temp, Messages.Length);
        temp[Messages.Length] = message;
        Messages = temp;
    }
}



