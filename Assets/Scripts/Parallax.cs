using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject camera;
    public float parallaxEffect;

    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float temp = (camera.transform.position.x * (1 - parallaxEffect));
        float distance = (camera.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);
        if (temp > startpos + length) startpos += length;//если камера ушла за ширину экрана, то меняем стартовую позицию на ширину экрана
        else if (temp < startpos - length) startpos -= length;
    }
}
