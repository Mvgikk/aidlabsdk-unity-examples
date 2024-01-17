using UnityEngine;

public class Example : MonoBehaviour
{
    public float movementSpeed = 2.0f;
    public float horizontalMultiplier = 1.0f;
    public float verticalMultiplier = 1.0f;

    private float orientationValueX;
    private float orientationValueY;
    private float orientationValueZ;



    void Start()
    {
        // Initialize AidlabSDK
        Aidlab.AidlabSDK.init();

        // Subscribe to the orientation event
        Aidlab.AidlabSDK.aidlabDelegate.orientation.Subscribe(GetOrientationValues);
    }

    void Update()
    {
        // Move the object using the stored orientation values
        float offsetX = orientationValueX * movementSpeed * horizontalMultiplier * Time.deltaTime;
        float offsetY = orientationValueY * movementSpeed * verticalMultiplier * Time.deltaTime;

        // Apply the movement to the object
        transform.Translate(new Vector3(offsetX, offsetY, 0));
    }

    // Callback method for the orientation event
    private void GetOrientationValues()
    {
        // Get the orientation values
        orientationValueX = Aidlab.AidlabSDK.aidlabDelegate.orientation.x;
        orientationValueY = Aidlab.AidlabSDK.aidlabDelegate.orientation.y;
        orientationValueZ = Aidlab.AidlabSDK.aidlabDelegate.orientation.z;

        Debug.Log("Orientation Values: X = " + orientationValueX + ", Y = " + orientationValueY);
    }
}
