namespace UnityEngine {
    public static class CBUE_MonoBehaviourExtension {
        #region Position
        public static void SetPosition(this MonoBehaviour m, float x, float y, float z) 
            => SetPosition(m, new Vector3(x, y, z));

        public static void SetPosition(this MonoBehaviour m, float x, float y) => SetPosition(m, x, y, 0f);

        public static void SetPosition(this MonoBehaviour m, Vector3 pos) => m.transform.position = pos;

        public static void SetPosition(this MonoBehaviour m, Vector2 pos) => SetPosition(m, pos.x, pos.y);

        public static Vector3 GetPosition(this MonoBehaviour m) => m.transform.position;

        public static void SetLocalPosition(this MonoBehaviour m, float x, float y, float z) 
            => SetLocalPosition(m, new Vector3(x, y, z));

        public static void SetLocalPosition(this MonoBehaviour m, float x, float y) => SetLocalPosition(m, x, y, 0f);

        public static void SetLocalPosition(this MonoBehaviour m, Vector3 pos) => m.transform.localPosition = pos;

        public static void SetLocalPosition(this MonoBehaviour m, Vector2 pos) => SetLocalPosition(m, pos.x, pos.y);

        public static Vector3 GetLocalPosition(this MonoBehaviour m) => m.transform.localPosition;
        #endregion
        #region EulerAngles
        public static void SetEulerAngles(this MonoBehaviour m, float x, float y, float z) 
            => SetEulerAngles(m, new Vector3(x, y, z));

        public static void SetEulerAngles(this MonoBehaviour m, float x, float y) => SetEulerAngles(m, x, y, 0f);

        public static void SetEulerAngles(this MonoBehaviour m, Vector3 pos) => m.transform.eulerAngles = pos;

        public static void SetEulerAngles(this MonoBehaviour m, Vector2 pos) => SetEulerAngles(m, pos.x, pos.y);

        public static Vector3 GetEulerAngles(this MonoBehaviour m) => m.transform.eulerAngles;

        public static void SetLocalEulerAngles(this MonoBehaviour m, float x, float y, float z) 
            => SetLocalEulerAngles(m, new Vector3(x, y, z));

        public static void SetLocalEulerAngles(this MonoBehaviour m, float x, float y) => SetLocalEulerAngles(m, x, y, 0f);

        public static void SetLocalEulerAngles(this MonoBehaviour m, Vector3 pos) => m.transform.localEulerAngles = pos;

        public static void SetLocalEulerAngles(this MonoBehaviour m, Vector2 pos) => SetLocalEulerAngles(m, pos.x, pos.y);

        public static Vector3 GetLocalEulerAngles(this MonoBehaviour m) => m.transform.localEulerAngles;
        #endregion
        #region LocalScale
        public static Vector3 GetLossyScale(this MonoBehaviour m) => m.transform.lossyScale;

        public static void SetLocalScale(this MonoBehaviour m, float x, float y, float z) 
            => SetLocalScale(m, new Vector3(x, y, z));

        public static void SetLocalScale(this MonoBehaviour m, float x, float y) => SetLocalScale(m, x, y, 0f);

        public static void SetLocalScale(this MonoBehaviour m, Vector3 pos) => m.transform.localScale = pos;

        public static void SetLocalScale(this MonoBehaviour m, Vector2 pos) => SetLocalScale(m, pos.x, pos.y);

        public static Vector3 GetLocalScale(this MonoBehaviour m) => m.transform.localScale;
        #endregion
        #region Rotation
        public static void SetRotation(this MonoBehaviour m, float x, float y, float z, float w) 
            => SetRotation(m, new Quaternion(x, y, z, w));

        public static void SetRotation(this MonoBehaviour m, Quaternion rot) => m.transform.rotation = rot;

        public static void SetRotation(this MonoBehaviour m, Vector4 rot) => SetRotation(m, rot.x, rot.y, rot.z, rot.w);

        public static Quaternion GetRotation(this MonoBehaviour m) => m.transform.rotation;

        public static void SetLocalRotation(this MonoBehaviour m, float x, float y, float z, float w) 
            => SetLocalRotation(m, new Quaternion(x, y, z, w));

        public static void SetLocalRotation(this MonoBehaviour m, Quaternion rot) => m.transform.localRotation = rot;

        public static void SetLocalRotation(this MonoBehaviour m, Vector4 rot) 
            => SetLocalRotation(m, rot.x, rot.y, rot.z, rot.w);

        public static Quaternion GetLocalRotation(this MonoBehaviour m) => m.transform.localRotation;
        #endregion

        public static void DestroyMyGameObject(this MonoBehaviour m)
            => Object.Destroy(m.gameObject);

        public static void DestroyMyGameObject(this MonoBehaviour m, float t)
            => Object.Destroy(m.gameObject, t);

        public static void DestroyMyComponent(this MonoBehaviour m)
            => Object.Destroy(m);

        public static void DestroyMyComponent(this MonoBehaviour m, float t)
            => Object.Destroy(m, t);

        public static void Destroy<T>(this MonoBehaviour m) where T : Component
            => Object.Destroy(m.GetComponent<T>());

        public static void Destroy<T>(this MonoBehaviour m, float t) where T : Component
            => Object.Destroy(m.GetComponent<T>(), t);

        public static void DontDestroyOnLoad(this MonoBehaviour m)
            => Object.DontDestroyOnLoad(m.gameObject);
    }
}
