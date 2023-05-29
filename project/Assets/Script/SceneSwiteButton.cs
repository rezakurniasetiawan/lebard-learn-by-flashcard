using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwiteButton : MonoBehaviour
{
     // Quid Game
    public void QuitGame()
    {
        PlayerPrefs.SetInt("LoadSaved", 8);
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("LetsPlay");
    }
}
