using System;
using UnityEngine;

public class PengeManager : MonoBehaviour
{
    public static PengeManager instance;
    public int pinge;
    void Awake()
    {
        if (instance == this || instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(this);
        }
    }
}
