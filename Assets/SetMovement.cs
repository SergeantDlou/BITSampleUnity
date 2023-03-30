using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMovement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector3(Random.Range(-4, -1), Random.Range(-3, 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetDirection() 
    {
        rb.velocity = new Vector3(Random.Range(-4, -1), Random.Range(-3, 3));
    }
}
