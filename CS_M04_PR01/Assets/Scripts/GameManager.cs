using System;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        if (SleaseMode.mode)
        {
            SleaseMode.fillEnemyArray();
        }
    }
}
