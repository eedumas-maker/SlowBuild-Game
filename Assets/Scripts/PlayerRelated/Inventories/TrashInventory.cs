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

    public Trash RemoveLastTrash()
    {
        Trash lastTrash = Contents[Contents.Count - 1];
        Contents.Remove(lastTrash);
        return lastTrash;
    }

}
