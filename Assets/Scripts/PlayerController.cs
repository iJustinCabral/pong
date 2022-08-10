using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] float moveSpeed = 5.0f;

    float vertical;

    Rigidbody2D playerBody;
    Vector3 startPosition;
    BoxCollider2D playerBox;
    BoxCollider2D ballBox;
    

    // Start is called before the first frame update
    void Start() {
        playerBody = GetComponent<Rigidbody2D>();
        playerBox = GetComponent<BoxCollider2D>();
        startPosition = transform.position;
        ballBox = GameObject.Find("Ball").GetComponent<BoxCollider2D>();


    }

    // Update is called once per frame
    void Update() {
        MovePlayer();

        if (playerBody.IsTouching(ballBox)) {
            GameObject.Find("Ball").GetComponent<BallController>().addedSpeed += 0.5f;
        }

    }

    void MovePlayer() {
        vertical = Input.GetAxis("Vertical");
        playerBody.velocity = new Vector2(0, vertical * moveSpeed);
        
    }

    public void Reset() {
        playerBody.velocity = Vector2.zero;
        transform.position = startPosition;
    }

}
