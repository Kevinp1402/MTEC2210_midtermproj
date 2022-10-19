using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

   
{
    public AudioClip coinSound;
    public AudioClip hazardSound;
    public GameManager gm;


   public float speed; // Start is called before the first frame update
void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");




        transform.Translate(xMove * speed * Time.deltaTime, 0, 0);



    }

    


         private void OnTriggerEnter2D(Collider2D collider)
         { 

           if(collider.gameObject.tag == "coin")
        {
            gm.IncrementScore(1);

            gm.PlaySound(coinSound);
            Destroy(collider.gameObject);

        }

           if(collider.gameObject.tag == "dirt")
        {
            gm.PlaySound(hazardSound);
            Destroy(gameObject);

        }

        Debug.Log("Triggered");

         }

}
