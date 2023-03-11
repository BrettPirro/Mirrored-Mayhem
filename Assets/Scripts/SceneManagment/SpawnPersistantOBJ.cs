using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPersistantOBJ : MonoBehaviour
{
    [SerializeField] GameObject PersitantOBJ;
    static bool Spawned=false;

    private void Awake()
    {
        if (Spawned != true) 
        {
            GameObject OBJ= Instantiate(PersitantOBJ)as GameObject;
            DontDestroyOnLoad(OBJ);
            Spawned = true;
        }
        else 
        {
            Debug.Log("Already In Scene");
        }
    }
}
