using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDictionary : MonoBehaviour
{
    public static Dictionary<string, GameObject> trashDictionary;

    private void Start()
    {
        trashDictionary = new Dictionary<string, GameObject>();
        trashDictionary.Add("Pizza", (GameObject)Resources.Load("Prefabs/Pizza"));
        trashDictionary.Add("SwordHilt", (GameObject)Resources.Load("Prefabs/SwordHilt"));
    }
}
