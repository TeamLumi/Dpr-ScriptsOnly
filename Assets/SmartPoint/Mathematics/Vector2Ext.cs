using System.Runtime.InteropServices;
using UnityEngine;

namespace SmartPoint.Mathematics
{
    public static class Vector2Ext
    {
        public static float FastLengthSq(this ref Vector2 self)
        {
            return (self.x * self.x) + (self.y * self.y);
        }

        public static float FastCross(this ref Vector2 self, [In] ref Vector2 V)
        {
            return (self.x * V.y) - (self.y * V.x);
        }
    }
}
