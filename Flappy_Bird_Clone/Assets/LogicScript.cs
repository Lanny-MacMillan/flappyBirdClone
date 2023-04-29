using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // USed to access UI like text and score
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public AudioSource gameOver; // identify flap sfx
    public bool alreadyPlayed = false;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")] // adds a menu option within the ...

    void Start() // Start is called before the first frame update
    {
        gameOver = GetComponent<AudioSource>(); // Find and identify gameover audio
        alreadyPlayed = false;
    }

    public void addScore( int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

     public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver ()
    {
        gameOverScreen.SetActive(true);
        if (!alreadyPlayed)
        {
            gameOver.Play();
            alreadyPlayed = true;
        }
    }
}
