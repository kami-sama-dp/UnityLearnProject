using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaGeAction : MonoBehaviour
{
    public float speed = 20;
    public float blood = 1000;
    public float damageValue = 0;

    public float movePerUpdate = 0;

    public string story = "故事内容";

    private float getHurtCd = 2;

    [SerializeField]
    private float passTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        passTime += Time.deltaTime;
        if (passTime >= getHurtCd)
        {
            passTime = 0;
            damageValue = Random.Range(1, 10);
            blood -= damageValue;
        }
        Vector3 moveValue = Vector3.forward * Time.deltaTime * speed;
        Debug.Log(moveValue);
        movePerUpdate = moveValue.magnitude;
        transform.Translate(moveValue, Space.Self);
    }
}
