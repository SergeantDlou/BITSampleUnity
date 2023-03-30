using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class EndWallCollision : MonoBehaviour
{
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject == Ball) {
            resetBall();
        }
    }

 async void resetBall()
    {
        Ball.SetActive(false);
        Ball.transform.position = new Vector2(5, 0);
        await Task.Delay(2000);
        Ball.SetActive(true);
        Ball.GetComponent<SetMovement>().resetDirection();
    }
}
