using System;

namespace UnityEngine {
    public static class Vector2Int_CB_UE_Extension {
        public static Vector2Int ABS(this Vector2Int v, bool absX = true, bool absY = true)
            => new Vector2Int(absX ? Mathf.Abs(v.x) : v.x, absY ? Mathf.Abs(v.y) : v.y);

        public static Vector2Int ABSX(this Vector2Int v)
            => ABS(v, absY: false);

        public static Vector2Int ABSY(this Vector2Int v)
            => ABS(v, absX: false);

        public static Vector2Int Invert(this Vector2Int v, bool invertX = true, bool invertY = true)
            => new Vector2Int(invertX ? -v.x : v.x, invertY ? -v.y : v.y);

        public static Vector2Int InvertX(this Vector2Int v)
            => Invert(v, invertY: false);

        public static Vector2Int InvertY(this Vector2Int v)
            => Invert(v, invertX: false);

        public static Vector2Int Division(this Vector2Int A, Vector2Int B)
            => new Vector2Int(A.x / B.x, A.y / B.y);

        public static Vector2Int Division(this Vector2Int A, int bX, int bY)
            => Division(A, new Vector2Int(bX, bY));

        public static Vector2Int Multiplication(this Vector2Int A, Vector2Int B)
            => new Vector2Int(A.x * B.x, A.y * B.y);

        public static Vector2Int Multiplication(this Vector2Int A, int bX, int bY)
            => Division(A, new Vector2Int(bX, bY));

        /// <summary>Soma todos os eixos.</summary>
        public static int Summation(this Vector2Int v)
            => v.x + v.y;
    }
}
