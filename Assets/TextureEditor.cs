using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class TextureEditor : MonoBehaviour
{
    static Object targetObj;
    static Object[] allTargetObj;

    [MenuItem("TextureEdit/Edit")]
    public static void EditTexture()
    {
        targetObj = Selection.activeObject;
        if (targetObj && targetObj is Texture)
        {
            string path = AssetDatabase.GetAssetPath(targetObj);
            TextureImporter texture = AssetImporter.GetAtPath(path) as TextureImporter;
            texture.textureType = TextureImporterType.Sprite;
            texture.spritePixelsPerUnit = 1;
            texture.filterMode = FilterMode.Trilinear;
            texture.mipmapEnabled = false;
            //texture.textureFormat = TextureImporterFormat.AutomaticTruecolor;
            AssetDatabase.ImportAsset(path);
        }
    }

    [MenuItem("TextureEdit/CreateImg")]
    public static void CreateImg()
    {
        GameObject canvas = GameObject.Find("Canvas");
        if ( canvas == null)
        {
            return;
        }

        allTargetObj = Selection.objects;
        foreach (Object obj in allTargetObj)
        {
            if (obj && obj is Texture)
            {
                string path = AssetDatabase.GetAssetPath(obj);
                TextureImporter textureImporter = AssetImporter.GetAtPath(path) as TextureImporter;
                if (textureImporter.textureType == TextureImporterType.Sprite)
                {

                    Sprite s = AssetDatabase.LoadAssetAtPath<Sprite>(path);
                    float w = s.rect.width;
                    float h = s.rect.height;
                    Object obj1 = Resources.Load("model/ImageModel");
                    GameObject gameObject = (GameObject)Instantiate(obj1, canvas.transform);
                    Image img = gameObject.GetComponent<Image>();
                    img.rectTransform.sizeDelta = new Vector2(w, h);
                    img.sprite = s;
                    img.gameObject.name = s.name; 
                }
            }
        }
    }

    [MenuItem("TextureEdit/CopyImg")]
    public static void CopyImg()
    {
        targetObj = Selection.activeObject;
        string path = AssetDatabase.GetAssetPath(targetObj);
        path = System.Text.RegularExpressions.Regex.Replace(path, "Assets/Resources/", "");
        GUIUtility.systemCopyBuffer = path;
    }

}
