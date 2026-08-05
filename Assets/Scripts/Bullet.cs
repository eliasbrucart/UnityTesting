using UnityEngine;

public class Bullet : MonoBehaviour{
    [SerializeField]private float speed;
    [SerializeField] private Player player;
    private Vector3 direction;
    void Start() {
        transform.position = new Vector3(player.transform.position.x, player.transform.localScale.y, player.transform.position.z + 0.5f);
        if(direction == Vector3.zero) {
            direction = player.transform.forward;
        }
        player.shootBullet += SetBulletDirection;
    }

    void Update(){
        UpdateBullet();
    }

    void SetBulletDirection(Vector3 direction) {
        this.direction = direction;
    }

    void UpdateBullet() {
        transform.position += this.direction * speed * Time.deltaTime;
    }
}