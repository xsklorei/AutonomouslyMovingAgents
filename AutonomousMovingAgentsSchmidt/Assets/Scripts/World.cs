using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class World
{
    private static readonly World instance = new World();
    private static GameObject[] hidingSpots;

    static World()
    {
        hidingSpots = GameObject.FindGameObjectsWithTag("hide");
    }

    private World()
    {

    }

    public static World Instance
    {
        get { return instance; }
    }
    public GameObject[] GetHidingSpots()
    {
        return hidingSpots;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
