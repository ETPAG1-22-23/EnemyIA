using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test (pour projet) : MonoBehaviour
{

    public Transform target;
    public float speed = 5f;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (true)
        {
            transform.position = new Vector3(transform.position.x, -3.47f, transform.position.z);

        }
  {
    private Rigidbody rb;
    public bool onG;
    float repeats;
    public float amount;
    public float rotateSpeed;
    rb = GetComponent<Rigidbody>();
  }

    // Use this for initialization
    void Start()
    {
        
        onG = true;
        repeats = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (repeats < amount)
        {
            if (onG)
            {
                rb.velocity = new Vector3(0, 1, 1);
                onG = false;
                repeats = +1;
            }
        }
        if (repeats == amount)
        {
            transform.Rotate(0, rotateSpeed, 0);
            repeats = 0;
        }
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("sol"))
        {
            onG = true;
        }
    }
}