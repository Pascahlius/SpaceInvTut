using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SzeneNeuLaden : MonoBehaviour
{
    public GameObject Spieler;
    // Start is called before the first frame update
    private void Awake()
    {
       /* Vector3 vek3 = new Vector3(0.001460195f, -7.43f, 0f);
        Instantiate(Spieler, vek3, Quaternion.identity);
        DontDestroyOnLoad(this);*/
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            SceneManager.LoadScene("Game");
            //Spieler.SetActive(true);
        }
    }
}
