using UnityEngine;
using System.Collections;

public class Singleton : MonoBehaviour
{
    private static Singleton instance = null;
    public int stageNum = 0;
    public bool isReplay = false;

    public static Singleton getInstance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType(typeof(Singleton)) as Singleton;
                if (instance == null)
                {
                    Debug.Log("No Instance");
                }
            }
            return instance;
        }
    }
}
