using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameConditions : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private EnemySpawner EnemySpawner;
    public Text scoreText;
    public int score;

    private void Start()
    {
        scoreText.text = score.ToString();
        score = 0;
        winPanel.SetActive(false);
    }
    void Update()
    {
        if(EnemySpawner.currentEnemyCount <= 0 && EnemySpawner.countEnemyInScene.Count == 0)
        {
            Win();
        }
    }
    void Win()
    {
        winPanel.SetActive(true);
    }
    public void CheckScore()
    {
        scoreText.text = score.ToString();
    }
}
