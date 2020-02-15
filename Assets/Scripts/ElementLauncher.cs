using UnityEngine;
using System.Collections;

public class ElementLauncher : MonoBehaviour {

    public GameObject[] elementPrefabs;
    public float fireDelay = 3f;
    public float fireVelocity = 10f;
    public float nextFire = 1f;



	void FixedUpdate ()
    {
        if (GameObject.FindObjectOfType<DeathTrigger>().hasLost)
            return;


        nextFire -= Time.deltaTime;

        if(nextFire <= 0)
        {
            nextFire = fireDelay;

            GameObject elemGO = (GameObject)Instantiate(
                                                        elementPrefabs[Random.Range(0, elementPrefabs.Length)], 
                                                        transform.position, 
                                                        transform.rotation
                                                        );
            elemGO.GetComponent<Rigidbody2D>().velocity = transform.rotation * new Vector2(0, fireVelocity);

            GameObject.FindObjectOfType<ScoreManager>().score++;
        }
	}
}
