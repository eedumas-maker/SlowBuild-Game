using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashInventory 
{
    public List<Trash> Contents;

    public TrashInventory()
    {
        Contents = new List<Trash>();
    }

    public void AddTrash(Trash trash)
    {
        Contents.Add(trash);        
    }

    public Trash GetLastTrashIn()
    {
        return Contents[Contents.Count - 1];
    }
    public void RemoveLastTrash()
    {        
        Contents.RemoveAt(Contents.Count - 1);      
    }

}
