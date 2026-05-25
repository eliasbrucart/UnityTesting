using UnityEngine;

public class GameManager : MonoBehaviour{
    [SerializeField] private Player player;
    [SerializeField] public int score;

    static public GameManager instanceGameManager;
    static public GameManager Instance { get { return instanceGameManager; } }

    public void Awake() {
        if (instanceGameManager != null && instanceGameManager != this)
            Destroy(instanceGameManager);
        else
            instanceGameManager = this;
    }

    void Start(){
        player.updateScore += UpdateScore;
    }
    void Update(){
        
    }

    private void OnDisable() {
        player.updateScore -= UpdateScore;
    }

    void UpdateScore() {
        score += 1;
    }
}
