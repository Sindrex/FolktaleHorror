using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Orbs
    public int maxorbs;
    public int orbs = 0;
    public Text orbText;
    public Text dialogueText;

    //Movement
    public float moveSpeed;
    public float crawlSpeed;
    public bool isCrawling;

    // Use this for initialization
    void Start () {
        orbText.text = "Orbs: " + orbs + "/" + maxorbs;
        dialogueText.gameObject.SetActive(false);
        dialogue();

        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        //print(Input.GetAxis("Horizontal") + "/" + Input.GetAxis("Vertical"));
        if(Input.GetAxis("Horizontal") == 0)
        {
            //rb.velocity = new Vector3(0,0,rb.velocity.z);
        }
        if(Input.GetAxis("Vertical") == 0)
        {
            //rb.velocity = new Vector3(rb.velocity.x,0,0);
        }
        //transform.Translate(Input.GetAxis("Horizontal") * moveSpeed,0, Input.GetAxis("Vertical") * moveSpeed);
        //rb.velocity += new Vector3(Input.GetAxis("Horizontal") * moveSpeed,0, Input.GetAxis("Vertical") * moveSpeed);
        rb.velocity += transform.right * Input.GetAxis("Horizontal") * moveSpeed + transform.forward * Input.GetAxis("Vertical") * moveSpeed;

        if (Input.GetKeyDown(KeyCode.C)){
            //Crouch/Crawl
            if (!isCrawling)
            {
                transform.localScale = new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
                isCrawling = true;
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x, 1, transform.localScale.z);
                isCrawling = false;
            }
        }
    }

    public void addOrb()
    {
        orbs++;
        print(orbs);
        orbText.text = "Orbs: " + orbs + "/" + maxorbs;
        if(orbs >= maxorbs)
        {
            dialogueText.text = "I can go now...";
            dialogue();
        }
    }

    public void dialogue()
    {
        dialogueText.gameObject.SetActive(true);
        StartCoroutine(disableDialogue());
    }

    IEnumerator disableDialogue()
    {
        yield return new WaitForSeconds(2f);
        dialogueText.gameObject.SetActive(false);
    }
}
