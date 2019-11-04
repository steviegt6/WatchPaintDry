using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewTip : MonoBehaviour
{
    public Text Tip;
    public string[] StickmanTips =
    {
        "New Text",
        "I can be useful, I swear!",
        "Don't touch the paint.",
        "Let the paint dry.",
        "Why are you playing this game?",
        "Commmmmmmmmmmmedy 100",
        "I hate Stevie",
        "txeT weN",
        "no",
    };
    public void CreateTip(GameObject buttonObj)
    {
        Debug.Log("Tip created(?) - CreateTip()");
        string tipString = StickmanTips[Random.Range(0, StickmanTips.Length)];
        Text text = buttonObj.GetComponentInChildren<Text>(true);
        if (text != null)
        {
            Tip.text = tipString;
        }
    }
}
