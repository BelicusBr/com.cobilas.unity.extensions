using System;
using Cobilas.Collections;

namespace UnityEngine {
    public static class Component_CB_UE_Extensions {

        public static int PickUpChildCount(this Component m)
            => m.transform.childCount;
        #region PickUpChild
        public static Transform PickUpChild(this Component m, int index)
            => m.transform.GetChild(index);

        public static Component PickUpChild(this Component m, Type componet, int index) {
            Transform res = PickUpChild(m, index);
            return res != (Component)null ? res.GetComponent(componet) : (Component)null;
        }

        public static TypeComponent PickUpChild<TypeComponent>(this Component m, int index) where TypeComponent : Component
            => PickUpChild(m, typeof(TypeComponent), index) as TypeComponent;

        public static Transform PickUpChild(this Component m, string name) {
            for (int I = 0; I < PickUpChildCount(m); I++) {
                Transform temp = PickUpChild(m, I);
                if (temp.name == name)
                    return temp;
            }
            return (Transform)null;
        }

        public static Component PickUpChild(this Component m, Type componet, string name) {
            Transform res = PickUpChild(m, name);
            return res != (Component)null ? res.GetComponent(componet) : (Component)null;
        }

        public static TypeComponent PickUpChild<TypeComponent>(this Component m, string name) where TypeComponent : Component
            => PickUpChild(m, typeof(TypeComponent), name) as TypeComponent;

        public static Component PickUpChild(this Component m, Type componet) {
            for (int I = 0; I < PickUpChildCount(m); I++) {
                Component res = PickUpChild(m, I).GetComponent(componet);
                if (res != null)
                    return res;
            }
            return (Component)null;
        }

        public static TypeComponent PickUpChild<TypeComponent>(this Component m) where TypeComponent : Component {
            for (int I = 0; I < PickUpChildCount(m); I++) {
                TypeComponent res = PickUpChild(m, I).GetComponent<TypeComponent>();
                if (res != null)
                    return res;
            }
            return (TypeComponent)null;
        }
        #endregion
        #region GetChildren
        public static Transform[] GetChildren(this Component m)
            => GetChildren(m, true);

        public static Component[] GetChildren(this Component m, Type component)
            => GetChildren(m, component, true);

        public static TypeComponent[] GetChildren<TypeComponent>(this Component m) where TypeComponent : Component
            => GetChildren<TypeComponent>(m, true);

        public static Transform[] GetChildren(this Component m, bool getChildDisabled) {
            Transform[] res = new Transform[0];
            for (int I = 0; I < res.Length; I++) {
                Transform temp = PickUpChild(m, I);
                if (temp.gameObject.activeSelf || getChildDisabled)
                    ArrayManipulation.Add(temp, ref res);
            }
            return res;
        }

        public static Component[] GetChildren(this Component m, Type component, bool getChildDisabled) {
            Component[] res = new Component[0];
            foreach (var item in GetChildren(m, getChildDisabled)) {
                Component temp = item.GetComponent(component);
                if (temp != (Component)null)
                    ArrayManipulation.Add(temp, ref res);
            }
            return res;
        }

        public static TypeComponent[] GetChildren<TypeComponent>(this Component m, bool getChildDisabled) where TypeComponent : Component {
            TypeComponent[] res = new TypeComponent[0];
            foreach (var item in GetChildren(m, getChildDisabled)) {
                TypeComponent temp = item.GetComponent<TypeComponent>();
                if (temp != (TypeComponent)null)
                    ArrayManipulation.Add(temp, ref res);
            }
            return res;
        }
        #endregion
        #region GetAllChildren
        public static Transform[] GetAllChildren(this Component m)
            => GetAllChildren(m, false);

        public static Component[] GetAllChildren(this Component m, Type component)
            => GetAllChildren(m, component, true);

        public static TypeComponent[] GetAllChildren<TypeComponent>(this Component m) where TypeComponent : Component
            => GetAllChildren<TypeComponent>(m, true);

        public static Transform[] GetAllChildren(this Component m, bool getChildDisabled)
            => GetAllChildren(m.transform, getChildDisabled);

        public static Component[] GetAllChildren(this Component m, Type component, bool getChildDisabled) {
            Component[] res = new Component[0];
            foreach (var item in GetAllChildren(m, getChildDisabled)) {
                Component temp = item.GetComponent(component);
                if (temp != (Component)null)
                    ArrayManipulation.Add(temp, ref res);
            }
            return res;
        }

        public static TypeComponent[] GetAllChildren<TypeComponent>(this Component m, bool getChildDisabled) where TypeComponent : Component {
            TypeComponent[] res = new TypeComponent[0];
            foreach (var item in GetAllChildren(m, getChildDisabled)) {
                TypeComponent temp = item.GetComponent<TypeComponent>();
                if (temp != (Component)null)
                    ArrayManipulation.Add(temp, ref res);
            }
            return res;
        }
        #endregion
        #region GetChildOrGrandchild
        public static Transform GetChildOrGrandchild(this Component m, string name) {
            foreach (var item in GetAllChildren(m, true))
                if (item.name == name)
                    return item;
            return (Transform)null;
        }

        public static Component GetChildOrGrandchild(this Component m, Type component, string name) {
            Transform res = GetChildOrGrandchild(m, name);
            return res != (Transform)null ? res.GetComponent(component) : (Component)null;
        }

        public static TypeComponent GetChildOrGrandchild<TypeComponent>(this Component m, string name) where TypeComponent : Component {
            Transform res = GetChildOrGrandchild(m, name);
            return res != (Transform)null ? res.GetComponent<TypeComponent>() : (TypeComponent)null;
        }
        #endregion
        #region RootParent
        public static Transform RootParent(this Component c) {
            Transform res = RootParent(c.transform);
            return res == c.transform ? (Transform)null : res;
        }

        public static Component RootParent(this Component c, Type componet) {
            Transform transform = RootParent(c);
            return transform != null ? transform.GetComponent(componet) : (Component)null;
        }

        public static TypeComponent RootParent<TypeComponent>(this Component c) where TypeComponent : Component {
            Transform transform = RootParent(c);
            return transform != null ? transform.GetComponent<TypeComponent>() : (TypeComponent)null;
        }
        #endregion
        public static bool ChildExists(this Component m, string name) {
            for (int I = 0; I < PickUpChildCount(m); I++)
                if (PickUpChild(m, I).name == name)
                    return true;
            return false;
        }
        public static bool ChildOrGrandchildExists(this Component m, string name) {
            foreach (var item in GetAllChildren(m, true))
                if (item.name == name)
                    return true;
            return false;
        }

        private static Transform RootParent(Transform transform) {
            if (transform.parent != null)
                return RootParent(transform.parent);
            return transform;
        }

        private static Transform[] GetAllChildren(Transform transform, bool getChildDisabled) {
            Transform[] res = new Transform[0];
            for (int I = 0; I < transform.childCount; I++) {
                Transform temp = transform.GetChild(I);
                if (temp.gameObject.activeSelf || getChildDisabled) {
                    ArrayManipulation.Add(temp, ref res);
                    ArrayManipulation.Add(GetAllChildren(temp, getChildDisabled), ref res);
                }
            }
            return res;
        }
    }
}
