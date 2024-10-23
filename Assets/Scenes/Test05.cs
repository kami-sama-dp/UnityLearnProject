using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{
    public CharacterController characterController;
    public Animator animator;
    public float speed;
     
    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController >();
        animator = this.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
       
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h != 0 || v != 0)
        {
            //Vector3 moveDir = new Vector3(transform.position.x + h, 0,transform.position.z + v);

            //transform.LookAt(moveDir);
            //characterController.Move(transform.forward * Time.deltaTime);

            //transform.Rotate(0, h * 100 * Time.deltaTime, 0);
            //characterController.Move(v * transform.forward *  Time.deltaTime);


            Vector3 moveDir = new Vector3(h, 0, v);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 0.05f);


            animator.SetFloat("speend", 0.3f);
            if (Input.GetKey(KeyCode.Q))
            {
                speed = 10;
                animator.SetFloat("speend", 1);
            }
            else
            {
                speed = 5;
            }


        }
        else
        {
            animator.SetFloat("speend", 0 );

        }


    }

    //  普通的碰撞检查函数可以使用
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }
}
