using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{

    public bool isPlayerGoal;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Ball")) {
            if (!isPlayerGoal) {
                GameObject.Find("GameManager").GetComponent<GameLogic>().CpuScored();
            }
            else {
                GameObject.Find("GameManager").GetComponent<GameLogic>().PlayerScored();
            }
        }
    }
}
