using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Prędkość poruszania obiektu
    public float movementSpeed = 2.0f;
        // Ograniczenia położenia obiektu na osi Y
    public float minY = -5f;
    public float maxY = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Aidlab.AidlabSDK.init();
       // Aidlab.AidlabSDK.aidlabDelegate.respiration.Subscribe(MoveObjectWithRespiration);
        Aidlab.AidlabSDK.aidlabDelegate.respiration.Subscribe(() => { Debug.Log(Aidlab.AidlabSDK.aidlabDelegate.respiration.value); });
    }

    // Update is called once per frame
    void Update()
    {

        // Your update logic here
    }

    // Metoda do poruszania obiektu na podstawie wartości respiration
    private void MoveObjectWithRespiration()
    {   
       // Debug.Log(Aidlab.AidlabSDK.aidlabDelegate.respiration.value);
        // Pobierz wartość respiration
        float respirationValue = Aidlab.AidlabSDK.aidlabDelegate.respiration.value;
        Debug.Log(respirationValue);
        // Zastosuj wartość respiration do przesunięcia obiektu wzdłuż osi Y
        float scaledMovement = respirationValue * movementSpeed * Time.deltaTime;
        Debug.Log("Scaled movement: " + scaledMovement);
        // Ogranicz pozycję obiektu na osi Y
        float clampedY = Mathf.Clamp(transform.position.y + scaledMovement, minY, maxY);
        transform.position = new Vector3(transform.position.x, clampedY, transform.position.z);
        
    }
}