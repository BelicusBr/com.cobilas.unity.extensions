namespace UnityEngine {
    public static class GUIStyle_CB_UE_Extension {

        public static void DrawRepaint(this GUIStyle G, Rect position, GUIContent content, int ID) {
            if (Event.current.type == EventType.Repaint)
                G.Draw(position, content, ID);
        }

        public static void DrawRepaint(this GUIStyle G, Rect position, GUIContent content)
            => DrawRepaint(G, position, content, GUIUtility.GetControlID(FocusType.Passive));

        public static void DrawRepaint(this GUIStyle G, Rect position, GUIContent content, int ID, bool on) {
            if (Event.current.type == EventType.Repaint)
                G.Draw(position, content, ID, on);
        }

        public static void DrawRepaint(this GUIStyle G, Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) {
            if (Event.current.type == EventType.Repaint)
                G.Draw(position, content, isHover, isActive, on, hasKeyboardFocus);
        }

        public static void DrawRepaint(this GUIStyle G, Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
            => DrawRepaint(G, position, new GUIContent(text), isHover, isActive, on, hasKeyboardFocus);

        public static void DrawRepaint(this GUIStyle G, Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
            => DrawRepaint(G, position, new GUIContent(image), isHover, isActive, on, hasKeyboardFocus);
    }
}
