using UnityEngine;

public class Game_Script : MonoBehaviour
{
    public Game_Manager Game_Manager_obj;
    public float Player_Velocity = 1;
    public Rigidbody2D Player;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Player.velocity = Vector2.up * Player_Velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Respawn")
        {
            Game_Manager_obj.Game_Over();
        }
    }
}
