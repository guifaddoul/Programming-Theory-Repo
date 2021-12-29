using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI GameOverText;

    public TextMeshProUGUI WinText;

    public TextMeshProUGUI PlayerEnergyText;

    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if ( (_player.activeInHierarchy == false) || (_player.GetComponent<PlayerController>().getPlayerEnergy() <= 0 ) )
            GameOverText.gameObject.SetActive(true);

        PlayerEnergyText.text = "Player Energy : " + _player.GetComponent<PlayerController>().getPlayerEnergy();

        if (_player.GetComponent<PlayerController>().getWiningStatus())
            WinText.gameObject.SetActive(true);

    }


    

    //Display GameOver Text
    

    
}
