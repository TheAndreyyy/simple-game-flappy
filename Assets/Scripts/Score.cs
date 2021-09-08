using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int score;
    public Text Score_Text;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        Score_Text.text = score.ToString();
    }
}
