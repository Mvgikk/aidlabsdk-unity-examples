using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Aidlab.AidlabSDK.init();
        Aidlab.AidlabSDK.aidlabDelegate.respiration.Subscribe(() => { Debug.Log(Aidlab.AidlabSDK.aidlabDelegate.respiration.value); });

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
