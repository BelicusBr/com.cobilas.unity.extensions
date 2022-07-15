using System;

namespace UnityEngine {
    public static class Vector2IntExtension {
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

        #region Old code
        [Obsolete("Use Vector2Int.ABS(bool, bool)")]
        public static Vector2Int ABSVector2Int(this Vector2Int V, bool x = true, bool y = true)
            => ABS(V, x, y);
        [Obsolete("Use Vector2Int.ABSX()")]
        public static Vector2Int ABSVector2IntX(this Vector2Int V)
            => ABSX(V);
        [Obsolete("Use Vector2Int.ABSY()")]
        public static Vector2Int ABSVector2IntY(this Vector2Int V)
            => ABSY(V);
        [Obsolete("Use Vector2Int.Invert(bool, bool)")]
        public static Vector2Int InvertVector2Int(this Vector2Int V, bool x = true, bool y = true)
            => Invert(V, x, y);
        [Obsolete("Use Vector2Int.InvertX()")]
        public static Vector2Int InvertVector2IntX(this Vector2Int V)
            => InvertX(V);
        [Obsolete("Use Vector2Int.InvertY()")]
        public static Vector2Int InvertVector2IntY(this Vector2Int V)
            => InvertY(V);
        [Obsolete("Use Vector2Int.Division(Vector2Int)")]
        public static Vector2Int Divisor(this Vector2Int V, Vector2Int B)
            => Division(V, B);
        [Obsolete("Use Vector2Int.Multiplication(Vector2Int)")]
        public static Vector2Int Multiplicador(this Vector2Int V, Vector2Int B)
            => Multiplication(V, B);
        [Obsolete("Usar converção explícita")]
        public static Vector2Int ParaVector3(this Vector2Int V)
            => V;
        [Obsolete]
        public static Vector2Int RemoveNaN(this Vector2Int V)
            => new Vector2Int(
                (V.x.ToString() == "NaN") ? 0 : V.x,
                (V.y.ToString() == "NaN") ? 0 : V.y);
        [Obsolete("Use Vector2Int.Summation()")]
        public static float SomaDeTodosOsEixos(this Vector2Int V)
            => V.x + V.y;
        #endregion
    }
}
