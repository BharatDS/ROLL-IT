using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "BALL")
        {
            GetComponent<Animator>().SetTrigger("MOVE");
        }
    }
}
