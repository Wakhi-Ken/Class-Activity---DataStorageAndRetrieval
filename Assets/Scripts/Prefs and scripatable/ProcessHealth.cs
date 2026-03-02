using UnityEngine;

public class ProcessHealth : MonoBehaviour
{
    public HealthManager healthManager;

    void OnEnable()
    {
        healthManager.OnDeath += HandleDeath;
    }

    void OnDisable()
    {
        healthManager.OnDeath -= HandleDeath;
    }

    void HandleDeath()
    {
        Debug.Log("You died!");
    }
}