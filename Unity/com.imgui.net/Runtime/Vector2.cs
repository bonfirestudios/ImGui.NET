using System;

namespace ImGuiNET
{
    public struct Vector2 : IEquatable<Vector2>
    {
        public static Vector2 One = new Vector2(1.0f, 1.0f);
        public static Vector2 Zero = new Vector2(0.0f, 0.0f);
        public static Vector2 UnitX = new Vector2(1.0f, 0.0f);
        public static Vector2 UnitY = new Vector2(0.0f, 1.0f);
        
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
        
        public float X;
        public float Y;

        public bool Equals(Vector2 other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is Vector2 other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return !left.Equals(right);
        }
    }
}