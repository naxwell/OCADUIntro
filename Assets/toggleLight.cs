using UnityEngine;

public class toggleLight : MonoBehaviour
{
    public Light pinkLight;
    public characterStuff charStuff;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        pinkLight.enabled = !pinkLight.enabled;
        charStuff.playerHealth -= 5f;
    }
}
