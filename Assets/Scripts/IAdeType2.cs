using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAdeType2 : MonoBehaviour
{
    // L Ia te fonce dessus a vole d oiseau 
    
    public Transform target;
    [SerializeField] public float speed = 5f;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
