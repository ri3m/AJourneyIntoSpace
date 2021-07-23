using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreEnemyDestruction : MonoBehaviour
{
    public GameObject scorePickup;
    public int amount=5;
    private void OnDestroy() {
        /* try{
        

        }catch(){

        } */
        //scorePickup.GetComponent<ScorePickup>().scoreAmount=amount;
        GameObject.Instantiate(scorePickup, transform.position, transform.rotation);
        
    }
}
