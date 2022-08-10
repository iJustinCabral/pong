using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{

    [Header("Ball")]
    public GameObject ball;

    [Header("Player")]
    public GameObject player1;
    public GameObject playerGoal;

    [Header("CPU")]
    public GameObject cpu;
    public GameObject cpuGoal;

    [Header("Game UI")]
    public GameObject playerScoreText;
    public GameObject cpuScoreText;

    private int playerScore = 0;
    private int cpuScore = 0;

    public void PlayerScored() {
        playerScore++;
        playerScoreText.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
        ResetPositions();
    }

    public void CpuScored() {
        cpuScore++;
        cpuScoreText.GetComponent<TextMeshProUGUI>().text = cpuScore.ToString();
        ResetPositions();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ResetPositions() {
        player1.GetComponent<PlayerController>().Reset();
        cpu.GetComponent<CpuController>().Reset();
        ball.GetComponent<BallController>().Reset();
    }
}
