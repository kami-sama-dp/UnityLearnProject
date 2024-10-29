using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{ 
    public void ShowMsg()
    {
        Debug.Log("PlayHealth ShowMsg");
    }

    private void OnDrawGizmos()
    {
        var color = Gizmos.color;
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, Vector3.one) ;
        Gizmos.color = color;
    }

    private void OnDrawGizmosSelected()
    {
        var color = Gizmos.color;
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, Vector3.one);
        Gizmos.color = color;
    }
}
