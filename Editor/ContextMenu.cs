using UnityEngine;
using UnityEditor;
using System;

namespace studio.raspberry.vrchat.ma_suimin_system
{
    public static class ContextMenu
    {
        const string baseMenuPath = "GameObject/RBS-SuiminSystem/";
        const string japanesePrefabGuid = "99ff43deda213c145878efbecf96abf1";
        const string englishPrefabGuid = "191431eacdb14f049bbc5ad19147b7fe";

        [MenuItem(baseMenuPath + "日本語版のセットアップ(Japanese)")]
        public static void ApplyToAvatar_Japanese(MenuCommand command)
        {
            GameObject obj = UnityEditor.PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(japanesePrefabGuid))) as GameObject;
            if (obj != null)
            {
                Transform objTransform = obj.transform;
                objTransform.SetParent(Selection.activeTransform, false);
                UnityEditor.EditorUtility.SetDirty(obj);
                UnityEditor.EditorUtility.SetDirty(objTransform);
            }
        }

        [MenuItem(baseMenuPath + "Setup english version(英語)")]
        public static void ApplyToAvatar_English(MenuCommand command)
        {
            GameObject obj = UnityEditor.PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(AssetDatabase.GUIDToAssetPath(englishPrefabGuid))) as GameObject;
            if (obj != null)
            {
                Transform objTransform = obj.transform;
                objTransform.SetParent(Selection.activeTransform, false);
                UnityEditor.EditorUtility.SetDirty(obj);
                UnityEditor.EditorUtility.SetDirty(objTransform);
            }
        }
    }
}
