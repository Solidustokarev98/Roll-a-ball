using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Переменная для хранения счета
    public Text scoreText; // Ссылка на текстовый UI элемент

    void Start()
    {
        UpdateScoreText(); // Обновляем текст счета при старте
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue; // Увеличиваем счет
        UpdateScoreText(); // Обновляем текст счета
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Отображаем счет
    }
}