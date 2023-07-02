using UnityEngine;

namespace Xoroshiro128Plus
{
    public class Xoroshiro128PlusRNG
    {
        private Xoroshiro128Plus xoroshiro;

        public Xoroshiro128Plus Internal => xoroshiro;

        public int Next()
        {
            return xoroshiro.NextInt();
        }

        public Xoroshiro128PlusRNG(int seed)
        {
            xoroshiro = new Xoroshiro128Plus(seed);
        }

        public Xoroshiro128PlusRNG(ulong state0, ulong state1)
        {
            xoroshiro = new Xoroshiro128Plus(state0, state1);
        }

        public Xoroshiro128PlusRNG(Xoroshiro128Plus other)
        {
            xoroshiro = other;
        }

        public int Next(int maxValue)
        {
            return Mathf.Abs(xoroshiro.NextInt()) % maxValue;
        }

        public int Next(int minValue, int maxValue)
        {
            return minValue + Mathf.Abs(xoroshiro.NextInt()) % (maxValue - minValue);
        }

        public void NextBytes(byte[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = (byte)xoroshiro.NextInt();
        }

        public double NextDouble()
        {
            return xoroshiro.NextDouble();
        }

        protected float Sample()
        {
            return xoroshiro.NextFloat();
        }
    }
}
