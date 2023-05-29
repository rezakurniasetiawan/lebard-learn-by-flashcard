using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sloting1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int Skor;
    public GameObject result;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Skor == 2){
            result.SetActive(true);
        }
        Debug.Log(Skor);
    }
}
