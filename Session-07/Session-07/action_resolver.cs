using System;

namespace Session_07
{
    public class ActionResolver
    {
        // properties
        public MessageLogger Logger { get; set; }

        // constructor
        public ActionResolver()
        {
            Logger = new MessageLogger();
        }

        // methods
        public ActionResponse Execute(ActionRequest request)
        {
            switch (request.Type)
            {
                case ActionType.Write:
                    Logger.Write(request.Message);
                    break;
                case ActionType.Read:
                    Logger.ReadAll();
                    break;
                case ActionType.Clear:
                    Logger.Clear();
                    break;
            }
        }

    }

}