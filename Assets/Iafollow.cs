using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iafollow : MonoBehaviour
{ 
    public Transform target;
    public float speedb = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, speedb * Time.deltaTime);
        if (transform.position.y == 3) 
        {
            transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        }
    }
}
   