using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < ball.transform.position.y + 1) 
        {
            transform.position += new Vector3(0, 0.01f, 0);
        }   
        if (transform.position.y > ball.transform.position.y - 1) 
        {
            transform.position -= new Vector3(0, 0.01f, 0);
        }   
    }
}
