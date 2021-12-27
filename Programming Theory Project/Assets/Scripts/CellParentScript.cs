using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class CellParentScript : MonoBehaviour
{
    //boolean indicating if the cell is activated
    private bool isPlayerOn;
    private bool startTimer;

  
    //Text of the Cell representing the key to press
    public TextMeshProUGUI key;

    //Actual Cell
    public GameObject cell;

    // Start is called before the first frame update
    void Start()
    {
        startTimer = false;
        isPlayerOn = false;

     //   key = gameObject.transform.Find("CellText").GetComponent<TextMeshProUGUI>();
     //   key.text = "W";

        //   cell = gameObject.transform.Find("Cell").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //destroy the cell if timer is up
    public void DestroyCell()
    {
        Destroy(gameObject);
    }

    //if
}
