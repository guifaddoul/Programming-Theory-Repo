using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCell : CellParentScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void AddRemovePoint()
    {
        ActionText.text = point + " points gained";
        _player.GetComponent<PlayerController>().setPlayerEnergy(point);
    }

}
