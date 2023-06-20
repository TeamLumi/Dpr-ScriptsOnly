using System;
using UnityEngine;

namespace SmartPoint.Mathematics
{
    public static class QuaternionExt
    {
        public static Quaternion FastNormalizeAxis(this ref Quaternion self)
        {
            var f = 1f / (float)Math.Sqrt((self.x * self.x) + (self.y * self.y) + (self.z * self.z));
            self.x *= f;
            self.y *= f;
            self.z *= f;
            return self;
        }

        public static Quaternion FastNormalize(this ref Quaternion self)
        {
            var f = 1f / (float)Math.Sqrt((self.x * self.x) + (self.y * self.y) + (self.z * self.z) + (self.w * self.w));
            self.x *= f;
            self.y *= f;
            self.z *= f;
            self.w *= f;
            return self;
        }

        public static Quaternion FastRotateY(this ref Quaternion self, float angle)
        {
            var c = (float)Math.Cos(0.5 * angle);
            var s = (float)Math.Sin(0.5 * angle);
            var x = self.x;
            var w = self.w;
            self.x = (x * c) + (self.z * s);
            self.y = (x * self.y) + (w * s);
            self.z = (self.z * c) - (x * s);
            self.w = (w * c) - (w * s);
            return self;
        }

        public static Quaternion FastRotationArc(this ref Quaternion self, Vector3 V1, Vector3 V2)
        {
            return new Quaternion();
        }
    }
}
