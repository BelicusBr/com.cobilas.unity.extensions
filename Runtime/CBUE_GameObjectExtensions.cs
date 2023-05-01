using System;
using Cobilas.Collections;

namespace UnityEngine {
    public static class CBUE_GameObjectExtensions {
        public static void Destroy(this GameObject V) 
            => Object.Destroy(V);

        public static void Destroy<T>(this GameObject V) where T : Component
            => Object.Destroy(V.GetComponent<T>());

        public static void Destroy(this GameObject V, Object target)
            => Object.Destroy(target);

        public static void Destroy(this GameObject V, params Object[] objects) {
            foreach (Object v in objects) 
                Destroy(V, v);
        }

        public static void DestroyImmediate(this GameObject V) 
            => Object.DestroyImmediate(V);

        public static void DestroyImmediate<T>(this GameObject V) where T : Component
            => Object.DestroyImmediate(V.GetComponent<T>());
        //==========================GetPosition====================================================
        public static Vector3 GetPosition(this GameObject V)
            => V.transform.position;

        public static Vector3 GetLocalPosition(this GameObject V)
            => V.transform.localPosition;
        //=======================GetEulerAngles===================================
        public static Vector3 GetEulerAngles(this GameObject V)
            => V.transform.eulerAngles;

        public static Vector3 GetLocalEulerAngles(this GameObject V)
            => V.transform.localEulerAngles;
        //==========================GetRotation===========================================
        public static Quaternion GetRotation(this GameObject V)
            => V.transform.rotation;

        public static Quaternion GetLocalRotation(this GameObject V)
            => V.transform.localRotation;
        //===========================GetLocalScale============================================
        public static Vector3 GetLocalScale(this GameObject V)
            => V.transform.localScale;

        public static Vector3 GetLossyScale(this GameObject V)
            => V.transform.lossyScale;
        //============================SetPosition====================================================
        public static void SetPosition(this GameObject V, float x, float y, float z)
            => V.transform.position = new Vector3(x, y, z);

        public static void SetLocalPosition(this GameObject V, float x, float y, float z)
            => V.transform.localPosition = new Vector3(x, y, z);

        public static void SetPosition(this GameObject V, Vector3 position)
            => V.transform.position = position;

        public static void SetLocalPosition(this GameObject V, Vector3 position)
            => V.transform.localPosition = position;

        public static void SetPosition(this GameObject V, GameObject obj)
            => V.transform.position = obj.transform.position;

        public static void SetLocalPosition(this GameObject V, GameObject obj)
            => V.transform.localPosition = obj.transform.localPosition;

        public static void SetPosition(this GameObject V, Transform obj)
            => V.transform.position = obj.position;

        public static void SetLocalPosition(this GameObject V, Transform obj)
            => V.transform.localPosition = obj.localPosition;
        //=============================SetEulerAngles=====================================================
        public static void SetEulerAngles(this GameObject V, float x, float y, float z)
            => V.transform.SetPositionAndRotation(V.GetPosition(), Quaternion.Euler(x, y, z));

        public static void SetLocalEulerAngles(this GameObject V, float x, float y, float z)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), Quaternion.Euler(x, y, z));

        public static void SetEulerAngles(this GameObject V, Vector3 eulerAngles)
            => V.transform.SetPositionAndRotation(V.GetPosition(), Quaternion.Euler(eulerAngles));

        public static void SetLocalEulerAngles(this GameObject V, Vector3 eulerAngles)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), Quaternion.Euler(eulerAngles));

        public static void SetEulerAngles(this GameObject V, GameObject obj)
            => V.transform.SetPositionAndRotation(V.GetPosition(), obj.transform.rotation);

        public static void SetLocalEulerAngles(this GameObject V, GameObject obj)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), obj.transform.localRotation);

        public static void SetEulerAngles(this GameObject V, Transform obj)
            => V.transform.SetPositionAndRotation(V.GetPosition(), obj.rotation);

        public static void SetLocalEulerAngles(this GameObject V, Transform obj)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), obj.localRotation);
        //==============================SetRotation========================================================
        public static void SetRotation(this GameObject V, float x, float y, float z, float w)
            => V.transform.SetPositionAndRotation(V.GetPosition(), new Quaternion(x, y, z, w));

        public static void SetLocalRotation(this GameObject V, float x, float y, float z, float w)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), new Quaternion(x, y, z, w));

        public static void SetRotation(this GameObject V, Quaternion rotation)
            => V.transform.SetPositionAndRotation(V.GetPosition(), rotation);

        public static void SetLocalRotation(this GameObject V, Quaternion rotation)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), rotation);

        public static void SetRotation(this GameObject V, GameObject obj)
            => V.transform.SetPositionAndRotation(V.GetPosition(), obj.transform.rotation);

        public static void SetLocalRotation(this GameObject V, GameObject obj)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), obj.transform.localRotation);

        public static void SetRotation(this GameObject V, Transform obj)
            => V.transform.SetPositionAndRotation(V.GetPosition(), obj.rotation);

        public static void SetLocalRotation(this GameObject V, Transform obj)
            => V.transform.SetPositionAndRotation(V.GetLocalPosition(), obj.localRotation);
        //===============================SetLocalScale=====================================================
        public static void SetLocalScale(this GameObject V, float x, float y, float z)
            => V.transform.localScale = new Vector3(x, y, z);

        public static void SetLocalScale(this GameObject V, Vector3 Scale)
            => V.transform.localScale = Scale;
        //================================GetParent================================================
        public static Transform GetParent(this GameObject G)
            => G.transform.parent;
        //================================SetParent================================================
        public static void SetParent(this GameObject V, Transform Parent)
            => V.transform.SetParent(Parent);

        public static void SetParent(this GameObject V, GameObject Parent)
            => V.transform.SetParent(Parent.transform);
        //================================AddComponents===================================
        public static Component[] AddComponents(this GameObject V, params Type[] types) {
            Component[] Res = null;
            for (int I = 0; I < types.Length; I++)
                ArrayManipulation.Add<Component>(V.AddComponent(types[I]), ref Res);
            return Res;
        }
    }
}
