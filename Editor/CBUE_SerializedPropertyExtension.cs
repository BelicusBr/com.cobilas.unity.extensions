#if UNITY_EDITOR
using System;
using System.Reflection;
using System.Collections.Generic;

namespace UnityEditor {
    public static class CBUE_SerializedPropertyExtension {
        public static void GetFieldInfo(this SerializedProperty P, out KeyValuePair<FieldInfo, object> fieldInfo)
            => fieldInfo = GetFieldInfoObjectRef(P.propertyPath.Replace(".Array.data[", ".<Array>["), P.serializedObject.targetObject);

        public static object GetValue(this SerializedProperty P) {
            GetFieldInfo(P, out KeyValuePair<FieldInfo, object> Res);
            return Res.Key.GetValue(Res.Value);
        }

        public static T GetValue<T>(this SerializedProperty P)
            => (T)GetValue(P);

        public static void SetValue(this SerializedProperty P, object value) {
            GetFieldInfo(P, out KeyValuePair<FieldInfo, object> Res);
            Res.Key.SetValue(Res.Value, value);
        }

        private static KeyValuePair<FieldInfo, object> GetFieldInfoObjectRef(string propertyPath, object target) {
            int index = propertyPath.IndexOf('.');

            if (index < 0) {
                FieldInfo fieldInfo = GetFieldInfo(target, propertyPath);
                return new KeyValuePair<FieldInfo, object>(fieldInfo, target);
            }
            string namevar = propertyPath.Remove(index);
            propertyPath = propertyPath.Remove(0, index + 1);

            if (namevar.Contains("<Array>")) {
                index = int.Parse(namevar.Replace("<Array>[", "").Replace("]", ""));
                target = GetMethodInfo(target, "GetValue", typeof(int)).Invoke(target, new object[] { index });
            } else target = GetFieldInfo(target, namevar).GetValue(target);
            return GetFieldInfoObjectRef(propertyPath, target);
        }

        public static MethodInfo GetMethodInfo(object target, string name, params Type[] _params)
            => target.GetType().GetMethod(name, _params);

        private static FieldInfo GetFieldInfo(object target, string name)
            => target.GetType().GetField(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
    }
}
#endif
