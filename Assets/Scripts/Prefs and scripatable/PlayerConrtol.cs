using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Playerdata playerData;
    public Text playerNameText;
    public Text scoreText;
    public Text healthText;

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        playerNameText.text = "Player Name: " + playerData.playerName;
        scoreText.text = "Score: " + playerData.score;
        healthText.text = "Health: " + playerData.health.ToString("F1");
    }
}