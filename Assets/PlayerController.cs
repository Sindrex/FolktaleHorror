using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public int maxorbs;
    public int orbs = 0;
    public Text orbText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addOrb()
    {
        orbs++;
        print(orbs);
        orbText.text = "Orbs: " + orbs + "/" + maxorbs;
    }
}
