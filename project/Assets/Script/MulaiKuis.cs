using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MulaiKuis : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("level1");
    }
    public void LoadGame()
    {
        if(PlayerPrefs.GetInt("LoadSaved") == 8)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
        }
        else
        {
            return;
        }
    }
}
