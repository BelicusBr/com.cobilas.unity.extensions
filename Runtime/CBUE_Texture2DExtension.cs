using Cobilas.Collections;

namespace UnityEngine {
    public static class CBUE_Texture2DExtension {

        public static Texture2D Copy(this Texture2D t, bool linear) {
            Texture2D copy = new Texture2D(t.width, t.height, t.format, t.mipmapCount, linear);
            Graphics.CopyTexture(t, copy);
            return copy;
        }

        public static Texture2D Copy(this Texture2D t)
            => Copy(t, true);

        public static Texture2D PaintTexture(this Texture2D t, Color color) {
            Texture2D texture = Copy(t);
            Color[] pixels = texture.GetPixels();
            Color32[] color32s = new Color32[ArrayManipulation.ArrayLength(pixels)];
            for (int I = 0; I < color32s.Length; I++)
                color32s[I] = pixels[I] * color;
            texture.SetPixels32(color32s);
            return texture;
        }

        public static Sprite CreateSprite(this Texture2D t
            , Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude,
            SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
            => Sprite.Create(t, rect, pivot, pixelsPerUnit, extrude, meshType, border, generateFallbackPhysicsShape);

        public static Sprite CreateSprite(this Texture2D t
            , Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude,
            SpriteMeshType meshType, Vector4 border)
            => CreateSprite(t, rect, pivot, pixelsPerUnit, extrude, meshType, border, false);

        public static Sprite CreateSprite(this Texture2D t
            , Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
            => CreateSprite(t, rect, pivot, pixelsPerUnit, extrude, meshType, Vector4.zero);

        public static Sprite CreateSprite(this Texture2D t, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
            => CreateSprite(t, rect, pivot, pixelsPerUnit, extrude, SpriteMeshType.Tight);

        public static Sprite CreateSprite(this Texture2D t, Rect rect, Vector2 pivot, float pixelsPerUnit)
            => CreateSprite(t, rect, pivot, pixelsPerUnit, 1);

        public static Sprite CreateSprite(this Texture2D t, Rect rect, Vector2 pivot)
            => CreateSprite(t, rect, pivot, 100f);

        public static Sprite CreateSprite(this Texture2D t, Rect rect)
            => CreateSprite(t, rect, Vector2.one * .5f);

        public static Sprite CreateSprite(this Texture2D t)
            => CreateSprite(t, new Rect(0f, 0f, t.width, t.height));
    }
}
