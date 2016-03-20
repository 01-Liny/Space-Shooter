using UnityEngine;
using System.Collections;

public class DestoryByContact : MonoBehaviour {

    public GameObject explostion;
    public GameObject playerExplostion;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explostion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplostion, other.transform.position, other.transform.rotation); 
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
