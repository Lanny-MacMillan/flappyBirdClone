using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
public void PlayGame()
    {
        // Best practice, takes current scene and adds one to the index, works if your scenes are in order.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene("SCENE NAME"); //by name
        //SceneManager.LoadScene(1); // by index number
    }
public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit(); // wont actually quit in Unity
    }
}
