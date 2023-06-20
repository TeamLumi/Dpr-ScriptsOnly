using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SmartPoint.Mathematics
{
    public class FastMath
    {
        public static Quaternion RotationAxis(ref Vector3 V, float angle)
        {
            float f = 1f / (float)Math.Sqrt((V.x * V.x) + (V.y * V.y) + (V.z * V.z));
            float x = V.x * f;
            float y = V.y * f;
            float z = V.z * f;
            float a = (float)Math.Sin(0.5 * angle);
            return new Quaternion(x * a, y * a, z * a, (float)Math.Cos(0.5 * angle));
        }

        public static Quaternion RotateZLocal(ref Quaternion Q, float Angle)
        {
            float x = (Q.x * (float)Math.Cos(Angle)) + (Q.y * (float)Math.Sin(Angle));
            float y = (Q.y * (float)Math.Cos(Angle)) - (Q.x * (float)Math.Sin(Angle));
            float z = (Q.w * (float)Math.Sin(Angle)) + (Q.z * (float)Math.Cos(Angle));
            float w = (Q.w * (float)Math.Cos(Angle)) - (Q.z * (float)Math.Sin(Angle));
            return new Quaternion(x, y, z, w);
        }

        public static Vector3 GetForwardVector(ref Quaternion Q) => new Vector3();

        public static Vector3 GetUpVector(ref Quaternion Q) => new Vector3();

        public static Vector3 GetRightVector(ref Quaternion Q) => new Vector3();

        public static Quaternion LookRotation(ref Vector3 forward) => new Quaternion();

        public static Quaternion LookRotation(ref Vector3 forward, ref Vector3 up) => new Quaternion();

        public static float Dot(ref Vector2 V1, ref Vector2 V2) => new float();

        public static float IntersectLine(ref Vector2 P1, ref Vector2 V1, ref Vector2 P2, ref Vector2 V2)
        {
            return new float();
        }

        public static float Dot(ref Vector3 V1, ref Vector3 V2) => new float();

        public static Vector3 Cross(ref Vector3 V1, ref Vector3 V2) => new Vector3();

        public static Vector3 Normalize(ref Vector3 V) => new Vector3();

        public static Vector3 CrossNormalize(ref Vector3 V1, ref Vector3 V2) => new Vector3();

        public static Vector3 CalculateFaceNormal(ref Vector3 V1, ref Vector3 V2, ref Vector3 V3)
        {
            return new Vector3();
        }

        public static Vector3 CalculateCentroid(ref Vector3 V1, ref Vector3 V2, ref Vector3 V3) => new Vector3();

        public static Matrix4x4 Reflection(float a, float b, float c, float d) => new Matrix4x4();

        public FastMath()
        {
        }
    }
}
