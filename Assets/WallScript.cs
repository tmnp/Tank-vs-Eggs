using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

    public static WallScript _instance;
	void Awake ()
    {
        _instance = this;		
	}
	
}
