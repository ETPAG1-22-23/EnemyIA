//Ne fonctionne pas encore appeler les fonctions est compliquer
//Doit mmelanger les scripts precedents
//Modif If corriger




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAdeType4 : MonoBehaviour
{
    float speeda = 5f;
    float distancea = 2f;
    private bool movingRight = true;
    public Transform groundDetection;
    public Transform target;
    public float speedb = 5f;
    float distancemax = 5f;
    // Start is called before the first frame update

    bool atckType1 = true;
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
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
    // Start is called before the first frame update

    // Update is called once per frame


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < distancemax)

        {
            atckType1 = false;
            //if(Input.GetKeyDown(KeyCode.P))
        }
        else
        {
            atckType1 = true;
        }
        if (atckType1)
        {
            function1();
        }
        else
        {
            function2();
        }
        
        
       
    }
    
    // Start is called before the first frame update
    

    // Update is called once per frame
  
}
