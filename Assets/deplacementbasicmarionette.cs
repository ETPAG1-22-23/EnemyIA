using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacementbasicmarionette : MonoBehaviour
{
    public float speed;

    float MovementX;
    float MovementY;
    public float speedc = 0.18f;
    public float jumph = 4.01f;

    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Ici, on utilise un get axis pour avoir la sensibilité 
        pour utiliser eventuellemnt une manette avec des joystic */
        if (Input.GetKeyDown(KeyCode.Q))
        {   
            MovementX = -(Input.GetAxisRaw("Horizontal"));
           
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MovementX = Input.GetAxisRaw("Horizontal");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            MovementY = Input.GetAxisRaw("Vertical");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {   
            MovementY = -(Input.GetAxisRaw("Vertical"));
            
        }


        Rb.velocity = new Vector2(MovementX * speed * Time.deltaTime, MovementY * speed * Time.deltaTime); 
     } 
}




    

        
    

