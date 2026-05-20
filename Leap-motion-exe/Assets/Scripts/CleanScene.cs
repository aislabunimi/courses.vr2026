using System.Collections.Generic;
using UnityEngine;

public class CleanScene : MonoBehaviour
{
    [Header("List of objects to instantiate")]
    public List<GameObject> items;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CleanAndSetup();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CleanAndSetup()
    {
        GameObject[] itemsToDestroy = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject item in itemsToDestroy){
            Destroy(item);
        }

        foreach (GameObject item in items)
        {
            Instantiate(item);
        }
        
        
    }
    
    
}
