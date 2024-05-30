using UnityEngine;

public class CollectFuel : MonoBehaviour
{
    // This method is called when the trigger collider of this object collides with another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object is tagged as "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Fuel collected by player.");
            // If so, fill the fuel to full using FuelController instance
            FuelController.instance.FillFull();
            
            // Destroy this game object after collecting fuel
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Update code can be added here if needed
    }
}
