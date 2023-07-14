using UnityEngine;

public static class GFL
{
    // Both of these are stubs in the actuall code
    public static void ASSERT(bool condition)
    {
        if (!condition)
        {
            Logger.Log("Assertion failed");
        }
    }

    public static void ASSERT(bool condition, string format)
    {
        if (!condition)
        {
            Logger.Log($"Assertion failed: {format}");
        }
    }
}
