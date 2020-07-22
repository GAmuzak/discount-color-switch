using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class boom : MonoBehaviour
{
    public ParticleSystem particleprefab; 
    void die()
    {
        ParticleSystem explode = Instantiate(particleprefab) as ParticleSystem;
        explode.transform.position = transform.position;
        explode.Play();
        Destroy(gameObject);

    }

    
    void Update()
    {
        

    }
    private void OnMouseDown()
    {
        die();
    }
}
