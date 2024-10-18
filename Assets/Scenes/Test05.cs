using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test05 : MonoBehaviour
{
    public CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController >();
       
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h != 0 || v != 0)
        {
            Vector3 moveDir = new Vector3(transform.position.x + h, 0,transform.position.z + v);

            transform.LookAt(moveDir);


            characterController.Move(transform.forward * Time.deltaTime);

        }


    }
}
