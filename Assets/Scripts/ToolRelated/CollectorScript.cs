using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    PlayerController player;
    
    // Start is called before the first frame update
    private void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AddTrashToInventory(other);
        DestroyTrash(other);

    }

    private void AddTrashToInventory(Collider2D other)
    {
        bool objectIsJunk = other.gameObject.tag.Equals("junk");
        Trash trashType = other.GetComponent<Trash>();

        if (objectIsJunk) player.trashInv.AddTrash(trashType);               
    }

    private static void DestroyTrash(Collider2D other)
    {
        bool objectIsJunk = other.gameObject.tag.Equals("junk");
        GameObject trashObject = other.transform.parent.gameObject;

        if (objectIsJunk) Destroy(trashObject);         
    }

}
