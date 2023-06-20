namespace SmartPoint.Mathematics
{
    public static class FloatExt
    {
        public static float NormalizeRadians(this ref float self)
        {
            var f = 0.5f;
            if (self < 0f)
            {
                f = -0.5f;
            }
            self += ((self * 0.15915f + f) * -6.2832f);
            return self;
        }

        public static float NormalizeDegrees(this ref float self)
        {
            var f = 0.5f;
            if (self < 0f)
            {
                f = -0.5f;
            }
            self += ((self * 0.0027778f + f) * -360.0f);
            return self;
        }

        public static float LerpDegrees(float a1, float a2, float s)
        {
            float diff = a2 - a1;
            var f = 0.5f;
            if (diff < 0f)
            {
                f = -0.5f;
            }
            return (diff + ((diff * 0.0027778f + f) * -360.0f)) * s + a1;
        }
    }
}
