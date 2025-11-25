using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIManager : MonoBehaviour{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private Player player;
    [SerializeField] GameManager gm;
    void Start(){
        player.updateScore += UpdateScoreText;
        scoreText.text = "Score: ";
    }

    void Update(){
        
    }

    private void OnDisable() {
        player.updateScore -= UpdateScoreText;
    }

    void UpdateScoreText() {
        scoreText.text = "Score: " + gm.score.ToString();
    }
}
