using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DaGeAction  ))]
public class DaGeMianBan : Editor
{
    DaGeAction daGe;
    bool showMsg = true;

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


        if (daGe.blood < 200)
        {
            GUI.color = Color.red;
        }
        else if (daGe.blood > 800)
        {
            GUI.color = Color.green;
        }
        else
        {
            GUI.color = Color.grey;
        }

        Rect bloodRect = GUILayoutUtility.GetRect(50, 50);

        EditorGUI.ProgressBar(bloodRect, daGe.blood/1000, "当前血量");
        GUI.color = Color.white;

        daGe.speed = EditorGUILayout.FloatField("移动速度", daGe.speed);

        daGe.damageValue = EditorGUILayout.FloatField("当前伤害值", daGe.damageValue );

        if (daGe.damageValue > 4 )
        {
            EditorGUILayout.HelpBox("伤害高", MessageType.Error);  
        }
        else if (daGe.damageValue < 2)
        {
            EditorGUILayout.HelpBox("伤害低", MessageType.Warning);
        }
        else
        {
            EditorGUILayout.HelpBox("伤害适中", MessageType.Info);
        }

        showMsg = EditorGUILayout.Foldout(showMsg, "其他信息");
        if(showMsg)
        {
            daGe.movePerUpdate = EditorGUILayout.FloatField("每一帧的移动距离 ", daGe.movePerUpdate);
            EditorGUILayout.LabelField("Back Story");
            daGe.story = EditorGUILayout.TextArea(daGe.story, GUILayout.MinHeight(50));

        }

        EditorGUILayout.EndVertical(); 
    }
}
