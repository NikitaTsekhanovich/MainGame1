using UnityEngine;

public class SwitchRoom : MonoBehaviour, ISwitch
{
    public GameObject activeLocation;
    public GameObject nextLocation;
    public GameObject sun;
    public GameObject sky;
    public GameObject switchLocation;
    
    public void OnTriggerStay2D(Collider2D other)
    {
        var space = Input.GetKeyUp(KeyCode.Space);
        if (space)
        {
            activeLocation.SetActive(false);
            nextLocation.SetActive(true);
            sky.SetActive(true);
            sun.SetActive(true);
            switchLocation.SetActive(true);
        }
    }
}