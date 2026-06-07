using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreCounter;
    float startPosition;
    // Update is called once per frame

    void Start()
    {
        startPosition = player.position.z;
    }
    void Update()
    {
        int score = (int)(player.position.z - startPosition);
        scoreCounter.text = score.ToString();
    }
}
