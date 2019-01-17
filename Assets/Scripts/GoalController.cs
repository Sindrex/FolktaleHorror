using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour {

    public string playerTag;
    public UIController UI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag(playerTag))
        {
            PlayerController pc = other.transform.parent.GetComponent<PlayerController>();
            if(pc.orbs < pc.maxorbs)
            {
                pc.dialogue();
            }
            else
            {
                UI.win();
            }
        }
    }
}
