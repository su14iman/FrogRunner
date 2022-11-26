using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{

    public float JumbForce;
    float score;

    [SerializeField]
    bool IsGrounded = false;
    bool isAlive = true;
    
    
    Rigidbody2D RB;

    public Text scoreText;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }
 


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded)
            {
                RB.AddForce(Vector2.up * JumbForce);
                IsGrounded = false;
            }

            if (isAlive)
            {
                score += Time.deltaTime * 4;
               // scoreText.text = "SCORE : " + score.ToString("F");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (IsGrounded == false)
            {
                IsGrounded = true;
            }
        }

        if (collision.gameObject.CompareTag("spike"))
        {
            isAlive = false;
            Time.timeScale = 0;
        }
    }

}
