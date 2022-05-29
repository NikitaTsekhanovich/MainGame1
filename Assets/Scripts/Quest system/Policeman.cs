using UnityEngine;

public class Policeman : MonoBehaviour, INPC
{
    [SerializeField] private Transform gopnik;
    [SerializeField] private BoxCollider2D policeman;
    private float speed = 0.02f;

    public void Update()
    {
        MoveTo();
    }

    public void MoveTo()
    {
        if (QuestPoliceman.pickUpCoins)
        {
            transform.position = Vector3.MoveTowards(transform.position, gopnik.position, speed);
            policeman.enabled = false;
        }
    }
}
