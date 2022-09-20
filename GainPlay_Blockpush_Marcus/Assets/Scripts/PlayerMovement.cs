using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public PauseMenu pauseMenu;
    public Spawner spawner;
    public GameManager gameManager;
   
    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if(Input.GetKeyDown("escape"))
        {
            pauseMenu.PauseGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Point")
        {
            gameManager.points = gameManager.points + 10;
            Destroy(other.gameObject);
        }
    }
}
