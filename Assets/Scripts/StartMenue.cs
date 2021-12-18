using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenue : MonoBehaviour
{

    public Text text1;
    public Text text2;
    public Text text3;
    public float fadeTime = 7f;

    // Start is called before the first frame update
    void Start()
    {
            text1.CrossFadeAlpha(0f, fadeTime, true);
            text2.CrossFadeAlpha(0f, fadeTime, true);
            text3.CrossFadeAlpha(0f, fadeTime, true);
            Destroy(gameObject,fadeTime+5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
