using UnityEngine;
using UnityEngine.InputSystem;

public class actionInputTest : MonoBehaviour
{
    public InputActionReference interact;

    public bool ePressed;
    public GameObject theDude;
    public float forceMultiplier = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ePressed)
        {
            Debug.Log("E IS PRESSED");
            theDude.GetComponent<Rigidbody>().AddForce(transform.up * forceMultiplier, ForceMode.Impulse);
        }
    }

    void ThrowTheDude(InputAction.CallbackContext ctx)
    {
        Debug.Log("Interact Started");
        ePressed = true;

    }

    void InteractEnded(InputAction.CallbackContext ctx)
    {
        ePressed = false;
    }

    private void OnEnable()
    {

        interact.action.started += ThrowTheDude;
        interact.action.canceled += InteractEnded;

    }

    private void OnDisable()
    {
        interact.action.started -= ThrowTheDude;
    }

}

