using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text distanceText;

    private float score = 0;
    private float distance = 0;
    private Transform player;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        distance = player.position.z;
        score += Time.deltaTime * 10;
        scoreText.text = "Score: " + Mathf.FloorToInt(score);
        distanceText.text = "Distance: " + Mathf.FloorToInt(distance);
    }

    public float GetScore() => score;
    public float GetDistance() => distance;
}