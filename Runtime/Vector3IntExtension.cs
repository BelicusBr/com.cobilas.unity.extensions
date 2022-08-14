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
    }
}
