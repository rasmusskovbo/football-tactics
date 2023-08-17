using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseRushQB : MonoBehaviour {

    public float speed = 2.0f;
    private Rigidbody2D rb;
    
    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        // Move the defensive lineman towards the right
        rb.velocity = new Vector2(0, speed);
    }
 
}
