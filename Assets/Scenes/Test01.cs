using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public GameObject Target;

    private float viewDistance = 3;
    private float viewAngle = 120;
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

        //Vector2 v1 = new Vector2(3, 3);
        //Vector2 v2 = new Vector2(4, 0);
        //Debug.Log(Vector2.Angle(v1, v2));

        
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(Target.transform.position, transform.position) <= viewDistance )
        {
            //Debug.Log("满足距离！！");
            Vector3 dir = Target.transform.position - transform.position;
            float angle = Vector3.Angle(dir, transform.forward);
            if (angle <= viewAngle / 2)
            {
                Debug.Log("在视野角度内");
            }
        }
        Debug.DrawLine(transform.position, transform.position + viewDistance * transform.forward, Color.red);

        //float x = Mathf.Sin(viewAngle/2 * Mathf.Deg2Rad) * viewDistance;
        //float z = Mathf.Cos(viewAngle/2 * Mathf.Deg2Rad) * viewDistance;
        //Debug.DrawLine(transform.position, transform.TransformPoint(x, 0, z), Color.black);

        //x = Mathf.Sin(-viewAngle / 2 * Mathf.Deg2Rad) * viewDistance;
        //z = Mathf.Cos(-viewAngle / 2 * Mathf.Deg2Rad) * viewDistance;
        //Debug.DrawLine(transform.position, transform.TransformPoint(x, 0, z), Color.blue);

        for (float i = -viewAngle /2; i < viewAngle/2; i+=10)
        {
            float x = Mathf.Sin(i  * Mathf.Deg2Rad) * viewDistance;
            float z = Mathf.Cos(i  * Mathf.Deg2Rad) * viewDistance;
            Debug.DrawLine(transform.position, transform.TransformPoint(x, 0, z), Color.black);


        }

        //Vector3 dir = Target.transform.position - transform.position;

        //float dot = Vector3.Dot(dir, transform.forward); // 点积 >0 两个向量锐角  =0 直角  < 0 钝角
        //if (dot > 0 )
        //{
        //    Debug.Log("在正面");
        //}
        //else if (dot == 0)
        //{
        //    Debug.Log("在两侧");
        //}
        //else if (dot < 0)
        //{
        //    Debug.Log("在后面");
        //}
    }
}
