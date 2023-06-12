using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishDataManager : MonoBehaviour
{
    public TextAsset jsonFile;
    public Fishes fishList;
    public Fish[] fishes;
 
    void Start()
    {
        // reads fish data from json file
        Fishes fishList = JsonUtility.FromJson<Fishes>(jsonFile.text);
 
        foreach (Fish fish in fishList.fishes)
        {
            Debug.Log(fish.name);
            Debug.Log(fish.index);
        }

        fishes = fishList.fishes;
    }

    void Update()
    {
        
    }

    // utility function, probably
    public Fish GetFish(int index)
    {
        return (fishes[index]);
    }
}