using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class EndCell : CellParentScript
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
        ActionText.text =  "You Won !";
        _player.GetComponent<PlayerController>().setWiningStatus(true);
    }
}
