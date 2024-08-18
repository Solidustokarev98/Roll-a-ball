using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1; // Значение счета за сбор объекта
    private ScoreManager scoreManager; // Ссылка на ScoreManager

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>(); // Находим ScoreManager на сцене
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Проверяем, что столкновение с игроком
        {
            scoreManager.AddScore(scoreValue); // Увеличиваем счет
            Destroy(gameObject); // Уничтожаем объект после сбора
        }
    }
}