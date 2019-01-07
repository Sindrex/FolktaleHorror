using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupOrb : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("Player"))
        {
            other.transform.GetComponent<PlayerController>().addOrb();
            Destroy(this.gameObject);
        }
    }
}
