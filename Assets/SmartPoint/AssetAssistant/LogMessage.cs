using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public class LogMessage
    {
        public const int MaxLogCount = 256;
        public static int lastID;
        public static int nextID;
        public int id;
        public string condition;
        public string stackTrace;
        public LogType type;

        public LogMessage(int id)
        {
            this.id = id;
            lastID = -1;
            nextID = 0;
        }

        public void AdvanceAndSet(string condition, string stackTrace, LogType type)
        {
            lastID = nextID;
            nextID++;
            var n = nextID + (MaxLogCount - 1);
            if (nextID >= 0)
                n = nextID;
            nextID -= (int)(n & 0xFFFFFF00);
            this.condition = condition;
            this.stackTrace = stackTrace;
            this.type = type;
        }
    }
}