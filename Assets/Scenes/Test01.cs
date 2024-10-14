using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Vector3.forward);
         Debug.Log(transform.position);
        Debug.Log(transform.localPosition);

      //  Debug.Log(transform.TransformPoint(new Vector3(0, 0, 0)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
