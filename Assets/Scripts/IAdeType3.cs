using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAdeType3 : MonoBehaviour
{
    // L Ia te fonce dessus 
    
    public Transform target;
    [SerializeField] public float speed = 5f;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (true)
        {
            // Ici elle se deplace sans voler elle reste a la meme hauteur
            transform.position = new Vector3(transform.position.x, 2f, transform.position.z);
        }
    }
}