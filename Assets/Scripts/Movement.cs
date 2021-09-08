using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public bool isPlayer = false;
    public bool isBackground = false;
    public float leftBorder;
    public bool leftBorderIsOn=false;
    public float rightBorder;
    public bool rightBorderIsOn=false;


    void Update()
    {
    //    if (isPlayer)
    //    {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        //}
        //if (isBackground)
        //{
        //    transform.position += Vector3.left * Speed * Time.deltaTime;
        //}
    }
}
