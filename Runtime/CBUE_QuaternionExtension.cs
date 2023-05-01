namespace UnityEngine {
    public static class CBUE_QuaternionExtension {
        /// <summary>Gera uma direção com base num <seealso cref="Vector3"/>.</summary>
        /// <param name="dir">direção.</param>
        public static Vector3 GenerateDirection(this Quaternion q, Vector3 dir)
            => q * dir;

        /// <summary>Gera uma direção com base num <seealso cref="Vector3"/>.right.</summary>
        public static Vector3 GenerateDirectionRight(this Quaternion q)
            => GenerateDirection(q, Vector3.right);

        /// <summary>Gera uma direção com base num <seealso cref="Vector3"/>.up.</summary>
        public static Vector3 GenerateDirectionUp(this Quaternion q)
            => GenerateDirection(q, Vector3.up);

        /// <summary>Gera uma direção com base num <seealso cref="Vector3"/>.forward.</summary>
        public static Vector3 GenerateDirectionForward(this Quaternion q)
            => GenerateDirection(q, Vector3.forward);

        /// <summary>Gera uma direção com base num <seealso cref="Vector3"/>.left.</summary>
        public static Vector3 GenerateDirectionLeft(this Quaternion q)
            => GenerateDirection(q, Vector3.left);

        /// <summary>Gera uma direção com base num <seealso cref="Vector3"/>.down.</summary>
        public static Vector3 GenerateDirectionDown(this Quaternion q)
            => GenerateDirection(q, Vector3.down);

        /// <summary>Gera uma direção com base num <seealso cref="Vector3"/>.back.</summary>
        public static Vector3 GenerateDirectionBack(this Quaternion q)
            => GenerateDirection(q, Vector3.back);
    }
}
