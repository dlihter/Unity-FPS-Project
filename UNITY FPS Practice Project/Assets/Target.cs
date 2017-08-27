using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour //ovo proslijeđuje neku vrijednost gm kako bi mogli pratiti score
{
    public int ScoreValue = 0;
    //public float TimeValue = 0.0f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Rocket"))
        {
            //Update Score
            GameManager.GM.AddScore(ScoreValue);
            //Update Time
            //GameManager.GM.AddTime(TimeValue);

            //Destroy(other.gameObject);
            //Destroy(gameObject);
        }
    }
}
