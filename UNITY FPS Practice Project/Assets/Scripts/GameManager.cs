using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public enum GameState
    {
        Playing,
        GameOver
    }

    public Text ScoreText;
    //public Text TimerText;

    //public float StartTime = 30.0f;

    public Canvas GameOverCanvas;

    [Header("Read-Only")]
    [SerializeField]
    private GameState CurrentGame = GameState.Playing;
    [SerializeField]
    public int _gameScore = 0;
    [SerializeField]
    //public float _timer = 0.0f;

    private void Awake()
    {
        GM = this; // ovo znaći da se ova skripta odnosi na ovaj gamemanager. U GM smo spremili ovu skriptu

        //_timer = StartTime;
        UpdateGUI(); //ovime atavljamo da bude 00 na početku

        GameOverCanvas.enabled = false;
    }

    private void Update()
    {
        //_timer -= Time.deltaTime;
        //TimerText.text = _timer.ToString("F");

        //if (_timer <= 0.0f)
        //{
        //    CurrentGame = GameState.GameOver;
        //    GameOverCanvas.enabled = true;
        //}
    }

    private void UpdateGUI()
    {
        ScoreText.text = _gameScore.ToString();
        //TimerText.text = _timer.ToString("F");
    }

    public void AddScore(int amount)
    {
        _gameScore += amount;
        UpdateGUI();
    }

    //public void AddTime(float amount)
    //{
    //    _timer += amount;
    //    UpdateGUI();
    //}
}
