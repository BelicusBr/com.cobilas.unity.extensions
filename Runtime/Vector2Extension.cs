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
        #region Old code
        [Obsolete("Use Vector2.ABS(bool, bool)")]
        public static Vector2 ABSVector2(this Vector2 V, bool x = true, bool y = true)
            => ABS(V, x, y);
        [Obsolete("Use Vector2.ABSX()")]
        public static Vector2 ABSVector2X(this Vector2 V)
            => ABSX(V);
        [Obsolete("Use Vector2.ABSY()")]
        public static Vector2 ABSVector2Y(this Vector2 V)
            => ABSY(V);
        [Obsolete("Use Vector2.Invert(bool, bool)")]
        public static Vector2 InvertVector2(this Vector2 V, bool x = true, bool y = true)
            => Invert(V, x, y);
        [Obsolete("Use Vector2.InvertX()")]
        public static Vector2 InvertVector2X(this Vector2 V)
            => InvertX(V);
        [Obsolete("Use Vector2.InvertY()")]
        public static Vector2 InvertVector2Y(this Vector2 V)
            => InvertY(V);
        [Obsolete("Use Vector2.Division(Vector2)")]
        public static Vector2 Divisor(this Vector2 V, Vector2 B)
            => Division(V, B);
        [Obsolete("Use Vector2.Division(float, float)")]
        public static Vector2 Divisor(this Vector2 V, float x, float y)
            => Division(V, x, y);
        [Obsolete("Use Vector2.Multiplication(float, float)")]
        public static Vector2 Multiplicador(this Vector2 V, Vector2 B)
            => Multiplication(V, B);
        [Obsolete("Use Vector2.Multiplication(float, float)")]
        public static Vector2 Multiplicador(this Vector2 V, float x, float y)
            => Multiplication(V, x, y);
        [Obsolete("Use Vector2.ToVector2Int()")]
        public static Vector2Int ParaVector3Int(this Vector2 V)
            => new Vector2Int((int)V.x, (int)V.y);
        [Obsolete("Use Vector2.Summation()")]
        public static float SomaDeTodosOsEixos(this Vector2 V)
            => Summation(V);
        [Obsolete]
        public static Vector2 RemoverElevadosAPotencia(this Vector2 V)
            => new Vector2(
                V.x.ToString().ToLower().Contains("e") ? 0 : V.x,
                V.y.ToString().ToLower().Contains("e") ? 0 : V.y
                );
        #endregion
    }
}
