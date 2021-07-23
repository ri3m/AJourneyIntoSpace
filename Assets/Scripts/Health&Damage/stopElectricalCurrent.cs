using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopElectricalCurrent : Pickup
{
    public GameObject electricalCurrent;
    public AudioSource electricalCurrentStopped;
    private bool doneOnce=false;

    public override void DoOnPickup(Collider collision)
    {
        if(doneOnce)
            return;
        if (collision.tag == "Player" && collision.gameObject.GetComponent<Health>() != null)
        {
            StartCoroutine(WaitThenDestroy(collision));
            GameObject.Destroy(electricalCurrent);
            electricalCurrentStopped.Play();
            
            foreach(Transform part in gameObject.transform){
                part.gameObject.SetActive(false);
            }
            doneOnce=true;
        }
        
    }

    private IEnumerator WaitThenDestroy(Collider collision)
    {
        
            yield return new WaitForSeconds(5);
            Destroy(gameObject);
            //base.DoOnPickup(collision);
        
        
    }
}
