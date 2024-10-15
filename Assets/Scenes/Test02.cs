using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test02 : MonoBehaviour
{
    public Transform obj01;
    public Transform obj02;

    // Start is called before the first frame update
    void Start()
    {
        float distance = Mathf.Lerp(0, 10, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        // 计算物体右前方30度， 10米远的坐标
        float x = Mathf.Sin(30 * Mathf.Deg2Rad) * 10;
        float z = Mathf.Cos(30 * Mathf.Deg2Rad) * 10;

        //局部坐标
        //Vector3 point = new Vector3(x, 0, z);

        // 世界坐标
        Vector3 point = transform.TransformPoint(x, 0, z);

        obj01.position = Vector3.Lerp(obj01.position, obj02.position, 0.1f);

    }

    public static float MyLerp(float a, float b , float t)
    {
        return a + (b - a) * t;
    }
}
