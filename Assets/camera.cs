using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 offsite = new Vector3(0,0,-10)  ;
    public float camspeed = 0.2f;  



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 finalposition = playerPosition.position + offsite;
        Vector3 real = Vector3.Lerp(transform.position, finalposition, camspeed);
        transform.position = real;



    }
}
