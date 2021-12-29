using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CellParentScript : MonoBehaviour
{
    //boolean indicating if the cell is activated
    private bool isPlayerOn;
   
    //Actual Cell
    public GameObject cell;

    //CoverPlane
    public GameObject coverPlane = null;

    //Point to add or Remove
    public int point;

    // Start is called before the first frame update
    void Start()
    {
         isPlayerOn = false;

        point = Random.Range(1, 21);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetPlayerOn()
    {
        isPlayerOn = true;
        AddRemovePoint();
    }


    public virtual void AddRemovePoint()
    {

    }

    //destroy the cell if timer is up
    public void DesactivateCell()
    {
        // Destroy(gameObject);
        gameObject.SetActive(false);
    }

}
