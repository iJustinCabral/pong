using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuController : MonoBehaviour
{

    public GameObject ball;
    public float speed = 10.0f;

    private Vector2 movement = Vector2.zero;
    private Rigidbody2D cpuBody;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        cpuBody = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float d = ball.transform.position.y - transform.position.y;

        if (d > 0) {
            cpuBody.velocity = new Vector2(0, speed * Mathf.Min(d, 1.01f));
        }
        
        if (d < 0) {
            cpuBody.velocity = new Vector2(0, -(speed * Mathf.Min(-d, 1.01f)));
        }
    
    }

    public void Reset() {
        cpuBody.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
