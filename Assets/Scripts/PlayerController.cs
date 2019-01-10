using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Orbs
    public int maxorbs;
    public int orbs = 0;
    public Text orbText;

    //Movement
    public float moveSpeed;
    public float crawlSpeed;

    // Use this for initialization
    void Start () {
        orbText.text = "Orbs: " + orbs + "/" + maxorbs;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        //transform.Translate(Input.GetAxis("Horizontal") * moveSpeed,0, Input.GetAxis("Vertical") * moveSpeed);
        //rb.velocity += new Vector3(Input.GetAxis("Horizontal") * moveSpeed,0, Input.GetAxis("Vertical") * moveSpeed);
        rb.velocity += transform.right * Input.GetAxis("Horizontal") * moveSpeed + transform.forward * Input.GetAxis("Vertical") * moveSpeed;
    }

    public void addOrb()
    {
        orbs++;
        print(orbs);
        orbText.text = "Orbs: " + orbs + "/" + maxorbs;
    }
}
