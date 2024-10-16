using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test03 : MonoBehaviour
{
    public Transform A;
    public Transform B;

    public Vector3 StartPos;
    public Vector3 EndPos;

    public float offset = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = A.position;
        EndPos = B.position;

    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime;
        A.position = Vector3.Lerp(StartPos, EndPos, offset);
        if (offset > 1)
        {
            offset = 0;
        }



    }

}
