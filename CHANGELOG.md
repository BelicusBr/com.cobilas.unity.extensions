# Changelog
## [1.21.1] - 01/05/2023
### Fixed
- Nos métodos `Vector3:CBUE_Vector3Extension.Division(this Vector3, Vector3)` e `Vector3Int:CBUE_Vector3IntExtension.Division(this Vector3Int, Vector3Int)`
o campo `A.z` erá divido por `B.y`.
### Added
- Os métodos foram adicionados.
```c#
	void:CBUE_GameObjectExtensions.Destroy(this GameObject, Object);
	Vector4:CBUE_Vector4Extension.ABS(this Vector4, [bool:true], [bool:true], [bool:true], [bool:true]);
	Vector4:CBUE_Vector4Extension.ABSX(this Vector4);
	Vector4:CBUE_Vector4Extension.ABSY(this Vector4);
	Vector4:CBUE_Vector4Extension.ABSZ(this Vector4);
	Vector4:CBUE_Vector4Extension.ABSW(this Vector4);
	Vector4:CBUE_Vector4Extension.Invert(this Vector4, [bool:true], [bool:true], [bool:true], [bool:true]);
	Vector4:CBUE_Vector4Extension.InvertX(this Vector4);
	Vector4:CBUE_Vector4Extension.InvertY(this Vector4);
	Vector4:CBUE_Vector4Extension.InvertZ(this Vector4);
	Vector4:CBUE_Vector4Extension.InvertW(this Vector4);
	Vector4:CBUE_Vector4Extension.Division(this Vector4, Vector4);
	Vector4:CBUE_Vector4Extension.Division(this Vector4, float, float, float, float);
	Vector4:CBUE_Vector4Extension.Multiplication(this Vector4, Vector4);
	Vector4:CBUE_Vector4Extension.Multiplication(this Vector4, float, float, float, float);
	Vector4:CBUE_Vector4Extension.RemoveNaN(this Vector4);
	Vector4:CBUE_Vector4Extension.RemoveInfinity(this Vector4);
```
## [1.0.19] - 30/01/2023
### Changed
- Na classe `SerializedProperty_CB_UE_Extension` nos métodos `GetValue` e `SetValue` o campos `KeyValuePair<FieldInfo, object> Res` foi imbutido na função `GetFieldInfo`.
- Nas classes `Component_CB_UE_Extensions`, `GameObject_CB_UE_Extensions` e `MonoBehaviour_CB_UE_Extension` a restrição `where T : Object` foi alterada para `where T : Component`.
- No método `Texture2D:Texture2D_CB_UE_Extension.PaintTexture(this Texture2D, Color)` a instrução `texture.SetPixels` foi alterada para `texture.SetPixels32` por questões de desempenho.
## [1.0.17] 11/11/2022
### Add método clamp
O método `Clamp` foi adicionado nas classes
- Vector2_CB_UE_Extension
- Vector3_CB_UE_Extension
- Vector2Int_CB_UE_Extension
- Vector3Int_CB_UE_Extension
- Vector4_CB_UE_Extension
## [1.0.16] 04/09/2022
- Add : MonoBehaviour_CB_UE_Extension.cs
## [1.0.12] 01/08/2022
- Fix CHANGELOG.md
- Fix package.json
- Change SerializedPropertyExtension.cs
## [1.0.11] 31/07/2022
- Fix CHANGELOG.md
- Fix package.json
- Add Cobilas Extensions.asset
- Remove Editor\DependencyWarning.cs
- Remove Runtime\DependencyWarning.cs
## [1.0.10] 23/07/2022
- Add CHANGELOG.md
- Fix package.json
## [1.0.9] 22/07/2022
- Add Editor/DependencyWarning.cs
- Add Runtime/DependencyWarning.cs
- Fix Cobilas.Unity.Extensions.asmdef
- Fix Cobilas.Unity.Editor.Extensions.asmdef
- Fix LICENSE.md
- Fix package.json
## [1.0.8] 17/07/2022
- Fix package.json
- Delete main.yml
- Delete README.md
## [1.0.2] 15/07/2022
- Add main.yml
## [1.0.0] 15/07/2022
- Add package.json
- Add LICENSE.md
- Add folder:Editor
- Add folder:Runtime
## [0.0.1] 15/07/2022
### Repositorio com.cobilas.unity.extensions iniciado
- Lançado para o GitHub