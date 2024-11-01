using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//[AddComponentMenu("YeWuTeXing/Script")]
//[ExecuteInEditMode]
public class YeWuTeXing : MonoBehaviour
{
    [Tooltip("This is toolTip")]
    public string toolTips;

    [TextArea]
    public string textArea1;


    [SerializeField]
    private int privateField; 


    [RuntimeInitializeOnLoadMethod]
    static void RunTest()
    {
        Debug.Log("RuntimeInitializeOnLoadMethod");
    }

    [Range(1, 10)]
    public int rangeNum;


    [HideInInspector]
    public int value1;
    public int value2;

    [Space(10)]

    [Multiline]
    public string mulituStr;

    [Delayed]
    public int testAge = 0;

    [ContextMenuItem("显示ContextMenuItem", "showMyName")]
    public string name = "显示名字";
    public void showMyName()
    {
        Debug.Log("showMyName"); 
    }


    [ContextMenu("显示debug文字")]
    public void showContextMenu()
    {
        Debug.Log("showContextMenu");
    }

    [ColorUsage(true)]
    public Color color;


    public TestA testA;
    [NonSerialized]
    public string str1 = "sssss";


    private void Update()
    {
        Debug.Log(testAge);
    }

    [Header("这是一个header")]
    public string myHeader;
}

[Serializable]
public class TestA
{
    public string name;
    public int age;

}