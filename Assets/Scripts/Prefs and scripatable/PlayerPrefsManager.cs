using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour
{
    public Text healthText;
    public Text playerNameText;
    public Text scoreText;

    private float health;
    private string playerName;
    private int score;

    void Start()
    {
        // Delete previously cached PlayerPrefs data
        UnityEngine.PlayerPrefs.DeleteAll();

        // Load saved data or set default values
        health = UnityEngine.PlayerPrefs.GetFloat("Health", 100f);
        playerName = UnityEngine.PlayerPrefs.GetString("PlayerName", "Ken");
        score = UnityEngine.PlayerPrefs.GetInt("Score", 0);

        UpdateUI();
    }

    void Update()
    {
        // Health decreases over time
        health -= Time.deltaTime * 5f;
        if (health < 0f)
            health = 0f;

        // Score increases over time
        score += Mathf.RoundToInt(Time.deltaTime * 5); 

        // Save updated values
        UnityEngine.PlayerPrefs.SetFloat("Health", health);
        UnityEngine.PlayerPrefs.SetInt("Score", score);
        UnityEngine.PlayerPrefs.SetString("PlayerName", playerName);

        UpdateUI();
    }

    void UpdateUI()
    {
        healthText.text = "Health: " + health.ToString("F1");
        playerNameText.text = "Player Name: " + playerName;
        scoreText.text = "Score: " + score;
    }
}