using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SnapShotColider : MonoBehaviour
{
    public AudioMixerSnapshot day;
    public AudioMixerSnapshot night;
    bool isNight = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {  
            if (!isNight)
            { 
            night.TransitionTo(0.5f);
                isNight = true;
            
            }
        else
            {
                day.TransitionTo(0.5f);
                isNight = false;
            }
        }

        

       


    }

   // private void OnTriggerStay(Collider other)
   // {
        
  // }

   // private void OnTriggerExit(Collider other)
   // {    
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
