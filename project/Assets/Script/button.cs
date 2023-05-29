using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void Mulai()
    {
        SceneManager.LoadScene("Mulai");
    }
    public void backToMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void lestPlay()
    {
        SceneManager.LoadScene("LetsPlay");
    }
    public void SiapaAku()
    {
        SceneManager.LoadScene("Draw1");
    }
    public void tentangApp()
    {
        SceneManager.LoadScene("TentangApp");
    }
    public void Capaian()
    {
        SceneManager.LoadScene("Capaian");
    }
    public void Panduan()
    {
        SceneManager.LoadScene("Panduan");
    }
    public void TujuanPembelajaran()
    {
        SceneManager.LoadScene("TujuanPembelajaran");
    }
    public void Mengurutkan()
    {
        SceneManager.LoadScene("Drag1");
    }

}
