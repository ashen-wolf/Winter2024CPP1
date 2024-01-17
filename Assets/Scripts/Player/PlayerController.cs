using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour

{
    //Component Section
    Rigidbody2D rb;

    [SerializeField] float speed = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        if (speed <=0)
        {
            speed = 7.0f;
            Debug.Log("Default Value of speed has changed to " + gameObject.name.ToString() );
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
       Debug.Log(rb.velocity);
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }
}
