using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    public Text finalScoreText;
    public Text finalDistanceText;

    void OnEnable()
    {
        finalScoreText.text = "Puntos: " + Mathf.FloorToInt(ScoreManager.instance.GetScore());
        finalDistanceText.text = "Distancia: " + Mathf.FloorToInt(ScoreManager.instance.GetDistance());
    }
}