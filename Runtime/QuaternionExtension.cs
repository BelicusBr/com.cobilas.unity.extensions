using System;

namespace UnityEngine {
    public static class QuaternionExtension {
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
        #region Old code
        [Obsolete("Use Quaternion.GenerateDirection(Vector3)")]
        public static Vector3 GerarDirecao(this Quaternion Q, Vector3 Dir)
            => GenerateDirection(Q, Dir);
        [Obsolete("Use Quaternion.GenerateDirectionRight()")]
        public static Vector3 GerarDirecaoRight(this Quaternion Q)
            => GenerateDirectionRight(Q);
        [Obsolete("Use Quaternion.GenerateDirectionUp()")]
        public static Vector3 GerarDirecaoUp(this Quaternion Q)
            => GenerateDirectionUp(Q);
        [Obsolete("Use Quaternion.GenerateDirectionForward()")]
        public static Vector3 GerarDirecaoForward(this Quaternion Q)
            => GenerateDirectionForward(Q);
        [Obsolete("Use Quaternion.GenerateDirectionLeft()")]
        public static Vector3 GerarDirecaoLeft(this Quaternion Q)
            => GenerateDirectionLeft(Q);
        [Obsolete("Use Quaternion.GenerateDirectionDonw()")]
        public static Vector3 GerarDirecaoDown(this Quaternion Q)
            => GenerateDirectionDown(Q);
        [Obsolete("Use Quaternion.GenerateDirectionBack()")]
        public static Vector3 GerarDirecaoBack(this Quaternion Q)
            => GenerateDirectionBack(Q);
        #endregion
    }
}
