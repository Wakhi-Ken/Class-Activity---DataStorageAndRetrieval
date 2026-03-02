using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Playerdata playerData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Debug.Log("Player Name: " + playerData.playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
