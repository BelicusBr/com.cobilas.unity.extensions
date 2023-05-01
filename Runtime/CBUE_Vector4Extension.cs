namespace UnityEngine {
    public static class CBUE_Vector4Extension {
        public static Vector4 ABS(this Vector4 v, bool absX = true, bool absY = true, bool absZ = true, bool absW = true)
            => new Vector4(
                absX ? Mathf.Abs(v.x) : v.x,
                absY ? Mathf.Abs(v.y) : v.y,
                absZ ? Mathf.Abs(v.z) : v.z,
                absW ? Mathf.Abs(v.w) : v.w
                );

        public static Vector4 ABSX(this Vector4 v)
            => ABS(v, absY: false, absZ: false, absW: false);

        public static Vector4 ABSY(this Vector4 v)
            => ABS(v, absX: false, absZ: false, absW: false);

        public static Vector4 ABSZ(this Vector4 v)
            => ABS(v, absX: false, absY: false, absW: false);

        public static Vector4 ABSW(this Vector4 v)
            => ABS(v, absX: false, absY: false, absZ: false);

        public static Vector4 Invert(this Vector4 v, bool invertX = true, bool invertY = true, bool invertZ = true, bool invertW = true)
            => new Vector4(
                invertX ? -v.x : v.x,
                invertY ? -v.y : v.y,
                invertZ ? -v.z : v.z,
                invertW ? -v.w : v.w
                );

        public static Vector4 InvertX(this Vector4 v)
            => Invert(v, invertY: false, invertZ: false, invertW: false);

        public static Vector4 InvertY(this Vector4 v)
            => Invert(v, invertX: false, invertZ: false, invertW: false);

        public static Vector4 InvertZ(this Vector4 v)
            => Invert(v, invertX: false, invertY: false, invertW: false);

        public static Vector4 InvertW(this Vector4 v)
            => Invert(v, invertX: false, invertY: false, invertZ: false);

        public static Vector4 Division(this Vector4 A, Vector4 B)
            => new Vector4(A.x / B.x, A.y / B.y, A.z / B.z, A.w / B.w);

        public static Vector4 Division(this Vector4 A, float bX, float bY, float bZ, float bW)
            => Division(A, new Vector4(bX, bY, bZ, bW));

        public static Vector4 Multiplication(this Vector4 A, Vector4 B)
            => new Vector4(A.x * B.x, A.y * B.y, A.z * B.z, A.w * B.w);

        public static Vector4 Multiplication(this Vector4 A, float bX, float bY, float bZ, float bW)
            => Division(A, new Vector4(bX, bY, bZ, bW));

        public static Vector4 RemoveNaN(this Vector4 V)
            => new Vector4(
                float.IsNaN(V.x) ? 0f : V.x,
                float.IsNaN(V.y) ? 0f : V.y,
                float.IsNaN(V.z) ? 0f : V.z,
                float.IsNaN(V.w) ? 0f : V.w
                );

        public static Vector4 RemoveInfinity(this Vector4 V)
            => new Vector4(
                float.IsInfinity(V.x) ? 0f : V.x,
                float.IsInfinity(V.y) ? 0f : V.y,
                float.IsInfinity(V.z) ? 0f : V.z,
                float.IsInfinity(V.w) ? 0f : V.w);

        public static float Summation(this Vector4 v)
            => v.x + v.y + v.z + v.w;

        public static Vector4 Clamp(this Vector4 v, float min, float max)
            => new Vector4(
                Mathf.Clamp(v.x, min, max),
                Mathf.Clamp(v.y, min, max),
                Mathf.Clamp(v.z, min, max),
                Mathf.Clamp(v.w, min, max)
            );
    }
}
