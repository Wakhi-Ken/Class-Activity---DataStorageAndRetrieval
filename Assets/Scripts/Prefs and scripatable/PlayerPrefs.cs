using UnityEngine;
using UnityEngine.UI;

public class FreshStartPlayerPrefs : MonoBehaviour
{
    public Text healthText;
    public Text playerNameText;
    public Text isFullHealthText;

    private float health;
    private string playerName;
    private bool isFullHealth;

    void Start()
    {
        // Clear any previously saved PlayerPrefs
        PlayerPrefs.DeleteKey("Health");
        PlayerPrefs.DeleteKey("PlayerName");

        // Start fresh with default values
        health = 100f;
        playerName = "Ken";

        UpdateBool();
        UpdateUI();
    }

    void Update()
    {
        // Simulate health decreasing over time
        health -= Time.deltaTime * 5f;
        if (health < 0) health = 0;

        // Save updated health
        PlayerPrefs.SetFloat("Health", health);

        UpdateBool();
        UpdateUI();
    }

    public void ChangeName(string newName)
    {
        playerName = newName;
        PlayerPrefs.SetString("PlayerName", playerName);
        UpdateUI();
    }

    void UpdateBool()
    {
        isFullHealth = (health > 0f && health <= 100f); 
    }

    void UpdateUI()
    {
        healthText.text = "Health: " + health.ToString("F1");
        playerNameText.text = "Player Name: " + playerName;
        isFullHealthText.text = "Full Health: " + isFullHealth;
    }
}