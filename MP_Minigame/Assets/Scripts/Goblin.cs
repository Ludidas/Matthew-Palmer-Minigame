using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public FireballMinigameManager GameManager;
    private int goblinNum=5;

    public void destroyEnemy()
    {
        Destroy(this.gameObject);
        goblinNum--;
        if (goblinNum == 0)
        {
            GameManager.setGameWin(true);
        }
    }
}
