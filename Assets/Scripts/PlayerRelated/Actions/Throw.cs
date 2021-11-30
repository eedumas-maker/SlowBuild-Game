using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : IAction
{

    public void Activate(PlayerController player)
    {
        Trash lastTrashType = player.trashInv.GetLastTrashIn();
        player.trashInv.RemoveLastTrash();
        GameObject trashProjectile = GameObject.Instantiate(TrashDictionary.trashDictionary[lastTrashType.Name], player.transform.position, player.transform.rotation);
        Trash typeOfTrashProjectile = trashProjectile.GetComponentInChildren<Trash>();
        typeOfTrashProjectile.throwBehavior.Throw(trashProjectile.GetComponentInChildren<Rigidbody2D>(), player.transform.forward);

        
    }
}

