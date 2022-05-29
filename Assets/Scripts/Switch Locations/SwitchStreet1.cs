using UnityEngine;

public class SwitchStreet1 : MonoBehaviour, ISwitch
{
    public GameObject activeLocation;
    public GameObject nextLocation;
    public GameObject sun;
    public GameObject sky;

    public void OnTriggerStay2D(Collider2D other)
    {
        var space = Input.GetKeyUp(KeyCode.Space);
        if (space)
        {
            activeLocation.SetActive(false);
            nextLocation.SetActive(true);
            sky.SetActive(false);
            sun.SetActive(false);
        }
    }
}
