using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI GameOverText;

    public TextMeshProUGUI WinText;

    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (_player.activeInHierarchy == false)
            GameOverText.gameObject.SetActive(true);

    }


    //Display GameOver Text
    

    
}
