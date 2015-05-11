using UnityEngine;
using System.Collections;

public class BombController : MonoBehaviour {

    private Animator animController;

	// Use this for initialization
	void Start () {

        //Get the animator from the gameobject this script is attached to
        animController = gameObject.GetComponent<Animator>();
	}
	
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Simple little demo of how to talk to the animator
        //When we collide with something, we check if the animator is null or not
        //If not we set the 'isPrimed' trigger which kicks off the explosion loop
        if (animController != null)
            animController.SetTrigger("isPrimed");
    }
}
