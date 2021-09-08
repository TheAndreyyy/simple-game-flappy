using UnityEngine;

public class Add_Score : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Score.score++;
            Destroy(this.gameObject);
        }
        if (collision.transform.tag == "Barrier")
        {

        }
    }
}
