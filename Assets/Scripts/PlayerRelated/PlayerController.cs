using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{    
    public TrashInventory trashInv;
    public IAction activeAction = new Throw();

    // Start is called before the first frame update
    void Start()
    {
        trashInv = new TrashInventory();
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

}
