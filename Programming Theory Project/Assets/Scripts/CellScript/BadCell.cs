using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class BadCell : CellParentScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // POLYMORPHISM
    public override void AddRemovePoint()
    {
        ActionText.text = point + " points lost";
        _player.GetComponent<PlayerController>().setPlayerEnergy(-point);
    }
}
