using UnityEngine;

public static class SleaseMode
{
    public static GameObject[] enemy;
    public static bool mode = false;

    public static void sleaseMode()
    {
        if (mode == false)
        {
            mode = true;
            Debug.Log("Mode active!");
        }
        else
        {
            mode = false;
            Debug.Log("Mode deactive!");
        }
    }

    public static void fillEnemyArray()
    {
        enemy = GameObject.FindGameObjectsWithTag("enemy");
        Debug.Log("Number of enemies in level: " + enemy.Length);
    }
}
