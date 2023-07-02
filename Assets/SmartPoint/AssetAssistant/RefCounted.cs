namespace SmartPoint.AssetAssistant
{
    public class RefCounted
    {
        public int referencedCount;

        public RefCounted()
        {
            referencedCount = 1;
        }

        public virtual int AddRef() => referencedCount++;

        public virtual int Release() => referencedCount--;
    }
}