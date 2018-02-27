using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Start () {
        print("level : " + GameManager.instance.level);
	}	
}
