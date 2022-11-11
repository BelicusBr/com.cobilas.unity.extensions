namespace UnityEngine {
    public static class Vector4_CB_UE_Extension {
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
