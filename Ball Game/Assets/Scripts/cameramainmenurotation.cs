using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramainmenurotation : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 rotate;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(rotate * moveSpeed * Time.deltaTime, Space.World);
    }
    
}
