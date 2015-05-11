using UnityEngine;
using System.Collections;

public class DudeController : MonoBehaviour {

    private Animator animController;

    void Start()
    {
        //Get the animator from the gameobject this script is attached to
        animController = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //We will use the horizontal input to indicate direction (left, right)
        //Then the vertical will represent 'speed' ie going forward
        float direction = Input.GetAxis("Horizontal");
        float speed = Input.GetAxis("Vertical");

        //If the animator is not null we send the information to it
        if (animController != null)
        {
            //Set the direction and speed variables within the animator
            animController.SetFloat("Speed", speed);
            animController.SetFloat("Direction", direction);

            //If the jump button has been pressed and then released, we set the trigger and we fire the jump animation
            if (Input.GetButtonUp("Jump"))
                animController.SetTrigger("Jump");
        }
    }
}
