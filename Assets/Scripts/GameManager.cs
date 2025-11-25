using UnityEngine;

public class GameManager : MonoBehaviour{
    [SerializeField] private Player player;
    [SerializeField] private int score;
    void Start(){
        player.updateScore += UpdateScore;
    }
    void Update(){
        
    }

    private void OnDisable() {
        player.updateScore -= UpdateScore;
    }

    void UpdateScore() {
        score++;
    }
}
