using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class CellParentScript : MonoBehaviour
{
    //boolean indicating if the cell is activated
  //  private bool isPlayerOn;
   
    //Actual Cell
    public GameObject cell;

    //CoverPlane
    public GameObject coverPlane = null;

    //Point to add or Remove
    protected int point;

    // handle to GUI action text
    protected TextMeshProUGUI ActionText;

    //handle to player
    protected GameObject _player;

    private void Awake()
    {
        //Each cell has a random amount of point
        point = Random.Range(1, 21);

        //We grabe the Action text UI
        ActionText = GameObject.Find("ActionText").GetComponent<TextMeshProUGUI>();

        //we grab the player
        _player = GameObject.Find("Player");

    }

    // Start is called before the first frame update
    void Start()
    {
//         isPlayerOn = false;

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetPlayerOn()
    {
        AddRemovePoint();
    }


    public virtual void AddRemovePoint()
    {

    }

    //destroy the cell if timer is up
    public void DesactivateCell()
    {
        gameObject.SetActive(false);
    }

    public void OnCollisionEnter(Collision collision)
    {
        SetPlayerOn();
    }

}
