using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DaGeAction  ))]
public class DaGeMianBan : Editor
{
    DaGeAction daGe;

    private void OnEnable()
    {
        daGe = (DaGeAction)target;
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();

        EditorGUILayout.Space();
        EditorGUILayout.Space();

        EditorGUILayout.LabelField("基础信息");

        daGe.blood = EditorGUILayout.Slider("血量", daGe.blood, 0, 1000);
        daGe.speed = EditorGUILayout.FloatField("移动速度", daGe.speed);

        EditorGUILayout.EndVertical(); 
    }
}
