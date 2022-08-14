using System;

namespace UnityEngine {
    public static class Vector2Extension {
        public static Vector2 ABS(this Vector2 v, bool absX = true, bool absY = true)
            => new Vector2(absX ? Mathf.Abs(v.x) : v.x, absY ? Mathf.Abs(v.y) : v.y);

        public static Vector2 ABSX(this Vector2 v)
            => ABS(v, absY:false);

        public static Vector2 ABSY(this Vector2 v)
            => ABS(v, absX: false);

        public static Vector2 Invert(this Vector2 v, bool invertX = true, bool invertY = true)
            => new Vector2(invertX ? -v.x : v.x, invertY ? -v.y : v.y);

        public static Vector2 InvertX(this Vector2 v)
            => Invert(v, invertY: false);

        public static Vector2 InvertY(this Vector2 v)
            => Invert(v, invertX: false);

        public static Vector2 Division(this Vector2 A, Vector2 B)
            => new Vector2(A.x / B.x, A.y / B.y);

        public static Vector2 Division(this Vector2 A, float bX, float bY)
            => Division(A, new Vector2(bX, bY));

        public static Vector2 Multiplication(this Vector2 A, Vector2 B)
            => new Vector2(A.x * B.x, A.y * B.y);

        public static Vector2 Multiplication(this Vector2 A, float bX, float bY)
            => Division(A, new Vector2(bX, bY));

        public static Vector2 RemoveNaN(this Vector2 V)
            => new Vector2(float.IsNaN(V.x) ? 0 : V.x, float.IsNaN(V.y) ? 0 : V.y);

        public static Vector2 RemoveInfinity(this Vector2 V)
            => new Vector2(float.IsInfinity(V.x) ? 0 : V.x, float.IsInfinity(V.y) ? 0 : V.y);

        public static Vector2Int ToVector2Int(this Vector2 v)
            => new Vector2Int((int)v.x, (int)v.y);

        /// <summary>Soma todos os eixos.</summary>
        public static float Summation(this Vector2 v)
            => v.x + v.y;
    }
}
