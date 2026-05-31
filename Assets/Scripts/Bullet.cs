using UnityEngine;

public class Bullet : MonoBehaviour{
    [SerializeField]private float speed;
    [SerializeField] private Player player;
    private Vector3 direction;
    void Start() {
        player.shootBullet += SetBulletDirection;
        transform.position = new Vector3(player.transform.position.x, player.transform.localScale.y, player.transform.position.z + 0.5f);
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