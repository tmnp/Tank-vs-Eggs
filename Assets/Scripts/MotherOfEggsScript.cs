using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherOfEggsScript : MonoBehaviour
{

    public static MotherOfEggsScript _instance;

    void Awake()
    {
        _instance = this;
    }

}
