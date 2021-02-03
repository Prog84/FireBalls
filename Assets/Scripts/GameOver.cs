using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Tower _tower;

    private void OnEnable()
    {
        _tower.GameOver += OnGameOver;
    }
    private void OnDisable()
    {
        _tower.GameOver -= OnGameOver;
    }

    private void OnGameOver()
    {
        Debug.Log("Башня уничтожена!!!");
    }
}
