using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D ballBody;
    Vector3 startPosition;

    public float speed = 5.0f;
    public float addedSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        ballBody = GetComponent<Rigidbody2D>();
        LaunchBall();
        startPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LaunchBall() {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        ballBody.velocity = new Vector2(-speed + x, -speed + y);
    }

    public void Reset() {
        ballBody.velocity = Vector2.zero;
        transform.position = startPosition;
        speed = 5.0f;
        Invoke("LaunchBall", 1);
    }
}
