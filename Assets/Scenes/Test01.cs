using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Vector3.forward);
        //Debug.Log(transform.position);
        //Debug.Log(transform.localPosition);

        //  Debug.Log(transform.TransformPoint(new Vector3(0, 0, 0)));

        //Vector3 v1 = new Vector3(2, 3, 4);
        //Vector3 v2 = new Vector3(2, 3, 4);
        ////Debug.Log(v1 * 3);
        ////点积
        //Debug.Log(Vector3.Dot(v1, v2));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Target.transform.position - transform.position;

        float dot = Vector3.Dot(dir, transform.forward); // 点积 >0 两个向量锐角  =0 直角  < 0 钝角
        if (dot > 0 )
        {
            Debug.Log("在正面");
        }
        else if (dot == 0)
        {
            Debug.Log("在两侧");
        }
        else if (dot < 0)
        {
            Debug.Log("在后面");
        }
    }
}
