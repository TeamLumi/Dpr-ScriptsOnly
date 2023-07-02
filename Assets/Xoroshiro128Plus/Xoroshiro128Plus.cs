using UnityEngine;

namespace Xoroshiro128Plus
{
    public class Xoroshiro128Plus : MonoBehaviour
    {
        public ulong state0;
        public ulong state1;

        public bool Initialized => this.state0 != default || this.state1 != default;

        public Xoroshiro128Plus(int seed)
        {
            const int min = int.MinValue;
            const int max = int.MaxValue;

            var random = new System.Random(seed);
            this.state0 = (ulong)random.Next(min, max) << 32 | (uint)random.Next(min, max);
            this.state1 = (ulong)random.Next(min, max) << 32 | (uint)random.Next(min, max);
        }

        public Xoroshiro128Plus(ulong state0, ulong state1)
        {
            this.state0 = state0;
            this.state1 = state1;
        }

        public long NextLong()
        {
            var s0 = this.state0;
            var s1 = this.state1 ^ s0;

            this.state0 = (s0 << 55 | s0 >> 64 - 55) ^ s1 ^ s1 << 14;
            this.state1 = (s1 << 36 | s1 >> 64 - 36);

            return (long)(this.state0 + this.state1);
        }

        public int NextInt()
        {
            var value = (ulong)this.NextLong();
            return (int)(value ^ value >> 32);
        }

        public float NextFloat()
        {
            // This will return a float between 0 and 1
            return (float)(this.NextLong() / (double)long.MaxValue);
        }

        public double NextDouble()
        {
            // This will return a double between 0 and 1
            return this.NextLong() / (double)long.MaxValue;
        }
    }
}
