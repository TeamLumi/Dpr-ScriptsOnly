using System;

namespace SmartPoint.AssetAssistant
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AssetAssistantInitializeMethodAttribute : Attribute
    {
        public int order;
        public AssetAssistantInitializeMethodAttribute(int order = 0)
        {
            this.order = order;
        }
    }
}