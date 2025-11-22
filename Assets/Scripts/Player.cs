using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Vector3 direction = new Vector3(0.0f, 0.0f, 1.0f);
            transform.position += direction * speed * Time.deltaTime;
            Debug.Log("Se aprieta tecla W");
        }

        if (Keyboard.current.sKey.isPressed)
        {
            Vector3 direction = new Vector3(0.0f, 0.0f, 1.0f);
            transform.position -= direction * speed * Time.deltaTime;
            Debug.Log("Se aprieta tecla S");
        }
    }
}
