using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptcomplet : MonoBehaviour
{
    float speeda = 5f;
    float distancea = 2f;
    private bool movingRight = true;
    public Transform groundDetection;
    public Transform target;
    public float speedb = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void function1()
    {
        transform.Translate(Vector2.right * speeda * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distancea);
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }


    private void function2()
    {

        transform.position = Vector3.MoveTowards(transform.position, target.position, speedb * Time.deltaTime);
        if (transform.position.y == 3)
        {
            transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        }
    }
    // Start is called before the first frame update

    // Update is called once per frame


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            function1();
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            function2();
        }
    }
    
    // Start is called before the first frame update
    

    // Update is called once per frame
  
}
