using System;

namespace UnityEngine {
    public static class Vector3IntExtension {
        public static Vector3Int ABS(this Vector3Int v, bool absX = true, bool absY = true, bool absZ = true)
            => new Vector3Int(
                absX ? Mathf.Abs(v.x) : v.x,
                absY ? Mathf.Abs(v.y) : v.y,
                absZ ? Mathf.Abs(v.z) : v.z);

        public static Vector3Int ABSX(this Vector3Int v)
            => ABS(v, absY: false, absZ: false);

        public static Vector3Int ABSY(this Vector3Int v)
            => ABS(v, absX: false, absZ: false);

        public static Vector3Int ABSZ(this Vector3Int v)
            => ABS(v, absX: false, absY: false);

        public static Vector3Int Invert(this Vector3Int v, bool invertX = true, bool invertY = true, bool invertZ = true)
            => new Vector3Int(
                invertX ? -v.x : v.x,
                invertY ? -v.y : v.y,
                invertZ ? -v.z : v.z);

        public static Vector3Int InvertX(this Vector3Int v)
            => Invert(v, invertY: false, invertZ: false);

        public static Vector3Int InvertY(this Vector3Int v)
            => Invert(v, invertX: false, invertZ: false);

        public static Vector3Int InvertZ(this Vector3Int v)
            => Invert(v, invertX: false, invertY: false);

        public static Vector3Int Division(this Vector3Int A, Vector3Int B)
            => new Vector3Int(A.x / B.x, A.y / B.y, A.z / B.y);

        public static Vector3Int Division(this Vector3Int A, int bX, int bY, int bZ)
            => Division(A, new Vector3Int(bX, bY, bZ));

        public static Vector3Int Multiplication(this Vector3Int A, Vector3Int B)
            => new Vector3Int(A.x * B.x, A.y * B.y, A.z * B.z);

        public static Vector3Int Multiplication(this Vector3Int A, int bX, int bY, int bZ)
            => Division(A, new Vector3Int(bX, bY, bZ));

        /// <summary>Soma todos os eixos.</summary>
        public static float Summation(this Vector3Int v)
            => v.x + v.y + v.z;

        #region Old code
        [Obsolete("Use Vector3Int.ABS(bool, bool, bool)")]
        public static Vector3Int ABSVector3Int(this Vector3Int V, bool x = true, bool y = true, bool z = true)
            => ABS(V, x, y, z);
        [Obsolete("Use Vector3Int.ABSX()")]
        public static Vector3Int ABSVector3IntX(this Vector3Int V)
            => ABSX(V);
        [Obsolete("Use Vector3Int.ABSY()")]
        public static Vector3Int ABSVector3IntY(this Vector3Int V)
            => ABSY(V);
        [Obsolete("Use Vector3Int.ABSZ()")]
        public static Vector3Int ABSVector3IntZ(this Vector3Int V)
            => ABSZ(V);
        [Obsolete("Use Vector3Int.Invert(bool, bool, bool)")]
        public static Vector3Int InvertVector3Int(this Vector3Int V, bool x = true, bool y = true, bool z = true)
            => Invert(V, x, y, z);
        [Obsolete("Use Vector3Int.InvertX()")]
        public static Vector3Int InvertVector3IntX(this Vector3Int V)
            => InvertX(V);
        [Obsolete("Use Vector3Int.InvertY()")]
        public static Vector3Int InvertVector3IntY(this Vector3Int V)
            => InvertY(V);
        [Obsolete("Use Vector3Int.InvertZ()")]
        public static Vector3Int InvertVector3IntZ(this Vector3Int V)
            => InvertZ(V);
        [Obsolete("Use Vector3Int.Division()")]
        public static Vector3Int Divisor(this Vector3Int V, Vector3Int B)
            => Division(V, B);
        [Obsolete("Use Vector3Int.Multiplication()")]
        public static Vector3Int Multiplicador(this Vector3Int V, Vector3Int B)
            => Multiplication(V, B);
        [Obsolete]
        public static Vector3 ParaVector3(this Vector3Int V)
            => V;
        [Obsolete]
        public static Vector3Int RemoveNaN(this Vector3Int V)
            => new Vector3Int(
                (V.x.ToString() == "NaN") ? 0 : V.x,
                (V.y.ToString() == "NaN") ? 0 : V.y,
                (V.z.ToString() == "NaN") ? 0 : V.z);
        [Obsolete("Use Vector3Int.Summation()")]
        public static float SomaDeTodosOsEixos(this Vector3Int V)
            => V.x + V.y + V.z;
        #endregion
    }
}
