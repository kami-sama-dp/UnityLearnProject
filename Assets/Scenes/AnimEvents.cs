using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public AnimationCurve curve;
    public float timer = 0;
    private Vector3 initpos;
    public void ShowImg(string name)
    {
        Debug.Log(name);
    }

    private void Start()
    {
        initpos = transform.position; 
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1)
        {
            timer = 0; 
        }
        //Debug.Log(timer + ":" + curve.Evaluate(timer));

        transform.position = initpos + Vector3.up * curve.Evaluate(timer) * 5 + Vector3.right * timer * 3 ;
    }
}
