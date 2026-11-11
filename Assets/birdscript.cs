using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicscript Logic;
    public bool birdIsAlive = true;

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }

        // Game over if the bird goes off the top or bottom of the screen
        float screenEdge = Camera.main.orthographicSize + 1;
        if (birdIsAlive && Mathf.Abs(transform.position.y) > screenEdge)
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }

    void Die()
    {
        if (!birdIsAlive) return;  // only trigger game over once
        birdIsAlive = false;
        Logic.gameOver();
    }
}