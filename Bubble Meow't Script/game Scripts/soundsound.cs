using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSound : MonoBehaviour
{
  
    void StayAwake()
    {
       
            DontDestroyOnLoad(transform.gameObject);
         
    }
    
}
