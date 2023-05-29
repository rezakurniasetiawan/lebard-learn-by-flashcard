using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionPopup : MonoBehaviour
{
    public bool action, answertrue, answerfalse;
    public GameObject actions, answer_true, answer_false;

    public void actionHitunglah()
    {
        action = true;
        if (action == true)
        {
            actions.SetActive(true);
        }
    }
    public void closeAction()
    {
        action = false;
        if (action == false)
        {
            actions.SetActive(false);
        }
    }

    public void answerTrue()
    {
        answertrue = true;
        if (answer_true == true)
        {
            answer_true.SetActive(true);
        }
    }
    public void answerFalse()
    {
        answerfalse = true;
        if (answer_false == true)
        {
            answer_false.SetActive(true);
        }
    }
    public void reload()
    {
        answerfalse = false;
        if (answerfalse == false)
        {
            answer_false.SetActive(false);
        }
    }
}
