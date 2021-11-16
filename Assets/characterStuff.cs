using UnityEngine;

public class characterStuff : MonoBehaviour
{

    public float playerHealth = 40f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth < 0)
        {
            Debug.Log("Player is Ded");
        }
    }
}
