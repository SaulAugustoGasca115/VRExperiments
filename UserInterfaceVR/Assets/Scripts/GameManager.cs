using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("GameManager")]
    public Image img;
    public float fadeTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Fade",1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fade()
    {
        img.CrossFadeAlpha(0, fadeTime, true);
    }
}
