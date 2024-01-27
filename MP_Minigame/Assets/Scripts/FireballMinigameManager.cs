using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMinigameManager : MonoBehaviour
{
    public GameObject goblin;
    public GameObject[] spawnLocations;
    private bool gameWin = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnGoblin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Can be used to determine if game is finished
    public void setGameWin(bool w)
    {
        gameWin= w;
        Debug.Log("GAME WIN");
    }

    void spawnGoblin()
    {
        GameObject spawnedPrefab;

        for (int i = 0; i < spawnLocations.Length; i++)
        {
            spawnedPrefab = Instantiate(goblin.gameObject);
            spawnedPrefab.transform.position = new Vector2(spawnLocations[i].transform.position.x, spawnLocations[i].transform.position.y);
        }
    }
}
