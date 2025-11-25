using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private GameObject wall;
    public Action updateScore;
    void Start()
    {
        
    }

    void Update()
    {
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            Vector3 direction = new Vector3(0.0f, 0.0f, 1.0f);
            transform.position += direction * speed * Time.deltaTime;
            Debug.Log("Se aprieta tecla W");
        }

        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            Vector3 direction = new Vector3(0.0f, 0.0f, 1.0f);
            transform.position -= direction * speed * Time.deltaTime;
            Debug.Log("Se aprieta tecla S");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Debug.Log("Colisiono con " + collision.gameObject.tag);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Debug.Log("Colisiono con " + other.gameObject.tag);
            updateScore.Invoke();
        }
    }
}
