using System;

namespace UnityEngine {
    public static class Vector3Extension {
        public static Vector3 ABS(this Vector3 v, bool absX = true, bool absY = true, bool absZ = true)
            => new Vector3(
                absX ? Mathf.Abs(v.x) : v.x, 
                absY ? Mathf.Abs(v.y) : v.y,
                absZ ? Mathf.Abs(v.z) : v.z);

        public static Vector3 ABSX(this Vector3 v)
            => ABS(v, absY: false, absZ:false);

        public static Vector3 ABSY(this Vector3 v)
            => ABS(v, absX: false, absZ:false);

        public static Vector3 ABSZ(this Vector3 v)
            => ABS(v, absX:false, absY:false);

        public static Vector3 Invert(this Vector3 v, bool invertX = true, bool invertY = true, bool invertZ = true)
            => new Vector3(
                invertX ? -v.x : v.x, 
                invertY ? -v.y : v.y,
                invertZ ? -v.z : v.z);

        public static Vector3 InvertX(this Vector3 v)
            => Invert(v, invertY:false, invertZ:false);

        public static Vector3 InvertY(this Vector3 v)
            => Invert(v, invertX:false, invertZ:false);

        public static Vector3 InvertZ(this Vector3 v)
            => Invert(v, invertX:false, invertY:false);

        public static Vector3 Division(this Vector3 A, Vector3 B)
            => new Vector3(A.x / B.x, A.y / B.y, A.z / B.y);

        public static Vector3 Division(this Vector3 A, float bX, float bY, float bZ)
            => Division(A, new Vector3(bX, bY, bZ));

        public static Vector3 Multiplication(this Vector3 A, Vector3 B)
            => new Vector3(A.x * B.x, A.y * B.y, A.z * B.z);

        public static Vector3 Multiplication(this Vector3 A, float bX, float bY, float bZ)
            => Division(A, new Vector3(bX, bY, bZ));

        public static Vector3 RemoveNaN(this Vector3 V)
            => new Vector3(
                float.IsNaN(V.x) ? 0 : V.x,
                float.IsNaN(V.y) ? 0 : V.y,
                float.IsNaN(V.z) ? 0 : V.z);

        public static Vector3 RemoveInfinity(this Vector3 V)
            => new Vector3(
                float.IsInfinity(V.x) ? 0 : V.x, 
                float.IsInfinity(V.y) ? 0 : V.y,
                float.IsInfinity(V.z) ? 0 : V.z);

        public static Vector3Int ToVector3Int(this Vector3 v)
            => new Vector3Int((int)v.x, (int)v.y, (int)v.z);

        /// <summary>Soma todos os eixos.</summary>
        public static float Summation(this Vector3 v)
            => v.x + v.y + v.z;
        #region Old code
        [Obsolete("Use Vector3.ABS(bool, bool, bool)")]
        public static Vector3 ABSVector3(this Vector3 V, bool x = true, bool y = true, bool z = true)
            => ABS(V, x, y, z);
        [Obsolete("Use Vector3.ABSX()")]
        public static Vector3 ABSVector3X(this Vector3 V)
            => ABSX(V);
        [Obsolete("Use Vector3.ABSY()")]
        public static Vector3 ABSVector3Y(this Vector3 V)
            => ABSY(V);
        [Obsolete("Use Vector3.ABSZ()")]
        public static Vector3 ABSVector3Z(this Vector3 V)
            => ABSZ(V);
        [Obsolete("Use Vector3.Invert(bool, bool, bool)")]
        public static Vector3 InvertVector3(this Vector3 V, bool x = true, bool y = true, bool z = true)
            => Invert(V, x, y, z);
        [Obsolete("Use Vector3.InvertX()")]
        public static Vector3 InvertVector3X(this Vector3 V)
            => InvertX(V);
        [Obsolete("Use Vector3.InvertY()")]
        public static Vector3 InvertVector3Y(this Vector3 V)
            => InvertY(V);
        [Obsolete("Use Vector3.InvertZ()")]
        public static Vector3 InvertVector3Z(this Vector3 V)
            => InvertZ(V);
        [Obsolete("Use Vector3.Division(Vector3)")]
        public static Vector3 Divisor(this Vector3 V, Vector3 B) 
            => new Vector3(V.x / B.x, V.y / B.y, V.z / B.z);
        [Obsolete("Use Vector3.Multiplication(Vector3)")]
        public static Vector3 Multiplicador(this Vector3 V, Vector3 B)
            => new Vector3(V.x * B.x, V.y * B.y, V.z * B.z);
        [Obsolete("Use Vector3.ToVector3Int()")]
        public static Vector3Int ParaVector3Int(this Vector3 V)
            => new Vector3Int((int)V.x, (int)V.y, (int)V.z);
        [Obsolete("Use Vector3.Summation()")]
        public static float SomaDeTodosOsEixos(this Vector3 V)
            => V.x + V.y + V.z;
        [Obsolete]
        public static Vector3 RemoverElevadosAPotencia(this Vector3 V)
            => new Vector3(
                V.x.ToString().ToLower().Contains("e") ? 0 : V.x,
                V.y.ToString().ToLower().Contains("e") ? 0 : V.y,
                V.z.ToString().ToLower().Contains("e") ? 0 : V.z
                );
        #endregion
    }
}
