using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestEditor : MonoBehaviour
{
    [MenuItem("MyTools/ShowMsg &s", false, 1000)]
    public static void ShowMsg()
    {
        Debug.Log("ShowMsg");
    }

    [MenuItem("MyTools/DeleteAllObj")]
    public static void DeleteAllObj()
    {
        foreach (var obj in Selection.objects)
        {
            Undo.DestroyObjectImmediate(obj);
        }
    }

    // 给自定义脚本添加功能并实现直接使用该脚本函数，不需要运行游戏  
    [MenuItem("CONTEXT/PlayerHealth/Init")]
    public static void Init(MenuCommand cmd)
    {
        PlayerHealth playerHealth = cmd.context as PlayerHealth;
        playerHealth.ShowMsg();
    }
}
