using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SmartPoint.Mathematics
{
    public static class Vector3Ext
    {
        public static Vector3 FastClear(this ref Vector3 self)
        {
            return Vector3.zero;
        }

        public static Vector3 FastNegate(this ref Vector3 self)
        {
            return -self;
        }

        public static Vector3 FastReciprocal(this ref Vector3 self)
        {
            self.x = 1f / self.x;
            self.y = 1f / self.y;
            self.z = 1f / self.z;
            return self;
        }

        public static Vector3 FastSet(this ref Vector3 self, float s)
        {
            return new Vector3(s, s, s);
        }

        public static Vector3 FastSet(this ref Vector3 self, float x, float y, float z)
        {
            return new Vector3(x, y, z);
        }

        public static Vector3 FastAdd(this ref Vector3 self, [In] ref Vector3 V)
        {
            return self + V;
        }

        public static Vector3 FastScale(this ref Vector3 self, float s)
        {
            return self * s;
        }

        public static Vector3 FastMul(this ref Vector3 self, [In] ref Vector3 V)
        {
            self.x *= V.x;
            self.y *= V.y;
            self.z *= V.z;
            return self;
        }

        public static Vector3 FastScaleAdd(this ref Vector3 self, [In] ref Vector3 V, float s)
        {
            self.x += V.x * s;
            self.y += V.y * s;
            self.z += V.z * s;
            return self;
        }

        public static Vector3 FastLerp(this ref Vector3 self, [In] ref Vector3 V, float s)
        {
            self.x += (V.x - self.x) * s;
            self.y += (V.y - self.y) * s;
            self.z += (V.z - self.z) * s;
            return self;
        }

        public static float FastLengthSq(this ref Vector3 self)
        {
            return (self.x * self.x) + (self.y * self.y) + (self.z * self.z);
        }

        public static float FastDistanceSq(this ref Vector3 self, [In] ref Vector3 V)
        {
            var dx = self.x - V.x;
            var dy = self.y - V.y;
            var dz = self.z - V.z;
            return dx * dx + dy * dy + dz * dz;
        }

        public static float FastLength(this ref Vector3 self)
        {
            return (float)Math.Sqrt((self.x * self.x) + (self.y * self.y) + (self.z * self.z));
        }

        public static float FastDot(this ref Vector3 self, [In] ref Vector3 V)
        {
            return (self.x * V.x) + (self.y * V.y) + (self.z * V.z);
        }

        public static Vector3 FastCross(this ref Vector3 self, [In] ref Vector3 V)
        {
            var x = (self.y * V.z) - (self.z * V.y);
            var y = (self.z * V.x) - (V.z * self.x);
            var z = (V.y * self.x) - (self.y * V.x);
            self.x = x;
            self.y = y;
            self.z = z;
            return self;
        }

        public static Vector3 FastCrossNormalize(this ref Vector3 self, [In] ref Vector3 V)
        {
            var x = (V.y * self.z) - (self.y * V.z);
            var y = (self.z * V.x) - (self.x * V.z);
            var z = (self.x * V.y) - (self.y * V.x);
            float f = 1f / (float)Math.Sqrt((x * x) + (y * y) + (z * z));
            self.x = x * f;
            self.y = y * f;
            self.z = z * f;
            return self;
        }

        public static float FastNormalize(this ref Vector3 self)
        {
            float magnitudeSq = (self.x * self.x) + (self.y * self.y) + (self.z * self.z);
            float magnitude = (float)Math.Sqrt(magnitudeSq);
            if (magnitude >= 0.00001)
            {
                self.x /= magnitude;
                self.y /= magnitude;
                self.z /= magnitude;
            }
            else
            {
                self = Vector3.zero;
            }
            return magnitude;
        }

        public static Vector3 FastRotateX(this ref Vector3 self, float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            float newY = (self.y * cos) - (self.z * sin);
            float newZ = (self.y * sin) + (self.z * cos);
            self.y = newY;
            self.z = newZ;
            return self;
        }

        public static Vector3 FastRotateY(this ref Vector3 self, float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            float newX = (self.x * cos) + (self.z * sin);
            float newZ = (self.z * cos) - (self.x * sin);
            self.x = newX;
            self.z = newZ;
            return self;
        }

        public static Vector3 FastRotateZ(this ref Vector3 self, float angle)
        {
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            float newX = (self.y * sin) + (self.x * cos);
            float newY = (self.y * cos) - (self.x * sin);
            self.x = newX;
            self.y = newY;
            return self;
        }
    }
}
