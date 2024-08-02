using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rescue : MonoBehaviour
{
    private int dogsInTruck = 0;
    [SerializeField] GameObject dogBoxRed;
    [SerializeField] GameObject dogBoxBlue;
    [SerializeField] Transform dogInBoxRed;
    [SerializeField] Transform dogInBoxBlue;

    private GameObject dog1;
    private GameObject dog2;

    private void OnCollisionEnter2D(Collision2D other) {
        if ((other.gameObject.tag == "Dog") && (dogsInTruck < 2))
        {
            Debug.Log("dog picked up");
            if (dogsInTruck == 0)
            {
                dog1 = other.gameObject;
                dogBoxRed.SetActive(true);
                dog1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                dog1.transform.parent = dogInBoxRed;
                dog1.transform.localPosition = Vector3.zero;
            }
            else
            {
                dog2 = other.gameObject;
                dogBoxBlue.SetActive(true);
                dog2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                dog2.transform.parent = dogInBoxBlue;
                dog2.transform.localPosition = Vector3.zero;
            }
            dogsInTruck++;
        }
        
        if ((other.gameObject.tag == "RescueCenter") && (dogsInTruck > 0))
        {
            Debug.Log("dog left at resque center");
            dogBoxBlue.SetActive(false);
            dogBoxRed.SetActive(false);
            Destroy(dog1);
            Destroy(dog2);
            dogsInTruck = 0;
        }
    }
}
