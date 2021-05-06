using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 5;
    public float speed;
    private float X;
    private float Z;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void Move()
    {
        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector3(X, 0, Z) * speed;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            Debug.Log($"Score: {score}");
            Destroy(other.gameObject);
        }
        if (other.tag == "Trap")
        {
            health--;
            Debug.Log($"Health {health}");
        }
        if (other.tag == "Goal")
        {
            Debug.Log("You win!");
        }
    }
}
