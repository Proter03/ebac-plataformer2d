using UnityEngine;

public class EndGame : MonoBehaviour
{
    public string tagToCompare = "Player";

    public GameObject uiEndGame;

    public HealthBase healthPlayer;

    private void Awake()
    {
        healthPlayer.OnKill += OnKillPlayer;
    }

    private void OnDestroy()
    {
        healthPlayer.OnKill -= OnKillPlayer;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(tagToCompare))
        {
            CallEndGame();
        }
    }

    public void CallEndGame()
    {
        uiEndGame.SetActive(true);
    }

    private void OnKillPlayer()
    {
        CallEndGame();
    }
}
