using UnityEngine;


[CreateAssetMenu(fileName = "Sample Safe House", menuName = "ScriptableObjects/Sample Safe House", order = 1)]
public class Playerdata : ScriptableObject
{
    public string playerName;
    public int score;
    public float health;
}
