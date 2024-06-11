using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetavelManager : MonoBehaviour
{
    public static ColetavelManager instance;

    public bool isCollected = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool CanCollect()
    {
        return !isCollected;
    }

    public void SetCollected(bool state)
    {
        isCollected = state;
    }
}
