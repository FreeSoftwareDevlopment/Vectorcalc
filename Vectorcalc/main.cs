using System;

namespace sharkvector
{
    public class Vector2
    {
        public float x;
        public float y;
        public Vector2(float x = 0f, float y = 0f)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Vector3
    {
        public float x;
        public float y;
        public float z;
        public Vector3(float x = 0f, float y = 0f, float z = 0f)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    public static class functionvector
    {
        public static float diffBetween(Vector2 vectora, Vector2 vectorb)
        {
            return (float)Math.Sqrt(Math.Pow((double)(vectorb.x - vectora.x), 2) + Math.Pow((double)(vectorb.y - vectora.y), 2));
        }
    }
}
