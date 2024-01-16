using UnityEngine;

public class Example : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    public float minY = -5f;
    public float maxY = 5f;

    private float respirationValue;

    void Start()
    {
        // Initialize AidlabSDK
        Aidlab.AidlabSDK.init();

        // Subscribe to the respiration event
        Aidlab.AidlabSDK.aidlabDelegate.respiration.Subscribe(GetRespirationValue);
    }

    void Update()
    {
        // Move the object using the stored respiration value
        float scaledMovement = respirationValue * movementSpeed * Time.deltaTime;
        float newY = Mathf.Clamp(transform.position.y + scaledMovement, minY, maxY);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    // Callback method for the respiration event
    private void GetRespirationValue()
    {
        // Get the respiration value
        respirationValue = Aidlab.AidlabSDK.aidlabDelegate.respiration.value;
        Debug.Log("Respiration Value: " + respirationValue);
    }
}
