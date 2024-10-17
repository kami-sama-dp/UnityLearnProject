using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test04 : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(Screen.width);
        Debug.Log(Screen.height);

        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log(pos);

        float dis = Vector3.Distance(transform.position, Camera.main.transform.position);
        //Quaternion qt = new Quaternion();
        //Vector3 axis = Vector3.up;
        //float rad = 50 * Mathf.Deg2Rad;
        //qt.x = Mathf.Sin(rad / 2) * axis.x;
        //qt.y = Mathf.Sin(rad / 2) * axis.y;
        //qt.z = Mathf.Sin(rad / 2) * axis.z;
        //qt.w = Mathf.Cos(rad / 2);

        //transform.rotation = qt;
        //transform.rotation = Quaternion.Euler(30, 50, 0);



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition );
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                Vector3.Distance(transform.position, obj.transform.position));

            Vector3 obj_pos = Camera.main.ScreenToWorldPoint(mousePos);

            Instantiate(obj, obj_pos, Quaternion.identity);
        }
    }
}
